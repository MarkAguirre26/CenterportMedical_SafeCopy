using CrystalDecisions.Windows.Forms;
using MedicalManagementSoftware.Class;
using MedicalManagementSoftware.Model;
using MedicalManagementSoftware.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementSoftware
{
    public partial class Frm_Immunology : Form, MyInter
    {
        Main fmain;
        public static int EMPTY = 2;
        public bool newTumor;
        private int HBsAG = EMPTY;
        private int AntiHBS = EMPTY;
        private int Rpr = EMPTY;

        public Frm_Immunology(Main m)
        {
            InitializeComponent();
            fmain = m;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_Immunology_Load(object sender, EventArgs e)
        {
            Availability(false);
        }

        public void New()
        {
            throw new NotImplementedException();
        }

        public void Save()
        {

            //  Insert();
            DataClasses2DataContext db = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
            db.MedicalImmunologyTestSAVE(
                txt_LabNo.Text,
                this.Tag.ToString(),
                txtPSA.Text,
                  txtOtherResult.Text,
                  HBsAG.ToString(),
                   Rpr.ToString(),
                   AntiHBS.ToString(),
                txtAntiHBResult.Text,
                txt_MedTech.Text,
                txt_MedTech_lic.Text,
                txt_PathoLogist.Text,
                txt_PathoLogist_Lic.Text,
                dt_result_Date.Text,
                txtOtherName.Text,
                txtOtherRefValue.Text,
                txtCutOff.Text
          );




            Availability(false);
            fmain.ts_edit_tumor.Enabled = true;
            fmain.ts_delete_tumor.Enabled = true;
            fmain.ts_save_tumor.Enabled = false;
            fmain.ts_cancel_tumor.Enabled = false;
            fmain.ts_search_tumor.Enabled = true;
            fmain.ts_print_tumor.Enabled = true;



        }


        public void Availability(bool bl)
        {


            if (bl == true)
            { overlayShadow1.Visible = false; overlayShadow1.SendToBack(); }
            else
            { overlayShadow1.Visible = true; overlayShadow1.BringToFront(); }

        }

        public void Edit()
        {
            newTumor = false;
            Availability(true);

            fmain.ts_edit_tumor.Enabled = false;
            fmain.ts_delete_tumor.Enabled = false;
            fmain.ts_save_tumor.Enabled = true;
            fmain.ts_cancel_tumor.Enabled = true;
            fmain.ts_search_tumor.Enabled = false;
            fmain.ts_print_tumor.Enabled = false;
        }

        public void Delete()
        {
            //throw new NotImplementedException();
            DataClasses2DataContext db = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
            db.ExecuteCommand("DELETE FROM MedicalImmunologyTest WHERE (Papin={0})", this.Tag.ToString());
            ClearAll();

        }

        public void Cancel()
        {
            if (newTumor)
            {

                //txt_Papin.Clear();
                ClearAll();
                Availability(false);

                fmain.ts_edit_tumor.Enabled = false;
                fmain.ts_delete_tumor.Enabled = false;
                fmain.ts_save_tumor.Enabled = false;
                fmain.ts_cancel_tumor.Enabled = false;
                fmain.ts_search_tumor.Enabled = true;
                fmain.ts_print_tumor.Enabled = false;

            }
            else
            {
                Availability(false);
                //ClearAll();
                //Search_Patient();
                //Search_tumor();
                //search_Medical_ByProc();
                //fmain.ts_add_hiv.Enabled = true; fmain.ts_edit_hiv.Enabled = true; fmain.ts_delete_hiv.Enabled = false; fmain.ts_save_hiv.Enabled = false; fmain.ts_search_hiv.Enabled = true; fmain.ts_print_hiv.Enabled = true; fmain.ts_cancel_hiv.Enabled = false;
                fmain.ts_edit_tumor.Enabled = true;
                //fmain.ts_delete_tumor.Enabled = true;
                fmain.ts_save_tumor.Enabled = false;
                fmain.ts_cancel_tumor.Enabled = false;
                fmain.ts_search_tumor.Enabled = true;
                fmain.ts_print_tumor.Enabled = true;
            }
            //txt_Papin.Select();
        }

        public void ClearAll()
        {
            Tool.ClearFields(panel1);
            Tool.ClearFields(panel2);
            Tool.ClearFields(panel3);
            Tool.ClearFields(panel4);
            Tool.ClearFields(groupBox2);
            Tool.ClearFields(groupBox1);
            HBsAG = EMPTY;
            AntiHBS = EMPTY;
            Rpr = EMPTY;




        }


        public void Print()
        {
            using (frm_lab_33_Report f = new frm_lab_33_Report())
            {
                //f.Tag = LabID.Text;
                //
                f.Name_ = txt_name.Text;
                f.Age = txt_age.Text;
                f.Gender = txt_gender.Text;
                f.BirthDate = dt_bday.Text;
                f.Employer = txt_agency.Text;
                f.Position_ = txt_position.Text;
                f.LabNo = txt_LabNo.Text;
                f.otherName = txtOtherName.Text;
                f.otherRefValue = txtOtherRefValue.Text;
                f.CutOff = txtCutOff.Text;
                f.Other = txtOtherName.Text;
                f.Psa = txtPSA.Text;
                f.HBsAg = HBsAG.ToString();
                f.Other = txtOtherResult.Text;
                f.Rpr = Rpr.ToString();

                f.AntiHBS = AntiHBS.ToString();
                f.AntiHBSResult = txtAntiHBResult.Text;
                f.Medtech = txt_MedTech.Text;
                f.MedtechLicense = txt_MedTech_lic.Text;
                f.Pathologist = txt_PathoLogist.Text;
                f.PathologistLicense = txt_PathoLogist_Lic.Text;
                f.ResultDate = dt_result_Date.Text;
                f.ShowDialog();
            }



        }

        public void Search()
        {
            DataClasses2DataContext db = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
            var i = db.MedicalImmunologyTestSearch(this.Tag.ToString()).FirstOrDefault();

            fmain.ts_edit_tumor.Enabled = false;
            fmain.ts_delete_tumor.Enabled = false;
            fmain.ts_save_tumor.Enabled = true;
            fmain.ts_search_tumor.Enabled = false;
            fmain.ts_print_tumor.Enabled = false;
            fmain.ts_cancel_tumor.Enabled = true;

            Availability(true);
            newTumor = true;

            DateTime temp2;
            if (DateTime.TryParse(i.birthdate.ToString(), out temp2))
            {
                dt_bday.Format = DateTimePickerFormat.Custom;
                dt_bday.CustomFormat = "MM/dd/yyyy";
                dt_bday.Text = i.birthdate;
                //dt_valid_until.Value = Convert.ToDateTime(i.valid_until.ToString()).Date;
            }
            else
            {

                dt_bday.Format = DateTimePickerFormat.Custom;
                dt_bday.CustomFormat = "00/00/0000";

            }


            this.Tag = i.papin;
            txt_name.Text = i.lastname + ", " + i.firstname + " " + i.middlename;
            txt_agency.Text = i.employer;


            txt_age.Text = DateClass.getAge(i.birthdate.ToString());
            txt_gender.Text = i.gender;
            txt_position.Text = i.position;


            //DateTime temp3;
            //if (DateTime.TryParse(i.ResultDate.ToString(), out temp2))
            //{
            dt_result_Date.Format = DateTimePickerFormat.Custom;
            dt_result_Date.CustomFormat = "MM/dd/yyyy";
            dt_result_Date.Text = DateTime.Now.ToShortDateString();


            //}

            if (i.isFound.Equals("Found"))
            {
                newTumor = false;

                DateTime temp1;
                if (DateTime.TryParse(i.ResultDate.ToString(), out temp2))
                {
                    dt_result_Date.Format = DateTimePickerFormat.Custom;
                    dt_result_Date.CustomFormat = "MM/dd/yyyy";
                    dt_result_Date.Text = i.ResultDate.Value.ToShortDateString();
                    //dt_valid_until.Value = Convert.ToDateTime(i.valid_until.ToString()).Date;
                }
                else
                {

                    dt_result_Date.Format = DateTimePickerFormat.Custom;
                    dt_result_Date.CustomFormat = "00/00/0000";




                }

                txt_LabNo.Text = i.LaboratoryNo.ToString();


                txt_MedTech.Text = i.MedTech;
                txt_MedTech_lic.Text = i.MedTechLicense;
                txt_PathoLogist.Text = i.Pathologist;
                txt_PathoLogist_Lic.Text = i.PathologistLicense;

                txtPSA.Text = i.psa;
                txtOtherResult.Text = i.Other;

                Rpr = Convert.ToInt32(i.RPR);
                AntiHBS = Convert.ToInt32(i.AntiHBS);
                HBsAG = Convert.ToInt32(i.HBsAg);

                setRadioButtons();



                txtCutOff.Text = i.cutOff;

                txtOtherName.Text = i.otherName;
                txtOtherRefValue.Text = i.otherRefValue;
                txtAntiHBResult.Text = i.AntiHBSResult;

                Availability(false);
                fmain.ts_edit_tumor.Enabled = true;
                fmain.ts_delete_tumor.Enabled = true;
                fmain.ts_save_tumor.Enabled = false;
                fmain.ts_search_tumor.Enabled = true;
                fmain.ts_print_tumor.Enabled = true;
                fmain.ts_cancel_tumor.Enabled = false;
            }
        }

        void setRadioButtons()
        {
            if (Rpr.Equals(0))
            {
                this.radioButton2.Checked = true;
            }
            else if (Rpr.Equals(1))
            {
                this.radioButton1.Checked = true;
            }
            else
            {
                this.radioButton1.Checked = false;
                this.radioButton2.Checked = false;

            }



            if (HBsAG.Equals(0))
            {
                rbHBsAGNonReActive.Checked = true;

            }
            else if (HBsAG.Equals(1))
            {
                rbHBsAGReActive.Checked = true;

            }
            else
            {
                rbHBsAGReActive.Checked = false;
                rbHBsAGNonReActive.Checked = false;
            }



            if (AntiHBS.Equals(0))
            {
                rbAntiHBNonReActive.Checked = true;

            }
            else if (AntiHBS.Equals(1))
            {
                rbAntiHBReActive.Checked = true;
            }
            else
            {
                rbAntiHBReActive.Checked = false;
                rbAntiHBReActive.Checked = false;
            }
        }


        private void txt_tumorOther_TextChanged(object sender, EventArgs e)
        {


        }

        private void Frm_Immunology_FormClosing(object sender, FormClosingEventArgs e)
        {
            fmain.Tumor = true;
            fmain.ts_edit_tumor.Enabled = false; fmain.ts_delete_tumor.Enabled = false; fmain.ts_save_tumor.Enabled = false; fmain.ts_search_tumor.Enabled = true; fmain.ts_print_tumor.Enabled = false; fmain.ts_cancel_tumor.Enabled = false;
        }

        private void Frm_Immunology_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (fmain.ts_cancel_tumor.Enabled == true)
                { Cancel(); }
                else
                { this.Close(); }

            }


            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_save_tumor.Enabled == true)
                {
                    Save();

                }

            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                if (fmain.ts_print_tumor.Enabled == true)
                {
                    Print();
                }
            }
            else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {

                if (fmain.ts_search_tumor.Enabled == true)
                {
                    fmain.searchTumor();
                }
            }
            else if (e.KeyCode == Keys.F4)
            {
                if (fmain.ts_edit_tumor.Enabled == true)
                {
                    Edit();

                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (fmain.ts_delete_tumor.Enabled == true)
                {

                    Delete();
                }

            }
        }

        private void cmd_load1_Click(object sender, EventArgs e)
        {
            using (frm_MedicalPersonnel f = new frm_MedicalPersonnel())
            {
                f.txt_medic = txt_MedTech;
                f.txt_license = txt_MedTech_lic;
                f.ShowDialog();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (frm_MedicalPersonnel f = new frm_MedicalPersonnel())
            {
                f.txt_medic = txt_PathoLogist;
                f.txt_license = txt_PathoLogist_Lic;
                f.ShowDialog();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHBsAGNonReActive.Checked)
            {
                HBsAG = 0;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHBsAGReActive.Checked)
            {
                HBsAG = 1;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dt_result_Date_ValueChanged(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void rbAntiHBReActive_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAntiHBReActive.Checked)
            {
                AntiHBS = 1;
            }
        }

        private void rbAntiHBNonReActive_CheckedChanged(object sender, EventArgs e)
        {

            if (rbAntiHBNonReActive.Checked)
            {
                AntiHBS = 0; //nonreactive
            }
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                Rpr = 0;
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Rpr = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            HBsAG = EMPTY;

            setRadioButtons();
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rpr = EMPTY;
            

            setRadioButtons();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            AntiHBS = EMPTY;
            

            setRadioButtons();
        }
    }
}
