using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalManagementSoftware.Class
{
    public class ProductsListing_Model
    {

        public string RecID { get; set; }
        
        public string EmployerCode { get; set; }
        public string ItemCode { get; set; }
        public string ProductName { get; set; }
      
        public string ParentCode { get; set; }
        public string ParentDescription { get; set; }
        public string LevelCode { get; set; }
        public string LevelName { get; set; }
        public string Price { get; set; }
        public string Active { get; set; }
    }
}
