using MedicalManagementSoftware.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Model
{
    class PanamaMedicalExaminationModel
    {


        public void Save(string Papin, string ResultMainUID, string Height, string Weight, string BMI, string Oxygen, string HeartRate, string Respiratory, string BloodPressure, string Diatolic,
                string UnaidedRightEyeDistant, string UnAidedLeftEyeDistant, string UnAidedBonocularDistant, string AidedRightEyeDistant, string AidedLeftEyeDistant, string AidedBinocularDistant, string UnaidedRightEyeShort, string UnAidedLeftEyeShort, string UnAidedBonocularShort, string AidedRightEyeShort, string AidedLeftEyeShort, string AidedBinocularShort, string NonTestedColorVision, string NormalColorVision, string DoubtfulColorVision, string DefectiveColorVision, string NormalRightEye, string NormalLeftEye, string DefectiveRightEye, string DefectiveLeftEye, string Comments,
                 string HzRightEara, string kRightEarb, string kRightEarc, string kRightEard, string HzLeftEare, string kLeftEarf, string kLeftEarg, string kLeftEarh)
        {
            DataClasses2DataContext db = new DataClasses2DataContext(Database.connectionString);
            db.PanamaMedicalExaminationSave(Papin, ResultMainUID, Height, Weight, BMI, Oxygen, HeartRate, Respiratory, BloodPressure, Diatolic, UnaidedRightEyeDistant, UnAidedLeftEyeDistant, UnAidedBonocularDistant, AidedRightEyeDistant, AidedLeftEyeDistant, AidedBinocularDistant, UnaidedRightEyeShort, UnAidedLeftEyeShort, UnAidedBonocularShort, AidedRightEyeShort, AidedLeftEyeShort, AidedBinocularShort, NonTestedColorVision, NormalColorVision, DoubtfulColorVision, DefectiveColorVision, NormalRightEye, NormalLeftEye, DefectiveRightEye, DefectiveLeftEye, Comments, HzRightEara, kRightEarb, kRightEarc, kRightEard, HzLeftEare, kLeftEarf, kLeftEarg, kLeftEarh);

        }


    }
}
