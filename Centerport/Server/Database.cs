using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalManagementSoftware.Model;

namespace MedicalManagementSoftware.Server
{
public class Database
    {


        //private async bool callTestConnectionAsync()
        //{
        //    var result = await testConnectionAsync();
        //    return result;

        //}

      public static string connectionString;


        public Task<bool> connectAsync()
        {
            return Task.Factory.StartNew(() => testConnection());
        }

        private bool testConnection()
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
                db.Connection.Open();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Connection Error", ex.Message);
                return false;
            }
        }





    }
}
