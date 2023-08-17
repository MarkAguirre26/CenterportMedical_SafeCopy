using MedicalManagementSoftware.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Model
{
    public class Patients_Model
    {

        private string Papin { get; set; }
        private string RhTyping { get; set; }
        private string LookOutDuties { get; set; }
        private string EmergencyDuties { get; set; }
        private string TypeOfShip { get; set; }
        private string TradeArea { get; set; }



        public void SavePatient(string Papin, string RhTyping, string LookOutDuties, string EmergencyDuties, string TypeOfShip, string TradeArea)
        {
            DataClasses2DataContext db = new DataClasses2DataContext(Database.connectionString);
            db.PanamaPatient_Save(Papin, RhTyping, LookOutDuties, EmergencyDuties, TypeOfShip, TradeArea);
        }

    }
}
