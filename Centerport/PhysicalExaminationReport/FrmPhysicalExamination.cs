using MedicalManagementSoftware.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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


        private string nameOfPhysician = "MA. LACIA B. LAGUIMUN, M.D";
        private string addressOfPhysician = "CENTERPORT MEDICAL SERVICES, INC. 4/F VICTORIA BLDG., 429 U.N. AVE. ERMINATA, MANILA";
        private string nameOfPhysicianCertificating = "PROFESSIONAL REGULATION COMMINION";
        private string dateOfPhysicianCertificate = "JAN 13, 1993";
        private string dateOfPhysicianExamination = "";



        public FrmPhysicalExamination(Main m)
        {
            InitializeComponent();

            fmain = m;
        }

        private void FrmPhysicalExamination_Load(object sender, EventArgs e)
        {

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

                txtHeight.Text = l.Height + " CM";
                txtWeight.Text = l.Weight + " KG";
                string bp_diastolic =  l.BP+"/"+l.BP_DIASTOLIC;
                txtBloodPressure.Text = l.BloodPressure ==null?bp_diastolic:l.BloodPressure;
                txtPulse.Text = l.Pulse+"/MIN.";
                txtRespiration.Text = l.Respiration + "/MIN.";

                txtRightEyeWithOutGlasses.Text = l.VissionRightEye == null ? "20/20" : l.VissionRightEye;
                txtLeftEyeWithOutGlasses.Text = l.VissionLeftEye == null ? "20/20" : l.VissionLeftEye;
                txtRightEyeWithGlasses.Text = l.VissionWithGlassRight == null ? "20/20" : l.VissionWithGlassRight;
                txtLeftEyeWithGlasses.Text = l.VissionWithGlassLeft == null ? "20/20" : l.VissionWithGlassLeft;

                string d = l.COLOR_VISION_DATE_TAKEN.ToString();
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
                    else if (l.ColorTestType.Contains("Red"))
                    {
                        CbColorTestTypeRed.Checked = true;
                    }
                    else if (l.ColorTestType.Contains("Green"))
                    {
                        CbColorTestTypeGreen.Checked = true;
                    }
                    else if (l.ColorTestType.Contains("Blue"))
                    {
                        CbColorTestTypeBlue.Checked = true;
                    }
                }

               


                txtHeart.Text = l.Heart ==null?"NORMAL":l.Heart;
                txtLungs.Text = l.Lungs == null ? "NORMAL CHEST  FINDINGS" : l.Lungs;

                txtExtremitiesUpper.Text = l.ExtremitiesUpper == null ? "NORMAL" : l.ExtremitiesUpper;
                txtExtremitiesLower.Text = l.ExtremitiesLower == null ? "NORMAL" : l.ExtremitiesLower;

                txtGeneralAppearance.Text = l.GeneralAppearance == null ? "NORMAL" : l.GeneralAppearance;


                txtHearingRight.Text = l.HearingRight == null ? "NORMAL HEARING ACUTY" : l.HearingRight;
                txthearingLeft.Text = l.HearingLeft == null ? "NORMAL HEARING ACUTY" : l.HearingLeft;

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

        }


        public void New()
        {
            fmain.toolStripPhyExamEdit.Enabled = false;
            fmain.toolStripPhyExamDelete.Enabled = false;
            fmain.toolStripPhyExamSave.Enabled = true;
            fmain.toolStripPhyExamCancel.Enabled = true;
            fmain.toolStripPhyExamPrint.Enabled = true;
            fmain.toolStripPhyExamSearch.Enabled = false;


        }

        public void Save()
        {
            fmain.toolStripPhyExamEdit.Enabled = true;
            fmain.toolStripPhyExamDelete.Enabled = false;
            fmain.toolStripPhyExamSave.Enabled = false;
            fmain.toolStripPhyExamCancel.Enabled = false;
            fmain.toolStripPhyExamPrint.Enabled = true;
            fmain.toolStripPhyExamSearch.Enabled = true;
            Availability(overlayShadow1, false);
            saveLiberia();
        }


        private void saveLiberia()
        {
            string ExaminationForDuty = "";

            string ColorVissionMeetsStandard = "N";

            if (rbColorVissionMeetsYes.Checked)
            {
                ColorVissionMeetsStandard = "Y";
            }

            string ColorTestType = "";
            if (CbColorTestTypeYellow.Checked)
            {
                ColorTestType += "Yellow";
            }
            else if (CbColorTestTypeRed.Checked)
            {
                ColorTestType += "Red";
            }
            else if (CbColorTestTypeGreen.Checked)
            {
                ColorTestType += "Green";
            }
            else if (CbColorTestTypeBlue.Checked)
            {
                ColorTestType += "Blue";
            }




            LiberiaModel liberiaModel = new LiberiaModel();
            liberiaModel.save(txtPapin.Text, ExaminationForDuty, txtHeight.Text, txtWeight.Text, txtBloodPressure.Text, txtPulse.Text, txtRespiration.Text, txtGeneralAppearance.Text, txtRightEyeWithOutGlasses.Text, txtLeftEyeWithOutGlasses.Text, txtRightEyeWithGlasses.Text, txtLeftEyeWithGlasses.Text, ColorVissionMeetsStandard, ColorTestType, txtHearingRight.Text, txthearingLeft.Text, txtHeart.Text, txtLungs.Text, txtSpeach.Text, txtExtremitiesUpper.Text, txtExtremitiesLower.Text, txtDateOfColorVisionTest.Text, cbo_satisfactory_Unaided.Text, "", txtDateOfExam.Text, txtExpirydate.Text);
        }

        public void Availability(Control overlay, bool bl)
        {

            if (bl == true)
            {
                overlay.Visible = false;
                overlay.SendToBack();
            }
            else
            {
                txtPapin.Focus();
                overlay.Visible = true;
                overlay.BringToFront();
            }

        }





        public void Edit()
        {
            if (txtPapin.Text != "")
            {
                fmain.toolStripPhyExamEdit.Enabled = false;
                fmain.toolStripPhyExamDelete.Enabled = false;
                fmain.toolStripPhyExamSave.Enabled = true;
                fmain.toolStripPhyExamCancel.Enabled = true;
                fmain.toolStripPhyExamPrint.Enabled = false;
                fmain.toolStripPhyExamSearch.Enabled = false;

                Availability(overlayShadow1, true);

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
            fmain.toolStripPhyExamSearch.Enabled = true;

            Availability(overlayShadow1, false);
        }

        public void Print()
        {

            FrmPhysicalExaminationReport frmPhysicalExaminationReport = new FrmPhysicalExaminationReport();
            frmPhysicalExaminationReport.physicalExaminationMedicalRecordModel = prePareTheReportData();
            frmPhysicalExaminationReport.ShowDialog();


        }

        private PhysicalExaminationMedicalRecordModel prePareTheReportData()
        {

            string g = "M";
            if (rbFemale.Checked)
            {
                g = "F";
            }
            string Position = "";
            //string ColorVisionMeetsStandard = "";
            //string ColorTestType = "";

            string ColorVissionMeetsStandard = "N";
            if (rbColorVissionMeetsYes.Checked)
            {
                ColorVissionMeetsStandard = "Y";
            }

            string ColorTestType = "";
            if (CbColorTestTypeYellow.Checked)
            {
                ColorTestType += "Yellow";
            }
            else if (CbColorTestTypeRed.Checked)
            {
                ColorTestType += "Red";
            }
            else if (CbColorTestTypeGreen.Checked)
            {
                ColorTestType += "Green";
            }
            else if (CbColorTestTypeBlue.Checked)
            {
                ColorTestType += "Blue";
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
            physicalExaminationMedicalRecordModel.Position = Position;
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
    }
}
