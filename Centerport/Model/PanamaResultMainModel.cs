using MedicalManagementSoftware.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Model
{
    class PanamaResultMainModel
    {
        public void Save(string ResultMainUID, string Papin, string FitForLookOut, string NonFitForLookOut, string DeckServiceFit, string EngineFit, string CateringFit, string OtherServiceFit, string DeckServiceUnFit, string EngineUnFit, string CateringUnFit, string OtherUnFit, string WithOutRestrictions, string WithRestrictions, string cbVisualAidRequiredYes, string cbVisualAidRequiredNo, string Comment, string MedicalCertificateExpiration, string MedicalCertificateIssued, string NumberOfMedicalCertificate, string PhysicianName, string assessmentComment1, string assessmentComment3, string assessmentComment4, string assessmentComment5)
        {
            DataClasses2DataContext db = new DataClasses2DataContext(Database.connectionString);
            db.PanamaResultMainSave(ResultMainUID, Papin, FitForLookOut, NonFitForLookOut, DeckServiceFit, EngineFit, CateringFit, OtherServiceFit, DeckServiceUnFit, EngineUnFit, CateringUnFit, OtherUnFit, WithOutRestrictions, WithRestrictions, cbVisualAidRequiredYes, cbVisualAidRequiredNo, Comment, MedicalCertificateExpiration, MedicalCertificateIssued, NumberOfMedicalCertificate, PhysicianName, assessmentComment1, assessmentComment3, assessmentComment4, assessmentComment5);
        }


    }
}
