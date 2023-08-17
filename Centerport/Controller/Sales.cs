using MedicalManagementSoftware.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalManagementSoftware.Model;

namespace MedicalManagementSoftware.Controller
{
    public class Sales
    {
        public void create(string SalesRecId, string papin, ProductsListing_Model i)
        {
           
               // DataClasses2DataContext dc = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
               // dc.ExecuteCommand("INSERT INTO CenterportMedicalAccountingSales (SalesRecID,Papin,  EmployerRecID, ProductCode, Quantity, Price) VALUES ({0}, {1}, {2}, {3}, {4}, {5})", SalesRecId, papin, i.EmployerCode, i.ItemCode, 1, i.Price);

              //  dt.ExecuteCommand("INSERT INTO CenterportMedicalTransaction (SalesRecID, Papin, Description, SubTotal, PersonalAccount, Discount, Tax, GrandTotal) VALUES ({0}, {1}, {2}, {3}, {4}, {5}, {6}, {7})", purchaseItem.SalesRecID, purchaseItem.Papin, purchaseItem.Description, subTotal, PersonalAccount, Discount, Tax, subTotal);
         

          
        }

        public void edit(string SalesRecId, ProductsListing_Model i)
        {
            DataClasses2DataContext dc = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
            dc.ExecuteCommand("UPDATE CenterportMedicalAccountingSales SET ProductCode={0}, Price={1} WHERE (SalesRecID={2})", i.ItemCode, i.Price, SalesRecId);
            dc.ExecuteCommand("UPDATE [t_registration] SET [purpose]={0} WHERE ([trkid]={1})", i.ItemCode + " - " + i.ProductName, SalesRecId);
        }


    }
}
