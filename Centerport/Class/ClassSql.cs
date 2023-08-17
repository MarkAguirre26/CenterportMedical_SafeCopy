using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using System.ServiceProcess;
using MedicalManagementSoftware.Model;


namespace MedicalManagementSoftware
{
    public class ClassSql
    {
        public static bool ConnState = true;       
        public static DataTable dt;
        private static long Papin; private static long TrackId;
        public static DataTable dt_patient;
        public static string AppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ConnectionString.txt");
        public static string Update = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Update.txt");
        //public static string EmployerPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Employer.txt");
      
        public static string MMS_Path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MedicalManagementSoftware.ini");
        public static string tmp_path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "temp.txt");
        public static string HIV_TempImage = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "HIV_Image");
      
        public static string ConnString;// = File.ReadAllText(AppData);
        public static DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);

        public static string MyConString = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MyConString.ini");
        public static void ConnectSqlInstance(string InstanceName)
        {
            string myServiceName = "MSSQL$" + InstanceName;
            string status;
            ServiceController mySC = new ServiceController(myServiceName);

            try
            {
                status = mySC.Status.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured " + ex.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                new frm_Instance().ShowDialog();
                return;

            }


            if (mySC.Status.Equals(ServiceControllerStatus.Stopped) | mySC.Status.Equals(ServiceControllerStatus.StopPending))
            {
                try
                {

                    mySC.Start();
                    mySC.WaitForStatus(ServiceControllerStatus.Running);


                }
                catch (Exception ex)
                {

                    MessageBox.Show("Error in starting the service: " + ex.Message, "Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }



        }

      
        public static string CreateID()
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            string str;
            var list = db.Create_Patient_ID();
            foreach (var i in list)
            {
                string LastPapin = i.papin.ToString();
                Papin = Tool.GetInt(LastPapin);
            }

            return str = Papin.ToString("CMSI00000000");


        }


        public string ReplaceString(string str)
        { return str.Replace("'", "").Replace(@"\", ""); }









    }
}
