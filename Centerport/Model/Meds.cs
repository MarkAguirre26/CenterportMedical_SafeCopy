using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Model
{
  public  class Meds
    {

        public string Name { get; set; }
        public string License { get; set; }

        public Meds(string Name, string License)
        {
            this.Name = Name;
            this.License = License;
      }

    }
}
