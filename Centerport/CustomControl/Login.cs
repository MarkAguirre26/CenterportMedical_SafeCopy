using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MedicalManagementSoftware.DataSource;
using MedicalManagementSoftware.Class;
using MedicalManagementSoftware.Model;
using MedicalManagementSoftware.Server;

namespace MedicalManagementSoftware.UserControlView
{
    public partial class Login : UserControl
    {
        Main fmain;
        public Login(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            errorMessage.Text = "";
            new frm_server().ShowDialog();
        }


        private void ViewMainForm(bool bl)
        {
            if (bl == true)
            {
             
                foreach (Control item in fmain.Controls.OfType<UserControl>())
                {
                    if (item.Name == "Login")
                        fmain.Controls.Remove(item);




                }
            }

            
            fmain.menuStripTop.Visible = bl;
            fmain.toolStripTop.Visible = bl;

           
        }


        private void cmd_login_Click(object sender, EventArgs e)
        {

            loginAsync();


        }


        private async void loginAsync()
        {
            var result = await new Database().connectAsync();
            if (result)
            {
                login();
                return;
            }

            //else
            errorMessage.ForeColor = System.Drawing.Color.Maroon;
            errorMessage.Text = "Not connected to server";


        }





        void login()
        {
          

                DataClasses2DataContext db = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
                var i = db.sp_login(txt_username.Text, txt_password.Text,"Medical").FirstOrDefault();

                if (i != null)
                {


                    fmain.UserLevel = i.UserLevel;
                    fmain.UserCn = i.cn;
                    fmain.setRestriction();



                    getEmployerFromDatabase();


                    ViewMainForm(true);




                }
                else
                {

                    errorMessage.Text = "Access Denied!";
                    return;

                }


        }
        private void getEmployerFromDatabase()
        {
            List<Employer> employerList = new List<Employer>();
            DataTable dt = MyClass.Table("SELECT a.RedID, a.EmployerRecID, a.EmployerName FROM dbo.CenterportMedicalEmployer a ORDER BY a.EmployerName ASC");
            foreach (DataRow dr in dt.Rows)
            {

                employerList.Add(new Employer
                {
                    EmployerCode = dr["EmployerRecID"].ToString(),
                    EmployerName = dr["EmployerName"].ToString()
                });


            }

            EmployerList.employerList = employerList;
        }


        private void Login_Load(object sender, EventArgs e)
        {

            ViewMainForm(false);

            this.Text = Properties.Settings.Default.SystemName + Tool.version;
            //txt_username.Clear();
            //txt_password.Clear();


            //if (System.Environment.MachineName == "CMSISERVER-PC")
            //{
            //    ClassSql.ConnectSqlInstance(Properties.Settings.Default.InstanceName);
            //}


        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frm_camera().ShowDialog();
        }
    }
}
