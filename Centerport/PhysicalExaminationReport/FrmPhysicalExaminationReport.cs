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
    public partial class FrmPhysicalExaminationReport : Form
    {
        public PhysicalExaminationMedicalRecordModel physicalExaminationMedicalRecordModel;
        public FrmPhysicalExaminationReport()
        {
            InitializeComponent();
        }

        private void FrmPhysicalExaminationReport_Load(object sender, EventArgs e)
        {
            getReport();
        }


        private void getReport()
        {
            PhysicalExaminationReport report = new PhysicalExaminationReport();


            Viewer1.ReportSource = report;


            report.SetParameterValue("Latname", physicalExaminationMedicalRecordModel.LastName);
            report.SetParameterValue("FirstName", physicalExaminationMedicalRecordModel.LastName);
            report.SetParameterValue("MiddileName", physicalExaminationMedicalRecordModel.MiddleName);
            report.SetParameterValue("Month", physicalExaminationMedicalRecordModel.Month);
            report.SetParameterValue("Day", physicalExaminationMedicalRecordModel.Day);
            report.SetParameterValue("Year", physicalExaminationMedicalRecordModel.Year);
            report.SetParameterValue("City", physicalExaminationMedicalRecordModel.City);
            report.SetParameterValue("Country", physicalExaminationMedicalRecordModel.Country);
            report.SetParameterValue("Gender", physicalExaminationMedicalRecordModel.Gender);
            report.SetParameterValue("Position", physicalExaminationMedicalRecordModel.Position);
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

            Viewer1.ReportSource = report;
        }
    }
}
