using Ini;
using MedicalManagementSoftware.Model;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementSoftware
{
    public partial class frm_MedicalPersonnel : Form
    {
        public TextBox txt_medic; public TextBox txt_license;
        public frm_MedicalPersonnel()
        {
            InitializeComponent();
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_MedicalPersonnel_Load(object sender, EventArgs e)
        {
            loadMedics();
        }


        void loadMedics()
        {
            IniFile ini = new IniFile(ClassSql.MMS_Path);

            List<Meds> meds = new List<Meds>();


            string a = ini.IniReadValue("MEDICAL", "PEME_Physician");
            string b = ini.IniReadValue("MEDICAL", "PEME MedicalDirector");
            string c = ini.IniReadValue("MEDICAL", "MedTech");
            string d = ini.IniReadValue("MEDICAL", "Pathologist");
            string e = ini.IniReadValue("MEDICAL", "Xray_Radiologist");
            string f = ini.IniReadValue("MEDICAL", "Medical_Director");
            string g = ini.IniReadValue("MEDICAL", "HIV_Exam_physician");
            string h = ini.IniReadValue("MEDICAL", "Psychometrician");
            string i = ini.IniReadValue("MEDICAL", "Psychologist");
            string j = ini.IniReadValue("MEDICAL", "XRAY_TECH");
            string k = ini.IniReadValue("MEDICAL", "medtech1_Name");
            string l = ini.IniReadValue("MEDICAL", "medtech2_Name");

            string aa = ini.IniReadValue("MEDICAL", "PEME_Physician_license");
            string bb = ini.IniReadValue("MEDICAL", "PEME MedicalDirector_license");
            string cc = ini.IniReadValue("MEDICAL", "MedTech_license");
            string dd = ini.IniReadValue("MEDICAL", "Pathologist_license");
            string ee = ini.IniReadValue("MEDICAL", "Xray Radiologist_license");
            string ff = ini.IniReadValue("MEDICAL", "Medical Director_license");
            string gg = ini.IniReadValue("MEDICAL", "HIV_Exam_physician_license");
            string hh = ini.IniReadValue("MEDICAL", "Psychometrician_license");
            string ii = ini.IniReadValue("MEDICAL", "Psychologist_license");
            string jj = ini.IniReadValue("MEDICAL", "XRAYTECH_LICENSE");
            string kk = ini.IniReadValue("MEDICAL", "medtech1_Lic");
            string ll = ini.IniReadValue("MEDICAL", "medtech2_Lic");

            meds.Add(new Meds(a, aa));
            meds.Add(new Meds(b, bb));
            meds.Add(new Meds(c, cc));
            meds.Add(new Meds(d, dd));
            meds.Add(new Meds(e, ee));
            meds.Add(new Meds(f, ff));
            meds.Add(new Meds(g, gg));
            meds.Add(new Meds(h, hh));
            meds.Add(new Meds(i, ii));
            meds.Add(new Meds(j, jj));
            meds.Add(new Meds(k, kk));
            meds.Add(new Meds(l, ll));

            dg.DataSource = meds;

          
         
        
        }


        void SelectItem()
        {
            try
            {
                txt_medic.Text = dg.SelectedRows[0].Cells[0].Value.ToString();
                txt_license.Text = dg.SelectedRows[0].Cells[1].Value.ToString();

                var form  = (Application.OpenForms["frm_Psych_Evaluation"] as frm_Psych_Evaluation);
                if (form  != null)
                {
                    IniFile ini = new IniFile(ClassSql.MMS_Path);
                    form.Lic_validity_Medtech.Text = ini.IniReadValue("MEDICAL", "Psychometrician_Validity");
                    form.PTR_medtech.Text = ini.IniReadValue("MEDICAL", "Psychometrician_ptr");
                    form.Lic_Validity_Patho.Text = ini.IniReadValue("MEDICAL", "Psychologist_Validity");
                    form.PTR_Patho.Text = ini.IniReadValue("MEDICAL", "Psychologist_Ptr");
                }
                    this.Close();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }

        }
        private void cmd_Select_Click(object sender, EventArgs e)
        {

            SelectItem();
            
        }


        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
               
            //    dg_medics.Rows[dg_medics.SelectedRows[0].Index].Selected = false;
            //    foreach (DataGridViewRow row in this.dg_medics.Rows)
            //    {
            //        if (row.Cells[0].Value.ToString().Contains(txt_search.Text))
            //        {
            //            dg_medics.Rows[row.Index].Selected = true;

            //            break;
            //        }
            //    }
            //}
            //catch
            //{

            //   // dg_medics.Rows[dg_medics.SelectedRows[0].Index].Selected = false;
            //    dg_medics.Rows[0].Cells[0].Selected = true;
            //}



            
           
           
            
            
            
        }

        private void dg_medics_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SelectItem();
            }
            catch
            { }
        }

        private void dg_medics_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void cmd_search_Click(object sender, EventArgs e)
        //{
        //   //string searchString = this.dtToday.Text;
        //    dg_medics.Rows[dg_medics.SelectedRows[0].Index].Selected = false;  
        //   foreach (DataGridViewRow row in this.dg_medics.Rows)
        //   {
        //       if (row.Cells[0].Value.ToString().Contains(txt_search.Text))
        //       {
        //           dg_medics.Rows[row.Index].Selected = true;

        //           break;
        //       }
        //   }
        //}
    }
}
