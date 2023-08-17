//using MedicalManagementSoftware.Class;
using Ini;
using MedicalManagementSoftware.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalManagementSoftware
{
    public partial class frm_server : Form
    {
        string path = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.LastIndexOf('\\')).LastIndexOf('\\')) + "\\HostAddress.txt";
        private const long BUTTON_DOWN_CODE = 0xa1;
        private const long BUTTON_UP_CODE = 0xa0;
        private const long WM_MOVING = 0x216;
        static bool left_button_down = false;



       
        public frm_server()
        {
            InitializeComponent();
        }

        protected override void DefWndProc(ref System.Windows.Forms.Message m)
        {
            //Check the state of the Left Mouse Button
            if ((long)m.Msg == BUTTON_DOWN_CODE)
                left_button_down = true;
            else if ((long)m.Msg == BUTTON_UP_CODE)
                left_button_down = false;

            if (left_button_down)
            {
                if ((long)m.Msg == WM_MOVING)
                {
                    //Set the forms opacity to 50% if user is moving
                    if (this.Opacity != 0.5)
                        this.Opacity = 0.5;
                }
            }
                //
            else if (!left_button_down)
                if (this.Opacity != 1.0)
                    this.Opacity = 1.0;

            base.DefWndProc(ref m);
        }

        private void readWriteServerAddress()
        {


            // This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                string[] createText = { "CMSISERVER-PC", "DESKTOP-LKJNLEE" };
                File.WriteAllLines(path, createText);
            }
            //
            // This text is always added, making the file longer over time
            // if it is not deleted.
            //string appendText = "This is extra text" + Environment.NewLine;
            //File.AppendAllText(path, appendText);

            // Open the file to read from.
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                //Console.WriteLine(s);
                cboServer.Items.Add(s);
            }
        }


        private void frm_server_Load(object sender, EventArgs e)
        {
            readWriteServerAddress();
            //string[] lines = System.IO.File.ReadAllLines(ClassSql.AppData);
            //for (int i = 0; i < lines.Length; i++)
            //{
             
            // txt_Server.Text = lines[0];
            // txt_database.Text = lines[1];
            // txt_userID.Text = lines[2];
            // txt_Password.Text = lines[3];
            //}

           //// IniFile ini = new IniFile(ClassSql.MMS_Path);

           // txt_Server.Text =         ini.IniReadValue("CONNECTIONSTRING", "Server");
           // txt_database.Text =       ini.IniReadValue("CONNECTIONSTRING", "Database");
           // txt_userID.Text =         ini.IniReadValue("CONNECTIONSTRING", "Uid");
           // txt_Password.Text =       ini.IniReadValue("CONNECTIONSTRING", "Pwd");
 
            cboServer.Text =   Properties.Settings.Default.Server;
            txt_database.Text =  Properties.Settings.Default.Database;
            txt_userID.Text =   Properties.Settings.Default.UID;
            txt_Password.Text = Properties.Settings.Default.Password;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (ClassSql.ConnState)
            //{

            //    this.Close();


            //}
            //else
            //{
            //    if (MessageBox.Show("System is currently not connected to server! Would you like to continue?", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {

            //        Application.Exit();

            //    }


            //}
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string ConnectionString = "Server=" + txt_Server.Text + ";Database=" + txt_database.Text + ";UID=" + txt_userID.Text + ";Password=" + txt_Password.Text + "; Convert Zero Datetime=True";
            string ConnectionString = "Data Source=" + cboServer.Text + ";Initial Catalog=" + txt_database.Text + ";Persist Security Info=True;User ID=" + txt_userID.Text + ";Password=" + txt_Password.Text + ";";

            MedicalManagementSoftware.Class.MyClass.connectionString = ConnectionString;

            Properties.Settings.Default.MyConString = ConnectionString;
            Properties.Settings.Default.Server = cboServer.Text;
            Properties.Settings.Default.Database = txt_database.Text;
            Properties.Settings.Default.UID = txt_userID.Text;
            Properties.Settings.Default.Password = txt_Password.Text;
            Properties.Settings.Default.Save();

            callTestConnectionAsync();
            labelMessage.Text = "Connecting ...";
         
        }

        private async void callTestConnectionAsync()
        {
            var result = await new Database().connectAsync();
            if (result)
            {
                labelMessage.ForeColor = System.Drawing.Color.Green;
                labelMessage.Text = "Successfully Connected";
                this.Close();
                return;
            }
           
            //else
            labelMessage.ForeColor = System.Drawing.Color.Maroon;
            labelMessage.Text = "Not Connected";
          

        }




        private void frm_server_FormClosing(object sender, FormClosingEventArgs e)
        {
            IniFile ini = new IniFile(ClassSql.MyConString);
            ini.IniWriteValue("SQLCONNECTION", "Key", "Data Source=" + cboServer.Text + ";Initial Catalog=" + txt_database.Text + ";Persist Security Info=True;User ID=" + txt_userID.Text + ";Password=" + txt_Password.Text + ";");
        }

    }
}
