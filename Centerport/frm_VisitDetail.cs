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
using MedicalManagementSoftware.Class;
using System.Text.RegularExpressions;
using MedicalManagementSoftware.Controller;
using MedicalManagementSoftware.Model;

namespace MedicalManagementSoftware
{

  
    public partial class frm_VisitDetail : Form
    {
        public string cn = null;
        public string pupose = "";
      //  frm_search_Patient_Queuing Search_q;
        public ProductsListing_Model selectedItem;
        public frm_VisitDetail()
        {
            InitializeComponent();
        //    Search_q = q;
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_VisitDetail_Load(object sender, EventArgs e)
        {

            load();
        }

        void load()
        {

            //cbo_type.Text = "BNI";
            //txt_transdate.Text = DateTime.Today.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
            //txt_purpose.Select();



        }

        private void cmd_ok_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
            if (cn == null)
            {
               

                    //var ItemCode = Regex.Replace(selectedItem.ItemCode, @"[\d-]", string.Empty);
                    var trkid = new Random().Next(1000, 1000000000);
                    db.ExecuteCommand("INSERT INTO t_registration (trkid, papin, pxtype, trans_date, diagnosis,purpose) values ({0},{1},{2},{3},{4},{5})", trkid, this.Tag.ToString(), "", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"), "", txtPorpose.Text);
                  
                
              
            }
            else {
                db.ExecuteCommand("UPDATE t_registration SET purpose={0} WHERE (cn={1})",txtPorpose.Text,cn);
            }
            //InsertVisit();

            // new Sales().create(SalesRecId.ToString(), this.Tag.ToString(), selectedItem);
            (Application.OpenForms["frm_visit"] as frm_visit).loadlist();
            var f = (Application.OpenForms["frm_search_Patient_Queuing"] as frm_search_Patient_Queuing);
            if ( f != null)
            {
                f.Close();
            }
           
            this.Close();
        }



        //void InsertVisit()
        //{
            





        //}

        private void frm_VisitDetail_FormClosing(object sender, FormClosingEventArgs e)
        {

            //if (!(Application.OpenForms["frm_visit"] as frm_visit).backgroundWorker1.IsBusy)
            //{
            //    Centerport.frm_visit.TableFields f = new Centerport.frm_visit.TableFields();
            //    f.Date = (Application.OpenForms["frm_visit"] as frm_visit).dt_from.Text;
            //    (Application.OpenForms["frm_visit"] as frm_visit).dg_listQueue.Rows.Clear();
            //    (Application.OpenForms["frm_visit"] as frm_visit).backgroundWorker1.RunWorkerAsync(f);
            //}
        }

        private void btnLoadPurpose_Click(object sender, EventArgs e)
        {
            new frm_productList().ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtPorpose.Clear();
        }




    }
}
