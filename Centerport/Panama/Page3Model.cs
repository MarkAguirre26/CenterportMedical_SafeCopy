using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Panama
{
 public   class Page3Model
    {
        public string TakenMedications { get; set; }
        public string TakenMedicationsComment1 { get; set; }
        public string TakenMedicationsComment2 { get; set; }
        public string TakenMedicationsComment3 { get; set; }
        public string TakenMedicationsComment4 { get; set; }
        public string TakenMedicationsComment5 { get; set; }
        public string ContactInCovidPositive { get; set; }

        public string CovidTest { get; set; }
        public string CovidDateTest { get; set; }
        public string HadFeverLast30Days { get; set; }
        public string VaccinationCovid { get; set; }
        public string VaccineType { get; set; }
        public string NumberofDoses { get; set; }


        public string Booster { get; set; }


        public string NameOfUndergoingExamination { get; set; }
        public string Day { get; set; }
        public string Month { get; set; }
        public string Year { get; set; }

    }
}
