using MedicalManagementSoftware.Dataset;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using Ini;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalManagementSoftware.Model;
using System.Windows.Forms;

namespace MedicalManagementSoftware.Report
{
    public partial class frm_lab_33_Report : Form
    {
        public DataTable dt;


        public string Name_;
        public string Age;
        public string Gender;
        public string BirthDate;
        public string Employer;
        public string Position_;
        public string LabNo;
        public string HBsAg;
        public string Psa;
        public string Other;
        public string Rpr;
        public string AntiHBS;
        public string AntiHBSResult;
        public string CutOff;
        public string Medtech;
        public string MedtechLicense;
        public string Pathologist;
        public string PathologistLicense;
        public string ResultDate;
        public string otherName;
        public string otherRefValue;


        public frm_lab_33_Report()
        {
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_printers printers = new frm_printers();
            printers.ShowDialog();
        }

        private void frm_lab_33_Report_Load(object sender, EventArgs e)
        {

            LoadReport();
        }
        void RemoveTab(CrystalReportViewer rpt)
        {

            foreach (Control control in rpt.Controls)
            {
                if (control is PageView)
                {
                    TabControl tab = (TabControl)((PageView)control).Controls[0];
                    tab.ItemSize = new Size(0, 1);
                    tab.SizeMode = TabSizeMode.Fixed;
                    tab.Appearance = TabAppearance.Buttons;
                }
            }

        }






        void LoadReport()
        {
            this.Text = "Print Preview";

            IniFile ini = new IniFile(ClassSql.MMS_Path);


            R_TumorImmunological report = new R_TumorImmunological();
            //CrystalReportViewer viewer = new CrystalReportViewer();


            report.SetParameterValue("FormName", ini.IniReadValue("FORM", "Lab_33"));
            report.SetParameterValue("FormNoA", ini.IniReadValue("REVISION", "Lab_33"));
            report.SetParameterValue("FormNoB", ini.IniReadValue("ISO", "Lab_33"));
            report.SetParameterValue("Name", Name_);
            report.SetParameterValue("Age", Age);
            report.SetParameterValue("Gender", Gender);
            report.SetParameterValue("BirthDate", BirthDate);
            report.SetParameterValue("Employer", Employer);
            report.SetParameterValue("Position_", Position_);
            report.SetParameterValue("LabNo", LabNo);
            report.SetParameterValue("Psa", Psa);
            report.SetParameterValue("Other", Other);
            report.SetParameterValue("Rpr", getStatus(Rpr));
            report.SetParameterValue("HBsAg", getStatus(HBsAg));
            report.SetParameterValue("AntiHBS", getStatus(AntiHBS));
            report.SetParameterValue("AntiHBSResult", AntiHBSResult);
            report.SetParameterValue("Medtech", Medtech);
            report.SetParameterValue("MedtechLicense", MedtechLicense);
            report.SetParameterValue("Pathologist", Pathologist);
            report.SetParameterValue("PathologistLicense", PathologistLicense);
            report.SetParameterValue("ResultDate", ResultDate);
            report.SetParameterValue("otherName", otherName);
            report.SetParameterValue("otherRefValue", otherRefValue);
            report.SetParameterValue("cutOff", CutOff);



            Viewer_01.ReportSource = report;
            RemoveTab(Viewer_01);


        }

        private string getStatus(string status)
        {
            if (status.Equals("0"))
            {
                return "NONREACTIVE";
            }
            else if (status.Equals("1"))
            {
                return "REACTIVE";
            }

            return "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Viewer_01.PrintReport();
        }

        private void frm_lab_33_Report_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
