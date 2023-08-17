using MedicalManagementSoftware.Class;
using MedicalManagementSoftware.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MedicalManagementSoftware
{
    public partial class frm_searchTumor : Form
    {
        public List<PatientList> patientList = new List<PatientList>();
        private string FilterBy;
        Main fmain;
        public frm_searchTumor(Main maiin)
        {
            fmain = maiin;
            InitializeComponent();
        }



        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            { dg_result.Focus(); }
            else if (e.KeyCode == Keys.Enter)
            {
                //Search(txt_search.Text);
            }

        }


        private void cmd_clear_Click(object sender, EventArgs e)
        {
            txt_search.Clear();
            txt_search.Select();

        }

        private void patientInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dg_result.SelectedRows.Count >= 1)
            {
                frm_patient_Info info = new frm_patient_Info();
                info.Tag = dg_result.SelectedRows[0].Cells["Papin"].Value.ToString();
                info.ShowDialog();


            }
        }

        private void frm_searchTumor_Load(object sender, EventArgs e)
        {

            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }

            txt_search.Select();
        }

        void SelectItem()
        {
            if (dg_result.SelectedRows.Count >= 1)
            {
                this.Close();
                Cursor.Current = Cursors.WaitCursor;
                string papin = this.dg_result.SelectedRows[0].Cells[1].Value.ToString();
                var form = (Application.OpenForms["Frm_Immunology"] as Frm_Immunology);
               
                form.Tag = papin;
                form.ClearAll();
                form.Search();


             

                Cursor.Current = Cursors.Default;
            }

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "")
            {
                var list = (from m in patientList where m.PatientName.ToUpper().StartsWith(txt_search.Text) select m).ToList();

                dg_result.DataSource = list;
            }
            else
            {
                dg_result.DataSource = patientList;
            }
        }

        private void cmd_search_Click(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void dg_result_DoubleClick(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void frm_searchTumor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { SelectItem(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate() { FillDataGridView(); }));
        }

        public void FillDataGridView()
        {



            try
            {

                DataClasses2DataContext db = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
                var list = db.MedicalPatientList().ToList();

                foreach (var i in list)
                {
                    patientList.Add(new PatientList
                    {
                        cn = i.cn,
                        papin = i.papin,
                        PatientName = i.PatientName
                    });
                }

                dg_result.DataSource = patientList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }

        }



    }
}
