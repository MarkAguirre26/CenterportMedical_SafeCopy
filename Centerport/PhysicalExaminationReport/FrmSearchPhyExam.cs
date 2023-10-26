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

namespace MedicalManagementSoftware.PhysicalExaminationReport
{
    public partial class FrmSearchPhyExam : Form
    {
       





         private string FilterBy;
        Main fmain;
        public List<Panama_SeaMLC> panama_SeaMLC_MLC = new List<Panama_SeaMLC>();
        public FrmSearchPhyExam(Main maiin)
        {
            InitializeComponent();
            fmain = maiin;
        }

        private void FrmSearchPhyExam_Load(object sender, EventArgs e)
        {
           
            cbo_filter.Text = "Patient Name";
            FilterBy = "CONCAT(m_patient.lastname,',',m_patient.firstname,' ',m_patient.middlename)";
            txt_search.Select();


            if (!backgroundWorker1.IsBusy)
            { backgroundWorker1.RunWorkerAsync(); }
        }




        public void FillDataGridView()
        {

            try
            {

                panama_SeaMLC_MLC = (Application.OpenForms["FrmPhysicalExamination"] as FrmPhysicalExamination).Panama_SeaMLC_model;
                var list = (from m in panama_SeaMLC_MLC select m).ToList();


                if (cbo_filter.Text == "Result ID")
                {

                    list = (from m in panama_SeaMLC_MLC where m.resultID.StartsWith(txt_search.Text) select m).ToList();
                }
                else if (cbo_filter.Text == "Patient Name")
                {

                    list = (from m in panama_SeaMLC_MLC where m.patientName.StartsWith(txt_search.Text) select m).ToList();
                }
                dg_result.DataSource = list;
                dg_result.Columns[0].Visible = false;
                dg_result.Columns[1].Visible = false;
                dg_result.Columns[2].Width = 110;
                dg_result.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dg_result.Columns[4].Width = 90;
                dg_result.Columns[5].Width = 140;


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }




        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            this.Invoke(new MethodInvoker(delegate() { FillDataGridView(); }));
        }

        private void cmd_clear_Click(object sender, EventArgs e)
        {
            //Search();
            txt_search.Clear();
            txt_search.Select();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        private void cmd_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmd_search_Click(object sender, EventArgs e)
        {
            this.Close();
            SelectItem();
        }


        void SelectItem()
        {
            if (dg_result.SelectedRows.Count >= 1)
            {
                this.Close();
                Cursor.Current = Cursors.WaitCursor;
               
                   
                string papin = this.dg_result.SelectedRows[0].Cells[1].Value.ToString();
        

                fmain.Tag = papin;
                
                (Application.OpenForms["FrmPhysicalExamination"] as FrmPhysicalExamination).ClearAll();
                (Application.OpenForms["FrmPhysicalExamination"] as FrmPhysicalExamination).searchPhyExamRecord(papin);
                            

                //fmain.tsPanamaNew.Enabled = false;
                fmain.toolStripPhyExamEdit.Enabled = true;
                fmain.toolStripPhyExamDelete.Enabled = false;
                fmain.toolStripPhyExamSave.Enabled = false;
                fmain.toolStripPhyExamCancel.Enabled = false;
                fmain.toolStripPhyExamPrint.Enabled = true;             
                fmain.toolStripPhyExamPrintPreview.Enabled = true;
                fmain.toolStripPhyExamSearch.Enabled = true;



                Cursor.Current = Cursors.Default;


            }


        }

        private void dg_result_DoubleClick(object sender, EventArgs e)
        {
            SelectItem();
        }

        private void txt_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            { dg_result.Focus(); }
        }

        private void FrmSearchPanama_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            { SelectItem(); }
        }

        private void txt_search_TextChanged_1(object sender, EventArgs e)
        {
            FillDataGridView();
        }


    }
}
