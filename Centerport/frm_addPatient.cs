using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using MedicalManagementSoftware.Class;
using MedicalManagementSoftware.DataSource;
using MedicalManagementSoftware.Model;
using MedicalManagementSoftware.Controller;
using System.Text.RegularExpressions;

namespace MedicalManagementSoftware
{
    public partial class frm_addPatient : Form
    {
        //private int Papin = 0; 
        private bool bl;
        public static PictureBox img;
        //private string patient_Type = "";
        public ProductsListing_Model selectedItem;
        public frm_addPatient()
        {
            InitializeComponent();
            img = pic_; img.AllowDrop = true;
        }

        private void cmd_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        bool isclose = false;
        private void cmd_save_cancel_Click(object sender, EventArgs e)
        {
            if (txt_papin.Text == "" || txt_lastname.Text == "" || txt_fname.Text == "" || txt_mname.Text == "" || dtbday.Text == "00/00/0000")
            {
                MessageBox.Show("Please fill required information. \nLast name \nFirst name \nMiddle name \nBirth date", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }
            else
            {
                backgroundWorker1.RunWorkerAsync();
                isclose = true;  

            }

            
           
        }
        public  string ReplaceString(string str)
        {
            return str.Replace("'", "`").Replace(@"\", "\\");
        }






        //void SaveImage()
        //{


        //    if (img.Image != null)
        //    {


        //        MySqlCommand cmd;               
        //        Image myBitmap = pic_.Image;
        //        var imageStream = new MemoryStream();
        //        using (imageStream)
        //        {                 
        //            myBitmap.Save(imageStream, ImageFormat.Png);
        //            imageStream.Position = 0;                 
        //            byte[] imageBytes = imageStream.ToArray();

        //            using (MySqlConnection con = new 

        //Connection(ClassSql.ConnString))
        //            {

        //                con.Open();
        //                cmd = new MySqlCommand("Update m_patient SET picture = @picture where papin ='" + txt_papin.Text + "'", con);
        //                cmd.Parameters.Add("@picture", MySqlDbType.LongBlob, 100);
        //                cmd.Parameters["@picture"].Value = imageBytes;
        //                cmd.ExecuteNonQuery();
        //                con.Close();

        //            }

                  
                   

                    
        //        }

        //    }
           
            
                          

        //}

        


        void RegisterPatient()
        {
            try
            {
                               
                if (cmd_save.Text == "&Save")
                {
                    if (txt_papin.Text == "" || txt_lastname.Text == "" || txt_fname.Text == "" || txt_mname.Text == "" || dtbday.Text == "00/00/0000")
                    {
                        MessageBox.Show("Please fill required information. \nLast name \nFirst name \nMiddle name \nBirth date","Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return;
                    }

                    else
                    {
                        //
                        //var ItemCode = Regex.Replace(selectedItem.ItemCode, @"[\d-]", string.Empty);
                        //var SalesRecId = Guid.NewGuid();
                        if(pic_.Image == null){
                            pic_.Image  = Properties.Resources.AnonymousPic;
                        }
                        DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);                    
                        db.ExecuteCommand("INSERT INTO m_patient (papin, lastname, firstname, middlename, address_1, address_2, city, district, contact_1, contact_2, position, marital_status, gender, birthdate, place_of_birth, type_of_job, employer, passport_no, seamansbook_no, picture,registration_date, remarks, nationality, religion, test_data, father_name, father_occupation, mother_name, no_of_brothers, no_of_sisters, birth_order, spouse_name, spouse_occupation, no_of_children, elementary, highschool, college, course, highest_level_attended, mother_occupation, prev_work_start, prev_work_end, prev_company, prev_position, prev_leave_reason, prev_years, date_last_updated, sirb, designation,country_destination) values ({0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14},{15},{16},{17},{18},{19},{20},{21},{22},{23},{24},{25},{26},{27},{28},{29},{30},{31},{32},{33},{34},{35},{36},{37},{38},{39},{40},{41},{42},{43},{44},{45},{46},{47},{48},{49})", txt_papin.Text, txt_lastname.Text, txt_fname.Text, txt_mname.Text, txt_address1.Text, "", txt_city.Text, '-', txt_contactNo.Text, '-', this.cboPosition.Text, cbo_marital.Text, cbo_gender.Text, dtbday.Text, txt_placeofBirth.Text, cbo_designation.Text, cbo_employer.Text, txt_passport.Text, txt_seamanNo.Text, Tool.ImageToByte(pic_.Image), dt_regDate.Text, txt_remark.Text, txt_nationality.Text, cbo_religeon.Text, '0', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', "00/00/0000", "00/00/0000", '-', '-', '-', '-', DateTime.Now, txt_SIRB.Text, cboPosition.Text, cbo_designation.Text);
                        db.ExecuteCommand("INSERT INTO t_registration (trkid, papin, pxtype, trans_date, diagnosis,purpose) values ({0},{1},{2},{3},{4},{5})", "", txt_papin.Text, "", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"), "", txtPorpose.Text);
                       // new Sales().create(SalesRecId.ToString(),txt_papin.Text, selectedItem);
           

                        Tool.MessageBoxSave();
                        Tool.ClearFields(panel2); Tool.ClearFields(panel3); Tool.ClearFields(panel4);  
                        dtbday.CustomFormat = "00/00/0000";
                       img.Image = null;
                    }

                }
               
                //Update code here/////////////

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
          

        
        
        }


        private void cmd_save_Click(object sender, EventArgs e)
        {
          
        
            backgroundWorker1.RunWorkerAsync();
            isclose = false;
        }

        private void frm_addPatient_Load(object sender, EventArgs e)
        {
            //ClassSql.DbConnect();
            txt_papin.Text = ClassSql.CreateID();         
          
            //load();
            load_Employer();
            Cursor.Current = Cursors.Default;
        }

       void load_Employer()
        {
            var list = EmployerList.employerList.ToList();
            cbo_employer.DataSource = list;
           
        }

        void load()
        {
            //cbo_patient_Type.Text = "BNI";
            //txt_transdateAndTime.Text = DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            //txt_purpose.Select();
            //txt_trackingNo.Text = ClassSql.CreateTrackingId();


        }

 
        private void txt_lastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txt_fname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void txt_mname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToUpper(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pic__DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files) //Console.WriteLine(file);
                {
                    // this.Text = file.ToString();
                    img.Image = Image.FromFile(file.ToString());
                }
            }
            catch
            { }

        }

        private void pic__DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
          

        }

        private void dtbday_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            {
                dtbday.Format = DateTimePickerFormat.Custom;
                dtbday.CustomFormat = "00/00/0000";
            }
        }

        private void dtbday_MouseDown(object sender, MouseEventArgs e)
        {
            dtbday.Format = DateTimePickerFormat.Custom;
            dtbday.CustomFormat = "MM/dd/yyyy";   
            DateTime CurrentDate = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            int Age = CurrentDate.Year - dtbday.Value.Year;
            //this.txt_age.Text = Age.ToString();
            if (CurrentDate.Month < dtbday.Value.Month)
            {
                Age--;
            }
            else if ((CurrentDate.Month == dtbday.Value.Month) && (CurrentDate.Day < dtbday.Value.Day))
            {

                Age--;
            }
            this.txt_age.Text = Age.ToString();
        }

        //private void cmd_add_Employer_Click(object sender, EventArgs e)
        //{
        //    ClassSql a = new ClassSql();
        //    if (a.CountColumn("Select * from tbl_employer where Employer = '" + Tool.ReplaceString(cbo_employer.Text) + "'") >= 1)
        //    {
        //        MessageBox.Show("Employer name already exist", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //        return;
        //    }
        //    else
        //    {
        //        a.ExecuteQuery("Insert into tbl_employer (Employer) values('" + Tool.ReplaceString(cbo_employer.Text) + "')");
        //        MessageBox.Show("Employer name added", Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}

        private void frm_addPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void dtbday_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void dtbday_ValueChanged(object sender, EventArgs e)
        {
          
            dtbday.Format = DateTimePickerFormat.Custom;
            dtbday.CustomFormat = "MM/dd/yyyy";
            DateTime CurrentDate = DateTime.Parse(DateTime.Now.Date.ToShortDateString());
            int Age = CurrentDate.Year - dtbday.Value.Year;
            //this.txt_age.Text = Age.ToString();
            if (CurrentDate.Month < dtbday.Value.Month)
            {
                Age--;
            }
            else if ((CurrentDate.Month == dtbday.Value.Month) && (CurrentDate.Day < dtbday.Value.Day))
            {

                Age--;
            }
            this.txt_age.Text = Age.ToString();
            SendKeys.Send("{RIGHT}");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate() { RegisterPatient(); }));
            this.Invoke(new MethodInvoker(delegate() { txt_papin.Text = ClassSql.CreateID(); }));

            
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if ((Application.OpenForms["frm_visit"] as frm_visit) != null)
            {
                (Application.OpenForms["frm_visit"] as frm_visit).Visit_Add_model.Clear();
                (Application.OpenForms["frm_visit"] as frm_visit).backgroundWorker1.RunWorkerAsync();  
            }
           
            
                      
            if (isclose)   {    this.Close();      }
           


        }

        private void txtTakePhote_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            frm_camera cam = new frm_camera();

            cam.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                pic_.Image.Dispose();
                pic_.Image = null;
            }
            catch
            {

            }
        }

        private void btnLoadPurpose_Click(object sender, EventArgs e)
        {
            new frm_productList().ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPorpose.Clear();
            selectedItem = new ProductsListing_Model();
        }

        private void cbo_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_designation.SelectedIndex == 0)
            {

                cboPosition.Items.Clear(); cboPosition.Text = "";
                string[] row = new string[] { "Master", "Chief Mate", "2nd Mate", "3rd mate", "A/B", "O/S", "A/M" };

                foreach (string item in row)
                {
                    cboPosition.Items.Add(item);
                }


            }
            else if (cbo_designation.SelectedIndex == 1)
            {
                cboPosition.Items.Clear(); cboPosition.Text = "";
                string[] row = new string[] { "Superintendent", "Chief Engr.", "Welder", "1st Engr.", "2nd Engr.", "3rd Engr.", "4th Engr.", "Oiler", "Wiper", "E/C" };
                foreach (string item in row)
                {
                    cboPosition.Items.Add(item);
                }
            }
            else if (cbo_designation.SelectedIndex == 2)
            {
                cboPosition.Items.Clear(); cboPosition.Text = "";
                string[] row = new string[] { "Messman", "Chief Cook" };
                foreach (string item in row)
                {
                    cboPosition.Items.Add(item);
                }

            }
            else
            {
                cboPosition.Items.Clear(); cboPosition.Text = "";
                string[] row = new string[] { "Student", "Driver", "Conductor", "Office Staff" };
                foreach (string item in row)
                {
                    cboPosition.Items.Add(item);
                }
            }
        }

       
    }
}
