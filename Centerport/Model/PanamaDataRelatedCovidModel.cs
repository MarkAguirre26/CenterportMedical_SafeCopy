

using MedicalManagementSoftware.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Model
{
    class PanamaDataRelatedCovidModel
    {

        public void Save(string Papin, string ResultMainUID, string ContactInCovidPositive, string CovidTest, string CovidDateTest, string HadFeverLast30Days, string VaccinationCovid, string VaccineType, string NumberofDoses, string Booster)
        {
            DataClasses2DataContext db = new DataClasses2DataContext(Database.connectionString);
            db.PanamaDataRelatedCovidSave(Papin, ResultMainUID, ContactInCovidPositive, CovidTest, CovidDateTest, HadFeverLast30Days, VaccinationCovid, VaccineType, NumberofDoses, Booster);
        }
    }
}
