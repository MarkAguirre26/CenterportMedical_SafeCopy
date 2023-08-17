using MedicalManagementSoftware.Class;
using MedicalManagementSoftware.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MedicalManagementSoftware.Model;
using System.Windows.Forms;

namespace MedicalManagementSoftware
{
    public partial class frm_productList : Form
    {
        //frm_addPatient parentForm;
        List<ProductsListing_Model> itemsAll = new List<ProductsListing_Model>();
        public ProductsListing_Model selectedItem;
        public frm_productList()
        {
            InitializeComponent();
            //parentForm = f;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            DataClasses2DataContext dt = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
            var list = dt.CenterportAccounting_ProductListing().ToList();
            foreach (var i in list)
            {
                itemsAll.Add(new ProductsListing_Model
                {
                    RecID = i.RecID.ToString(),
                    EmployerCode = i.EmployerCode,
                    ItemCode = i.ItemCode,
                    ProductName = i.ProductName,
                    ParentCode = i.ParentCode,
                    ParentDescription = i.ParentDescription,
                    LevelCode = i.LevelCode.ToString(),
                    LevelName = i.LevelName,
                    Price = i.Price.ToString(),
                    Active = i.Active.ToString()
                });
            }

        }

        private void frm_productList_Load(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void itemsSearch(string keyWord)
        {
            //List<ProductsListing_Model> items = new List<ProductsListing_Model>();
            var list = (from m in itemsAll where (m.LevelCode.Equals("1") && m.ItemCode.Contains(keyWord)) select m).ToList();
            dgList.Rows.Clear();
            foreach (var i in list)
            {
                var ItemCode = Regex.Replace(i.ItemCode, @"[\d-]", string.Empty);
                dgList.Rows.Add(i.RecID, i.ItemCode + " - " + i.ProductName, i.ParentDescription, i.Price);
            }

        }

        private void itemSelected(string keyWord)
        {
            //List<ProductsListing_Model> items = new List<ProductsListing_Model>();
            var item = (from m in itemsAll where (m.RecID.Equals(keyWord)) select m).FirstOrDefault();
            selectedItem = item;
            if ((Application.OpenForms["frm_addPatient"] as frm_addPatient) != null)
            {
                (Application.OpenForms["frm_addPatient"] as frm_addPatient).selectedItem = item;
            }
            else
            {
                (Application.OpenForms["frm_VisitDetail"] as frm_VisitDetail).selectedItem = item;
            }

        }


        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            itemsSearch("");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            itemsSearch(txtSearch.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {


            selectItem();
        }

        private void selectItem()
        {
            if (dgList.SelectedRows.Count != 0)
            {


                itemSelected(dgList.SelectedRows[0].Cells[0].Value.ToString());
                var ItemCode = Regex.Replace(selectedItem.ItemCode, @"[\d-]", string.Empty);



                if ((Application.OpenForms["frm_addPatient"] as frm_addPatient) != null)
                {
                    //new Sales().edit(this.Tag.ToString(), selectedItem);
                    
                    (Application.OpenForms["frm_addPatient"] as frm_addPatient).txtPorpose.Text = ItemCode + " - " + selectedItem.ProductName + "";
                   
                   
                }
                else
                {
                    (Application.OpenForms["frm_VisitDetail"] as frm_VisitDetail).txtPorpose.Text = ItemCode + " - " + selectedItem.ProductName + ""; 
                }
               

                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid selection!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                selectItem();
            }
        }

        private void dgList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 || e.ColumnIndex != -1)
            {
                selectItem();
            }
        }
    }
}
