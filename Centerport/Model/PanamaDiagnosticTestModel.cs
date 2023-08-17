using MedicalManagementSoftware.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Model
{
    class PanamaDiagnosticTestModel
    {
        public void Save(string Papin, string ResultMainUID, string Hemogram, string HemogramNormal, string HemogramAbNormal, string HemogramOservation, string Lipid, string LipidNormal, string LipidAbNormal, string LipidObservation, string Creatinine, string CreatinineNormal, string CreatinineAbnormal, string CreatinineObservation, string Cholesterol, string CholesterolNormal, string CholesterolAbnormal, string CholesterolObservation, string Triglycerides, string TriglyceridesNormal, string TriglyceridesAbnormal, string TriglyceridesObservation, string Glucose, string GlucoseNormal, string GlucoseAbNormal, string GlucoseObservation, string Nitrogen, string NitrogenNormal, string NitrogenAbnormal, string NitrogenObservation, string RhTyping, string RhTypingNormal, string RhTypingAbnormal, string RhTypingObservation, string Hiv, string HivNormal, string HivAbnormal, string HivObservation, string Vdrl, string VdrlNormal, string VdrlAbnormal, string VdrlObservation, string Gch, string GchNormal, string GchAbnormal, string GchObservation, string GeneralUrien, string GeneralUrineNormal, string GeneralUrineAbNormal, string GeneralUrineObservation, string Stool, string StoolNormal, string StoolAbNormal, string StoolObservation, string Drugtest, string DrugTestNormal, string DrugTestAbNormal, string DrugTestObservation, string Alcohol, string AlcoholNormal, string AlcoholAbNormal, string AlcoholObservation, string Breast, string BreastExaminationNormal, string BreastExaminationAbNormal, string BreastExaminationObservation, string PapTest, string PaptestJNormal, string PapAbnormal, string PapObservation, string Psa, string PsaNormal, string PsaAbNormal, string PsaObservation, string Xray, string XrayDate, string XrayObservation, string Ekg, string EkgDate, string EkgObservation, string SarsCovidByPcr, string SarsCovidByAntigens, string OtherTest, string OtherTestResult, string DiagnosticComment1, string DiagnosticComment2, string DiagnosticComment3, string DiagnosticComment4)
        {
            DataClasses2DataContext db = new DataClasses2DataContext(Database.connectionString);
            db.PanamaDiagnosticTestSave(Papin, ResultMainUID, Hemogram, HemogramNormal, HemogramAbNormal, HemogramOservation, Lipid, LipidNormal, LipidAbNormal, LipidObservation, Creatinine, CreatinineNormal, CreatinineAbnormal, CreatinineObservation, Cholesterol, CholesterolNormal, CholesterolAbnormal, CholesterolObservation, Triglycerides, TriglyceridesNormal, TriglyceridesAbnormal, TriglyceridesObservation, Glucose, GlucoseNormal, GlucoseAbNormal, GlucoseObservation, Nitrogen, NitrogenNormal, NitrogenAbnormal, NitrogenObservation, RhTyping, RhTypingNormal, RhTypingAbnormal, RhTypingObservation, Hiv, HivNormal, HivAbnormal, HivObservation, Vdrl, VdrlNormal, VdrlAbnormal, VdrlObservation, Gch, GchNormal, GchAbnormal, GchObservation, GeneralUrien, GeneralUrineNormal, GeneralUrineAbNormal, GeneralUrineObservation, Stool, StoolNormal, StoolAbNormal, StoolObservation, Drugtest, DrugTestNormal, DrugTestAbNormal, DrugTestObservation, Alcohol, AlcoholNormal, AlcoholAbNormal, AlcoholObservation, Breast, BreastExaminationNormal, BreastExaminationAbNormal, BreastExaminationObservation, PapTest, PaptestJNormal, PapAbnormal, PapObservation, Psa, PsaNormal, PsaAbNormal, PsaObservation, Xray, XrayDate, XrayObservation, Ekg, EkgDate, EkgObservation, SarsCovidByPcr, SarsCovidByAntigens, OtherTest, OtherTestResult, DiagnosticComment1, DiagnosticComment2, DiagnosticComment3, DiagnosticComment4);

        }


    }
}
