using MedicalManagementSoftware.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            var i = db.PhysicalExamplePatient(txtPapin.Text).FirstOrDefault();



            if (i != null)
            {

                txtlastname.Text = i.lastname;
                txtFirstname.Text = i.firstname;
                txtMiddleName.Text = i.middlename;
                txtBirthDate.Text = i.birthdate;
                txtPlaceOfBirth.Text = i.place_of_birth;
                txtHomeAddress.Text = i.HomeAddress;
                txtHeight.Text = i.Height;
                txtWeight.Text = i.Weight;
                txtBloodPressure.Text = i.BloodPressure;
                txtPulse.Text = i.PULSE;
                txtRespiration.Text = i.Respiratory;
                txtDateOfColorVisionTest.Text = i.COLOR_VISION_DATE_TAKEN;
                string fullname = txtlastname.Text + ", " + txtFirstname.Text + " " + txtMiddleName.Text;
                txtNameOfApplicant.Text = fullname;
                txtDateOfExam.Text = i.result_date;
                txtExpirydate.Text = i.valid_until;

                if (i.gender.ToLower().Equals("male") || i.gender.ToLower().Equals("M"))
                {
                    rbMale.Checked = true;
                }
                else
                {
                    rbFemale.Checked = true;
                }

            


                txtHearingRight.Text = i.HEARING_RIGHT == "A" ? "NORMAL": "NOT NORMAL";
                txthearingLeft.Text = i.HEARING_LEFT == "A" ? "NORMAL" : "NOT NORMAL";

                textBox20.Text = i.SATISFACTORY_SIGHT_UNAID;

              
               txtSpeach.Text = i.CLARITY_OF_SPEECH == "A" ? "NORMAL" : "NOT NORMAL";
               
                txtNameOfPhysician.Text = nameOfPhysician;
                txtAddress.Text = addressOfPhysician;
                txtPhysicianCertificatingAuthority.Text = nameOfPhysicianCertificating;
                txtDateOfIssuePhysicianCertificate.Text = dateOfPhysicianCertificate;
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
            string ColorVisionMeetsStandard = "";
            string ColorTestType = "";

            DateTime bdate = Convert.ToDateTime(txtBirthDate.Text);


            PhysicalExaminationMedicalRecordModel physicalExaminationMedicalRecordModel = new PhysicalExaminationMedicalRecordModel();

            physicalExaminationMedicalRecordModel.LastName = txtlastname.Text;
            physicalExaminationMedicalRecordModel.FirstName = txtFirstname.Text;
            physicalExaminationMedicalRecordModel.MiddleName = txtMiddleName.Text;
            physicalExaminationMedicalRecordModel.Month = bdate.ToString("MMM");
            physicalExaminationMedicalRecordModel.Day = bdate.Day.ToString();
            physicalExaminationMedicalRecordModel.Year =bdate.Year.ToString();
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
            physicalExaminationMedicalRecordModel.ColorVisionMeetsStandard = ColorVisionMeetsStandard;
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


        }
    }
}
