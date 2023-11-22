﻿using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using MedicalManagementSoftware.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementSoftware.PhysicalExaminationReport
{



    public partial class FrmPhysicalExamination : Form, MyInter
    {

        

        Main fmain;
        public DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
        public List<Panama_SeaMLC> Panama_SeaMLC_model = new List<Panama_SeaMLC>();


        private string nameOfPhysician = "MA. LUCIA B. LAGUIMUN, M.D";
        private string addressOfPhysician = "CENTERPORT MEDICAL SERVICES, INC. 4/F VICTORIA BLDG., 429 U.N. AVE. ERMITA, MANILA";
        private string nameOfPhysicianCertificating = "PROFESSIONAL REGULATION COMMISSION";
        private string dateOfPhysicianCertificate = "JAN 13, 1993";
        private string dateOfPhysicianExamination = "";

        //

        public FrmPhysicalExamination(Main m)
        {
            InitializeComponent();

            fmain = m;
        }

        private void FrmPhysicalExamination_Load(object sender, EventArgs e)
        {


            this.AutoScroll = true;

            int newWidth = 835;
            int newHieght = 855;
            overlayShadow1.MaximumSize = new Size(newWidth, newHieght);
            overlayShadow1.Size = new Size(newWidth, overlayShadow1.Height);
            Availability(overlayShadow1, false);




        }

        private void label27_Click(object sender, EventArgs e)
        {

        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                DataClasses2DataContext d = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
                var list = d.Panama_SeaMLC("%");
                Cursor.Current = Cursors.WaitCursor;
                foreach (var i in list)
                {
                    Panama_SeaMLC_model.Add(new Panama_SeaMLC
                    {
                        cn = i.cn,
                        papin = i.papin,
                        resultID = i.resultid,
                        patientName = i.PatientName,
                        resultDate = i.result_date,
                        recommendation = i.recommendation

                    });


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
        }

        void clearFields()
        {

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }


        }
        public void ClearAll()
        {
            clearFields();
        }



        private void searchPatient()
        {

            DataClasses2DataContext db = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
            var l = db.spLiberiaSelect(txtPapin.Text).FirstOrDefault();



            if (l != null)
            {
                
                txtlastname.Text = l.lastname;
                txtFirstname.Text = l.firstname;
                txtMiddleName.Text = l.middlename;
                txtBirthDate.Text = l.birthdate;
                txtPlaceOfBirth.Text = l.place_of_birth;
                txtHomeAddress.Text = l.HomeAddress;
                txtLicenceNumber.Text = l.LiberiaLicenseNumber == null ? "" : l.LiberiaLicenseNumber;
                txtPhysicianDateOfExam.Text = 
                txtHeight.Text = l.Height + " CM";
                txtWeight.Text = l.Weight + " KG";
                string bp_diastolic =  l.BP+"/"+l.BP_DIASTOLIC;
                txtBloodPressure.Text = l.BloodPressure ==null?bp_diastolic:l.BloodPressure;
                txtPulse.Text = l.Pulse+"/MIN.";
                txtRespiration.Text = l.RESPIRATION_exam == null ? l.Respiration + "/MIN." : l.RESPIRATION_exam + "/MIN.";

                txtRightEyeWithOutGlasses.Text = l.VissionRightEye == null ? "20/20" : l.VissionRightEye;
                txtLeftEyeWithOutGlasses.Text = l.VissionLeftEye == null ? "20/20" : l.VissionLeftEye;
                txtRightEyeWithGlasses.Text = l.VissionWithGlassRight == null ? "20/20" : l.VissionWithGlassRight;
                txtLeftEyeWithGlasses.Text = l.VissionWithGlassLeft == null ? "20/20" : l.VissionWithGlassLeft;
                txtPhysicianDateOfExam.Text = l.ExaminationDate == null ? "" : l.ExaminationDate;
                string d = l.COLOR_VISION_DATE_TAKEN ==null ? l.COLOR_VISION_DATE_TAKEN_exam.ToString(): l.COLOR_VISION_DATE_TAKEN.ToString();
                DateTime temp;
                if (DateTime.TryParse(d, out temp))
                {
                    txtDateOfColorVisionTest.Text = d;
                }
                else
                {
                    txtDateOfColorVisionTest.Text = DateTime.Now.ToShortDateString();
                }


                string fullname = txtlastname.Text + ", " + txtFirstname.Text + " " + txtMiddleName.Text;
                txtNameOfApplicant.Text = fullname;
                txtDateOfExam.Text = l.result_date == null? l.fitnessDate:l.result_date;
                txtExpirydate.Text = l.valid_until == null ? l.expiryDate : l.valid_until;

                if (l.gender.ToLower().Equals("male") || l.gender.ToLower().Equals("M"))
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }


                txtMasterPosition.Text = l.PositionMaster == null ? "" : l.PositionMaster;
                txtMatePosition.Text = l.PositionMate == null ? "" : l.PositionMate;
                txtEngineerPosition.Text = l.PositionEngineer == null ? "" : l.PositionEngineer;
                txtRatingPosition.Text = l.PositionRating == null ? "" : l.PositionRating;



                if (l.ColorVissionMeetsStandard == null)
                {
                    rbColorVissionMeetsYes.Checked = true;
                    rbColorVissionMeetsNo.Checked = false;
                }
                else
                {
                    if (l.ColorVissionMeetsStandard.Equals("Y"))
                    {
                        rbColorVissionMeetsYes.Checked = true;
                        rbColorVissionMeetsNo.Checked = false;
                    }
                    else
                    {
                        rbColorVissionMeetsNo.Checked = true;
                        rbColorVissionMeetsYes.Checked = false;
                    }
                }

               

                //-----------------------------------
                CbColorTestTypeYellow.Checked = false;
                CbColorTestTypeRed.Checked = false;
                CbColorTestTypeGreen.Checked = false;
                CbColorTestTypeBlue.Checked = false;



                if (l.forDuty == null)
                {
                    foreach(Control  control in flowLayoutPanel1.Controls){
                         if (control is CheckBox){
                             ((CheckBox)control).Checked = false;
                         }
                    }

                    foreach (Control control in flowLayoutPanel2.Controls)
                    {
                        if (control is CheckBox)
                        {
                            ((CheckBox)control).Checked = false;
                        }
                    }
                
                }
                else
                {
                    foreach (Control control in flowLayoutPanel1.Controls)
                    {
                        if ((control is CheckBox) && l.forDuty.Contains(((CheckBox)control).Name.Replace("cb","")))
                        {
                            ((CheckBox)control).Checked = true;
                        }
                        else
                        {
                            ((CheckBox)control).Checked = false;
                        }
                    }


                    foreach (Control control in flowLayoutPanel2.Controls)
                    {
                        if ((control is CheckBox) && l.forDuty.Contains(((CheckBox)control).Name.Replace("cb", "")))
                        {
                            ((CheckBox)control).Checked = true;
                        }
                        else
                        {
                            ((CheckBox)control).Checked = false;
                        }
                    }



                }



                if (l.ColorTestType == null)
                {
                    CbColorTestTypeRed.Checked = true;
                    CbColorTestTypeGreen.Checked = true;
                }
                else
                {
                    
                    if (l.ColorTestType.Contains("Yellow"))
                    {
                        CbColorTestTypeYellow.Checked = true;

                    }
                     if (l.ColorTestType.Contains("Red"))
                    {
                        CbColorTestTypeRed.Checked = true;
                    }
                     if (l.ColorTestType.Contains("Green"))
                    {
                        CbColorTestTypeGreen.Checked = true;
                    }
                     if (l.ColorTestType.Contains("Blue"))
                    {
                        CbColorTestTypeBlue.Checked = true;
                    }
                }

               


                txtHeart.Text = l.Heart ==null?"NORMAL":l.Heart;
                txtLungs.Text = l.Lungs == null ? "NORMAL CHEST  FINDINGS" : l.Lungs;

                txtExtremitiesUpper.Text = l.ExtremitiesUpper == null ? "NORMAL" : l.ExtremitiesUpper;
                txtExtremitiesLower.Text = l.ExtremitiesLower == null ? "NORMAL" : l.ExtremitiesLower;

                txtGeneralAppearance.Text = l.GeneralAppearance == null ? "NORMAL" : l.GeneralAppearance;


                txtHearingRight.Text = l.HearingRight == null ? "NORMAL HEARING ACUITY" : l.HearingRight;
                txthearingLeft.Text = l.HearingLeft == null ? "NORMAL HEARING ACUITY" : l.HearingLeft;

                cbo_satisfactory_Unaided.Text = l.SATISFACTORY_SIGHT_UNAID;

                txtSpeach.Text = l.Speach;

                txtNameOfPhysician.Text = nameOfPhysician;
                txtAddress.Text = addressOfPhysician;
                txtPhysicianCertificatingAuthority.Text = nameOfPhysicianCertificating;
                txtDateOfIssuePhysicianCertificate.Text = dateOfPhysicianCertificate;
            }
            else
            {



            }

        }


        public void searchPhyExamRecord(string papin)
        {
           
            clearFields();
            txtPapin.Text = papin;
            searchPatient();

            ClosePreview();
        }


        public void New()
        {
            fmain.toolStripPhyExamEdit.Enabled = false;
            fmain.toolStripPhyExamDelete.Enabled = false;
            fmain.toolStripPhyExamSave.Enabled = true;
            fmain.toolStripPhyExamCancel.Enabled = true;
            fmain.toolStripPhyExamPrint.Enabled = true;
            fmain.toolStripPhyExamPrintPreview.Enabled = true;
            fmain.toolStripPhyExamSearch.Enabled = false;

          

        }

        public void Save()
        {
            fmain.toolStripPhyExamEdit.Enabled = true;
            fmain.toolStripPhyExamDelete.Enabled = false;
            fmain.toolStripPhyExamSave.Enabled = false;
            fmain.toolStripPhyExamCancel.Enabled = false;
            fmain.toolStripPhyExamPrint.Enabled = true;
            fmain.toolStripPhyExamPrintPreview.Enabled = true;
            fmain.toolStripPhyExamSearch.Enabled = true;
            Availability(overlayShadow1, false);
            saveLiberia();
        }


        private void saveLiberia()
        {
            string ExaminationForDuty = "";


            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if ((control is CheckBox) && ((CheckBox)control).Checked)
                {
                    if (control.Name.Equals("cbMaster"))
                    {
                        ExaminationForDuty += "Master";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("Master", "");
                    }

                    if (control.Name.Equals("cbMate"))
                    {
                        ExaminationForDuty += "Mate";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("Mate", "");
                    }

                    if (control.Name.Equals("cbEngineer"))
                    {
                        ExaminationForDuty += "Engineer";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("Engineer", "");
                    }


                    if (control.Name.Equals("cbRadioOff"))
                    {
                        ExaminationForDuty += "RadioOff";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("RadioOff", "");
                    }
                    
                }

            }



            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if ((control is CheckBox) && ((CheckBox)control).Checked)
                {
                    if (control.Name.Equals("cbRating"))
                    {
                        ExaminationForDuty += "Rating";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("Rating", "");
                    }

                    if (control.Name.Equals("cbMouDeck"))
                    {
                        ExaminationForDuty += "MouDeck";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("MouDeck", "");
                    }

                    if (control.Name.Equals("cbMouMakina"))
                    {
                        ExaminationForDuty += "MouMakina";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("MouMakina", "");
                    }


                    if (control.Name.Equals("cbSuperNumerary"))
                    {
                        ExaminationForDuty += "SuperNumerary";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("SuperNumerary", "");
                    }

                }

            }

            //Console.WriteLine(ExaminationForDuty);




            string ColorVissionMeetsStandard = "N";

            if (rbColorVissionMeetsYes.Checked)
            {
                ColorVissionMeetsStandard = "Y";
            }

            string ColorTestType = "";        


            foreach (Control control in flowLayoutPanel3.Controls)
            {
                if ((control is CheckBox) && ((CheckBox)control).Checked)  
                {
                  if(control.Name.Equals("CbColorTestTypeYellow")){
                      ColorTestType += "Yellow";
                  }
                  else
                  {
                      ColorTestType.Replace("Yellow","");
                  }

                  if (control.Name.Equals("CbColorTestTypeRed"))
                  {
                      ColorTestType += "Red";
                  }
                  else
                  {
                      ColorTestType.Replace("Red", "");
                  }


                  if (control.Name.Equals("CbColorTestTypeGreen"))
                  {
                      ColorTestType += "Green";
                  }
                  else
                  {
                      ColorTestType.Replace("Green", "");
                  }


                  if (control.Name.Equals("CbColorTestTypeBlue"))
                  {
                      ColorTestType += "Blue";
                  }
                  else
                  {
                      ColorTestType.Replace("Blue", "");
                  }

                }


                //Console.WriteLine(ColorTestType);
            }




            LiberiaModel liberiaModel = new LiberiaModel();
            liberiaModel.save(txtPapin.Text, ExaminationForDuty, txtHeight.Text, txtWeight.Text, txtBloodPressure.Text, txtPulse.Text, txtRespiration.Text, txtGeneralAppearance.Text, txtRightEyeWithOutGlasses.Text, txtLeftEyeWithOutGlasses.Text, txtRightEyeWithGlasses.Text, txtLeftEyeWithGlasses.Text, ColorVissionMeetsStandard, ColorTestType, txtHearingRight.Text, txthearingLeft.Text, txtHeart.Text, txtLungs.Text, txtSpeach.Text, txtExtremitiesUpper.Text, txtExtremitiesLower.Text, txtDateOfColorVisionTest.Text, cbo_satisfactory_Unaided.Text, "", txtDateOfExam.Text, txtExpirydate.Text,txtMasterPosition.Text,txtMatePosition.Text,txtEngineerPosition.Text,txtRatingPosition.Text,txtLicenceNumber.Text,txtPhysicianDateOfExam.Text);
        }

        public void Availability(Control overlay, bool bl)
        {

            if (bl == true)
            {
                overlay.Visible = false;
                overlay.SendToBack();
                txtLicenceNumber.Enabled = true;
            }
            else
            {
                txtPapin.Focus();
                overlay.Visible = true;
                overlay.BringToFront();
                txtLicenceNumber.Enabled = false;
            }

        }





        public void Edit()
        {


            if (txtPapin.Text != "")
            {

                if (fmain.toolStripPhyExamPrintPreview.Enabled == false)
                {
                    MessageBox.Show("Unable to edit while preview in open", "Preview is open", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    fmain.toolStripPhyExamEdit.Enabled = false;
                    fmain.toolStripPhyExamDelete.Enabled = false;
                    fmain.toolStripPhyExamSave.Enabled = true;
                    fmain.toolStripPhyExamCancel.Enabled = true;
                    fmain.toolStripPhyExamPrint.Enabled = false;
                    fmain.toolStripPhyExamPrintPreview.Enabled = false;
                    fmain.toolStripPhyExamSearch.Enabled = false;
                    Availability(overlayShadow1, true);

                }
                
               

            }

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            fmain.toolStripPhyExamEdit.Enabled = true;
            fmain.toolStripPhyExamDelete.Enabled = false;
            fmain.toolStripPhyExamSave.Enabled = false;
            fmain.toolStripPhyExamCancel.Enabled = false;
            fmain.toolStripPhyExamPrint.Enabled = false;
            fmain.toolStripPhyExamPrintPreview.Enabled = false;
            fmain.toolStripPhyExamSearch.Enabled = true;
            searchPatient();
            Availability(overlayShadow1, false);
        }

        static string GetDefaultPrinterName()
        {
            string defaultPrinterName = null;
            PrinterSettings settings = new PrinterSettings();

            if (PrinterSettings.InstalledPrinters.Count > 0)
            {
                defaultPrinterName = settings.PrinterName;
            }

            return defaultPrinterName;
        }


        private void getReportData(bool isPreview)
        {


            PhysicalExaminationMedicalRecordModel physicalExaminationMedicalRecordModel = prePareTheReportData();           

          

            if (isPreview)
            {

                PhysicalExaminationReport report = new PhysicalExaminationReport();
                report.SetParameterValue("Latname", physicalExaminationMedicalRecordModel.LastName);
                report.SetParameterValue("FirstName", physicalExaminationMedicalRecordModel.FirstName);
                report.SetParameterValue("MiddileName", physicalExaminationMedicalRecordModel.MiddleName);
                report.SetParameterValue("Month", physicalExaminationMedicalRecordModel.Month);
                report.SetParameterValue("Day", physicalExaminationMedicalRecordModel.Day);
                report.SetParameterValue("Year", physicalExaminationMedicalRecordModel.Year);
                report.SetParameterValue("City", physicalExaminationMedicalRecordModel.City);
                report.SetParameterValue("Country", physicalExaminationMedicalRecordModel.Country);
                report.SetParameterValue("Gender", physicalExaminationMedicalRecordModel.Gender);
                report.SetParameterValue("forDuty", physicalExaminationMedicalRecordModel.forDuty);
                report.SetParameterValue("PositionMaster", physicalExaminationMedicalRecordModel.PositionMaster);
                report.SetParameterValue("PositionMate", physicalExaminationMedicalRecordModel.PositionMate);
                report.SetParameterValue("PositionEngineer", physicalExaminationMedicalRecordModel.PositionEngineer);
                report.SetParameterValue("PositionRating", physicalExaminationMedicalRecordModel.PositionRating);
                report.SetParameterValue("Height", physicalExaminationMedicalRecordModel.Height);
                report.SetParameterValue("Weight", physicalExaminationMedicalRecordModel.Weight);
                report.SetParameterValue("Bp", physicalExaminationMedicalRecordModel.Bp);
                report.SetParameterValue("Pulse", physicalExaminationMedicalRecordModel.Pulse);
                report.SetParameterValue("Respiration", physicalExaminationMedicalRecordModel.Respiration);
                report.SetParameterValue("GeneralAppearance", physicalExaminationMedicalRecordModel.GeneralAppearance);
                report.SetParameterValue("VisionWithOutGlassRight", physicalExaminationMedicalRecordModel.VisionWithOutGlassRight);
                report.SetParameterValue("VisionWithGlassRight", physicalExaminationMedicalRecordModel.VisionWithGlassRight);
                report.SetParameterValue("VisionWithOutGlassLeft", physicalExaminationMedicalRecordModel.VisionWithOutGlassLeft);
                report.SetParameterValue("VisionWithGlassLeft", physicalExaminationMedicalRecordModel.VisionWithGlassLeft);
                report.SetParameterValue("dateOfVisionTest", physicalExaminationMedicalRecordModel.DateOfVisionTest);
                report.SetParameterValue("ColorVisionMeetsStandard", physicalExaminationMedicalRecordModel.ColorVisionMeetsStandard);
                report.SetParameterValue("ColorTestType", physicalExaminationMedicalRecordModel.ColorTestType);
                report.SetParameterValue("HearingRight", physicalExaminationMedicalRecordModel.HearingRight);
                report.SetParameterValue("HearingLeft", physicalExaminationMedicalRecordModel.HearingLeft);
                report.SetParameterValue("Heart", physicalExaminationMedicalRecordModel.Heart);
                report.SetParameterValue("Lungs", physicalExaminationMedicalRecordModel.Lungs);
                report.SetParameterValue("ExtremitiesUpper", physicalExaminationMedicalRecordModel.ExtremitiesUpper);
                report.SetParameterValue("ExtremitiesLower", physicalExaminationMedicalRecordModel.ExtremitiesLower);
                report.SetParameterValue("DateOfExam", physicalExaminationMedicalRecordModel.DateOfExam);
                report.SetParameterValue("ExpiryDate", physicalExaminationMedicalRecordModel.ExpiryDate);
                report.SetParameterValue("NameOfApplicant", physicalExaminationMedicalRecordModel.NameOfApplicant);
                report.SetParameterValue("mailingAddress", physicalExaminationMedicalRecordModel.MailingAddress);
                report.SetParameterValue("Speach", physicalExaminationMedicalRecordModel.Speech);
                report.SetParameterValue("nameOfPhysician", physicalExaminationMedicalRecordModel.nameOfPhysician);
                report.SetParameterValue("addressOfPhysician", physicalExaminationMedicalRecordModel.addressOfPhysician);
                report.SetParameterValue("nameOfPhysicianCertificating", physicalExaminationMedicalRecordModel.nameOfPhysicianCertificating);
                report.SetParameterValue("dateOfPhysicianCertificate", physicalExaminationMedicalRecordModel.dateOfPhysicianCertificate);
                report.SetParameterValue("serialnumber", physicalExaminationMedicalRecordModel.serialNumber);
                report.SetParameterValue("ExaminationDate", physicalExaminationMedicalRecordModel.ExaminationDate);

                Viewer1.Visible = true;
                Viewer1.BringToFront();
                Viewer1.ReportSource = report;


                cmdClosePreview.Visible = true;
                cmdClosePreview.BringToFront();
                this.AutoScroll = false;



                Viewer1.Dock = DockStyle.Fill;
                fmain.toolStripPhyExamPrintPreview.Enabled = false;

            }
            else
            {
              
//
                string PhysicalExaminationReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location).Replace("\\bin\\Debug", "\\PhysicalExaminationReport\\PhysicalExaminationReport.rpt");

                ReportDocument reportDocument = new ReportDocument();
                reportDocument.Load(PhysicalExaminationReportPath);
                reportDocument.SetParameterValue("Latname", physicalExaminationMedicalRecordModel.LastName);
                reportDocument.SetParameterValue("FirstName", physicalExaminationMedicalRecordModel.FirstName);
                reportDocument.SetParameterValue("MiddileName", physicalExaminationMedicalRecordModel.MiddleName);
                reportDocument.SetParameterValue("Month", physicalExaminationMedicalRecordModel.Month);
                reportDocument.SetParameterValue("Day", physicalExaminationMedicalRecordModel.Day);
                reportDocument.SetParameterValue("Year", physicalExaminationMedicalRecordModel.Year);
                reportDocument.SetParameterValue("City", physicalExaminationMedicalRecordModel.City);
                reportDocument.SetParameterValue("Country", physicalExaminationMedicalRecordModel.Country);
                reportDocument.SetParameterValue("Gender", physicalExaminationMedicalRecordModel.Gender);
                reportDocument.SetParameterValue("forDuty", physicalExaminationMedicalRecordModel.forDuty);
                reportDocument.SetParameterValue("PositionMaster", physicalExaminationMedicalRecordModel.PositionMaster);
                reportDocument.SetParameterValue("PositionMate", physicalExaminationMedicalRecordModel.PositionMate);
                reportDocument.SetParameterValue("PositionEngineer", physicalExaminationMedicalRecordModel.PositionEngineer);
                reportDocument.SetParameterValue("PositionRating", physicalExaminationMedicalRecordModel.PositionRating);
                reportDocument.SetParameterValue("Height", physicalExaminationMedicalRecordModel.Height);
                reportDocument.SetParameterValue("Weight", physicalExaminationMedicalRecordModel.Weight);
                reportDocument.SetParameterValue("Bp", physicalExaminationMedicalRecordModel.Bp);
                reportDocument.SetParameterValue("Pulse", physicalExaminationMedicalRecordModel.Pulse);
                reportDocument.SetParameterValue("Respiration", physicalExaminationMedicalRecordModel.Respiration);
                reportDocument.SetParameterValue("GeneralAppearance", physicalExaminationMedicalRecordModel.GeneralAppearance);
                reportDocument.SetParameterValue("VisionWithOutGlassRight", physicalExaminationMedicalRecordModel.VisionWithOutGlassRight);
                reportDocument.SetParameterValue("VisionWithGlassRight", physicalExaminationMedicalRecordModel.VisionWithGlassRight);
                reportDocument.SetParameterValue("VisionWithOutGlassLeft", physicalExaminationMedicalRecordModel.VisionWithOutGlassLeft);
                reportDocument.SetParameterValue("VisionWithGlassLeft", physicalExaminationMedicalRecordModel.VisionWithGlassLeft);
                reportDocument.SetParameterValue("dateOfVisionTest", physicalExaminationMedicalRecordModel.DateOfVisionTest);
                reportDocument.SetParameterValue("ColorVisionMeetsStandard", physicalExaminationMedicalRecordModel.ColorVisionMeetsStandard);
                reportDocument.SetParameterValue("ColorTestType", physicalExaminationMedicalRecordModel.ColorTestType);
                reportDocument.SetParameterValue("HearingRight", physicalExaminationMedicalRecordModel.HearingRight);
                reportDocument.SetParameterValue("HearingLeft", physicalExaminationMedicalRecordModel.HearingLeft);
                reportDocument.SetParameterValue("Heart", physicalExaminationMedicalRecordModel.Heart);
                reportDocument.SetParameterValue("Lungs", physicalExaminationMedicalRecordModel.Lungs);
                reportDocument.SetParameterValue("ExtremitiesUpper", physicalExaminationMedicalRecordModel.ExtremitiesUpper);
                reportDocument.SetParameterValue("ExtremitiesLower", physicalExaminationMedicalRecordModel.ExtremitiesLower);
                reportDocument.SetParameterValue("DateOfExam", physicalExaminationMedicalRecordModel.DateOfExam);
                reportDocument.SetParameterValue("ExpiryDate", physicalExaminationMedicalRecordModel.ExpiryDate);
                reportDocument.SetParameterValue("NameOfApplicant", physicalExaminationMedicalRecordModel.NameOfApplicant);
                reportDocument.SetParameterValue("mailingAddress", physicalExaminationMedicalRecordModel.MailingAddress);
                reportDocument.SetParameterValue("Speach", physicalExaminationMedicalRecordModel.Speech);
                reportDocument.SetParameterValue("nameOfPhysician", physicalExaminationMedicalRecordModel.nameOfPhysician);
                reportDocument.SetParameterValue("addressOfPhysician", physicalExaminationMedicalRecordModel.addressOfPhysician);
                reportDocument.SetParameterValue("nameOfPhysicianCertificating", physicalExaminationMedicalRecordModel.nameOfPhysicianCertificating);
                reportDocument.SetParameterValue("dateOfPhysicianCertificate", physicalExaminationMedicalRecordModel.dateOfPhysicianCertificate);
                reportDocument.SetParameterValue("serialnumber", physicalExaminationMedicalRecordModel.serialNumber);
                reportDocument.SetParameterValue("ExaminationDate", physicalExaminationMedicalRecordModel.ExaminationDate);
                      
                reportDocument.PrintOptions.PaperOrientation = PaperOrientation.Portrait;
                reportDocument.PrintOptions.PaperSize = CrystalDecisions.Shared.PaperSize.PaperLetter;
                reportDocument.PrintOptions.PrinterName = GetDefaultPrinterName();
                reportDocument.PrintToPrinter(1, false, 0, 0);
                //
            }
            
           
           
        }




        public void Print()
        {


          

            getReportData(false);

        }


        public void printPreview()
        {
            
            getReportData(true);





        }

        private PhysicalExaminationMedicalRecordModel prePareTheReportData()
        {

            string g = "M";
            if (rbFemale.Checked)
            {
                g = "F";
            }



            string ExaminationForDuty = "";


            foreach (Control control in flowLayoutPanel1.Controls)
            {
                if ((control is CheckBox) && ((CheckBox)control).Checked)
                {
                    if (control.Name.Equals("cbMaster"))
                    {
                        ExaminationForDuty += "Master";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("Master", "");
                    }

                    if (control.Name.Equals("cbMate"))
                    {
                        ExaminationForDuty += "Mate";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("Mate", "");
                    }

                    if (control.Name.Equals("cbEngineer"))
                    {
                        ExaminationForDuty += "Engineer";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("Engineer", "");
                    }


                    if (control.Name.Equals("cbRadioOff"))
                    {
                        ExaminationForDuty += "RadioOff";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("RadioOff", "");
                    }

                }

            }



            foreach (Control control in flowLayoutPanel2.Controls)
            {
                if ((control is CheckBox) && ((CheckBox)control).Checked)
                {
                    if (control.Name.Equals("cbRating"))
                    {
                        ExaminationForDuty += "Rating";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("Rating", "");
                    }

                    if (control.Name.Equals("cbMouDeck"))
                    {
                        ExaminationForDuty += "MouDeck";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("MouDeck", "");
                    }

                    if (control.Name.Equals("cbMouMakina"))
                    {
                        ExaminationForDuty += "MouMakina";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("MouMakina", "");
                    }


                    if (control.Name.Equals("cbSuperNumerary"))
                    {
                        ExaminationForDuty += "SuperNumerary";
                    }
                    else
                    {
                        ExaminationForDuty.Replace("SuperNumerary", "");
                    }

                }

            }





            //string ColorVisionMeetsStandard = "";
            //string ColorTestType = "";

            string ColorVissionMeetsStandard = "N";
            if (rbColorVissionMeetsYes.Checked)
            {
                ColorVissionMeetsStandard = "Y";
            }

            string ColorTestType = "";
          
            foreach (Control control in flowLayoutPanel3.Controls)
            {
                if ((control is CheckBox) && ((CheckBox)control).Checked)
                {
                    if (control.Name.Equals("CbColorTestTypeYellow"))
                    {
                        ColorTestType += "Yellow";
                    }
                    else
                    {
                        ColorTestType.Replace("Yellow", "");
                    }

                    if (control.Name.Equals("CbColorTestTypeRed"))
                    {
                        ColorTestType += "Red";
                    }
                    else
                    {
                        ColorTestType.Replace("Red", "");
                    }


                    if (control.Name.Equals("CbColorTestTypeGreen"))
                    {
                        ColorTestType += "Green";
                    }
                    else
                    {
                        ColorTestType.Replace("Green", "");
                    }


                    if (control.Name.Equals("CbColorTestTypeBlue"))
                    {
                        ColorTestType += "Blue";
                    }
                    else
                    {
                        ColorTestType.Replace("Blue", "");
                    }

                }


                //Console.WriteLine(ColorTestType);
            }





            DateTime bdate = Convert.ToDateTime(txtBirthDate.Text);


            PhysicalExaminationMedicalRecordModel physicalExaminationMedicalRecordModel = new PhysicalExaminationMedicalRecordModel();

            physicalExaminationMedicalRecordModel.LastName = txtlastname.Text;
            physicalExaminationMedicalRecordModel.FirstName = txtFirstname.Text;
            physicalExaminationMedicalRecordModel.MiddleName = txtMiddleName.Text;
            physicalExaminationMedicalRecordModel.Month = bdate.ToString("MMM");
            physicalExaminationMedicalRecordModel.Day = bdate.Day.ToString();
            physicalExaminationMedicalRecordModel.Year = bdate.Year.ToString();
            physicalExaminationMedicalRecordModel.City = txtPlaceOfBirth.Text;  
            physicalExaminationMedicalRecordModel.Country = "";
            physicalExaminationMedicalRecordModel.Gender = g;
            physicalExaminationMedicalRecordModel.PositionMaster = txtMasterPosition.Text;
            physicalExaminationMedicalRecordModel.PositionMate = txtMatePosition.Text;
            physicalExaminationMedicalRecordModel.PositionEngineer = txtEngineerPosition.Text;
            physicalExaminationMedicalRecordModel.PositionRating = txtRatingPosition.Text;
            physicalExaminationMedicalRecordModel.forDuty = ExaminationForDuty;
            physicalExaminationMedicalRecordModel.Height = txtHeight.Text;
            physicalExaminationMedicalRecordModel.Weight = txtWeight.Text;
            physicalExaminationMedicalRecordModel.Bp = txtBloodPressure.Text;
            physicalExaminationMedicalRecordModel.Pulse = txtPulse.Text;
            physicalExaminationMedicalRecordModel.Respiration = txtRespiration.Text;
            physicalExaminationMedicalRecordModel.GeneralAppearance = txtGeneralAppearance.Text;
            physicalExaminationMedicalRecordModel.VisionWithOutGlassRight = txtRightEyeWithOutGlasses.Text;
            physicalExaminationMedicalRecordModel.VisionWithGlassRight = txtRightEyeWithGlasses.Text;
            physicalExaminationMedicalRecordModel.VisionWithOutGlassLeft = txtLeftEyeWithOutGlasses.Text;
            physicalExaminationMedicalRecordModel.VisionWithGlassLeft = txtLeftEyeWithGlasses.Text;
            physicalExaminationMedicalRecordModel.DateOfVisionTest = txtDateOfColorVisionTest.Text;
            physicalExaminationMedicalRecordModel.ColorVisionMeetsStandard = ColorVissionMeetsStandard;
            physicalExaminationMedicalRecordModel.ColorTestType = ColorTestType;
            physicalExaminationMedicalRecordModel.HearingRight = txtHearingRight.Text;
            physicalExaminationMedicalRecordModel.HearingLeft = txthearingLeft.Text;
            physicalExaminationMedicalRecordModel.Heart = txtHeart.Text;
            physicalExaminationMedicalRecordModel.Lungs = txtLungs.Text;
            physicalExaminationMedicalRecordModel.ExtremitiesUpper = txtExtremitiesUpper.Text;
            physicalExaminationMedicalRecordModel.ExtremitiesLower = txtExtremitiesLower.Text;
            physicalExaminationMedicalRecordModel.DateOfExam = txtDateOfExam.Text;
            physicalExaminationMedicalRecordModel.ExpiryDate = txtExpirydate.Text;
            physicalExaminationMedicalRecordModel.NameOfApplicant = txtNameOfApplicant.Text;
            physicalExaminationMedicalRecordModel.MailingAddress = txtHomeAddress.Text;
            physicalExaminationMedicalRecordModel.Speech = txtSpeach.Text;
            physicalExaminationMedicalRecordModel.nameOfPhysician = txtNameOfPhysician.Text;
            physicalExaminationMedicalRecordModel.addressOfPhysician = txtAddress.Text;
            physicalExaminationMedicalRecordModel.nameOfPhysicianCertificating = txtPhysicianCertificatingAuthority.Text;
            physicalExaminationMedicalRecordModel.dateOfPhysicianCertificate = txtDateOfIssuePhysicianCertificate.Text;
            physicalExaminationMedicalRecordModel.serialNumber = txtLicenceNumber.Text;
            physicalExaminationMedicalRecordModel.ExaminationDate = txtPhysicianDateOfExam.Text;

            return physicalExaminationMedicalRecordModel;
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        private void FrmPhysicalExamination_Enter(object sender, EventArgs e)
        {
            Panama_SeaMLC_model.Clear();
            if (!backgroundWorker1.IsBusy)
            { backgroundWorker1.RunWorkerAsync(); }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {

                if ((Application.OpenForms["FrmSearchPhyExam"] as FrmSearchPhyExam) != null)
                { (Application.OpenForms["FrmSearchPhyExam"] as FrmSearchPhyExam).FillDataGridView(); }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
        }
        public void OpenSearchList()
        {

        }


        private void FrmPhysicalExamination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add && e.Modifiers == Keys.Control)
            {
                OpenSearchList();
            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                Print();
            }
            else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {

                fmain.SearchPhysicalExam();

            }
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {

                Save();

            }
            else if (e.KeyCode == Keys.F4)
            {

                Edit();

            }
            else if (e.KeyCode == Keys.F5)
            {



            }
            //

        }

        private void txtDateOfColorVisionTest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                txtDateOfColorVisionTest.Format = DateTimePickerFormat.Custom;
                txtDateOfColorVisionTest.CustomFormat = "00/00/0000";
            }
        }

        private void txtDateOfColorVisionTest_MouseDown(object sender, MouseEventArgs e)
        {
            txtDateOfColorVisionTest.Format = DateTimePickerFormat.Custom;
            txtDateOfColorVisionTest.CustomFormat = "MM/dd/yyyy";
        }

        private void cmdClosePreview_Click(object sender, EventArgs e)
        {
            ClosePreview();
        }

        public void ClosePreview()
        {
            cmdClosePreview.Visible = false;
            cmdClosePreview.SendToBack();
            Viewer1.Visible = false;
            this.AutoScroll = true;
            Viewer1.SendToBack();
            Viewer1.Dock = DockStyle.Fill;
            fmain.toolStripPhyExamPrintPreview.Enabled = true;
        }
    }
}
