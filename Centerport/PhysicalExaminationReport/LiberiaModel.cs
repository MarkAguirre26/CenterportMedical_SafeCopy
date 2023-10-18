using MedicalManagementSoftware.Model;
using MedicalManagementSoftware.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.PhysicalExaminationReport
{
    public class LiberiaModel
    {
        public void save(string Papin,
                string ExaminationForDuty,
                string Height,
                string Weight,
                string BloodPressure,
                string Pulse,
                string Respiration,
                string GeneralAppearance,
                string VissionRightEye,
                string VissionLeftEye,
                string VissionWithGlassRight,
                string VissionWithGlassLeft,
                string ColorVissionMeetsStandard,
                string ColorTestType,
                string HearingRight,
                string HearingLeft,
                string Heart,
                string Lungs,
                string Speach,
                string ExtremitiesUpper,
                string ExtremitiesLower,
                string COLOR_VISION_DATE_TAKEN,
                string SATISFACTORY_SIGHT_UNAID,
                string CLARITY_OF_SPEECH,
                string result_date,
                string valid_until)
        {
            DataClasses2DataContext db = new DataClasses2DataContext(Database.connectionString);
            db.sp_Liberia(Papin,
                          ExaminationForDuty,
                          Height,
                          Weight,
                          BloodPressure,
                          Pulse,
                          Respiration,
                          GeneralAppearance,
                          VissionRightEye,
                          VissionLeftEye,
                          VissionWithGlassRight,
                          VissionWithGlassLeft,
                          ColorVissionMeetsStandard,
                          ColorTestType,
                          HearingRight,
                          HearingLeft,
                          Heart,
                          Lungs,
                          Speach,
                          ExtremitiesUpper,
                          ExtremitiesLower,
                          COLOR_VISION_DATE_TAKEN,
                          SATISFACTORY_SIGHT_UNAID,
                          CLARITY_OF_SPEECH,
                          result_date,
                          valid_until);
        }
    }
}
