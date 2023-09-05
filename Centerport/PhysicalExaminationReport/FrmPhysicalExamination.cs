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



    public partial class FrmPhysicalExamination : Form, MyInter
    {

        Main fmain;
        public DataClasses1DataContext db = new DataClasses1DataContext(Properties.Settings.Default.MyConString);
        public List<Panama_SeaMLC> Panama_SeaMLC_model = new List<Panama_SeaMLC>();




        public FrmPhysicalExamination(Main m)
        {
            InitializeComponent();

            fmain = m;
        }

        private void FrmPhysicalExamination_Load(object sender, EventArgs e)
        {

            int newWidth = 835;
            int newHieght = 855;
            overlayShadow1.MaximumSize = new Size(newWidth, newHieght);
            overlayShadow1.Size = new Size(newWidth, overlayShadow1.Height);
            Availability(overlayShadow1, false);




        }

        private void label27_Click(object sender, EventArgs e)
        {

        }



        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                DataClasses2DataContext d = new DataClasses2DataContext(Properties.Settings.Default.MyConString);
                var list = d.Panama_SeaMLC("%");
                Cursor.Current = Cursors.WaitCursor;
                foreach (var i in list)
                {
                    Panama_SeaMLC_model.Add(new Panama_SeaMLC
                    {
                        cn = i.cn,
                        papin = i.papin,
                        resultID = i.resultid,
                        patientName = i.PatientName,
                        resultDate = i.result_date,
                        recommendation = i.recommendation

                    });

                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
        }

        void clearFields()
        {

            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Text = String.Empty;
                }
                else if (c is CheckBox)
                {
                    ((CheckBox)c).Checked = false;
                }
                else if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }


        }
        public void ClearAll()
        {
            clearFields();
        }


        public void searchPhyExamRecord(string papin)
        {
            clearFields();


            txtPapin.Text = papin;

           

            //searchPanamaPatient();
            //searchPanamaExamineePersonalDeclaration();
            //searchPanamaDataRelatedCovid();
            //searchPanamaMedicalExamination();
            //searchPhysicalExploration();
            //searchsearchPhysicalExploration();
            //searchPanamaResultMain();
            //search_RecomendationFromSearch();


        }




        public void New()
        {
            fmain.toolStripPhyExamEdit.Enabled = false;
            fmain.toolStripPhyExamDelete.Enabled = false;
            fmain.toolStripPhyExamSave.Enabled = true;
            fmain.toolStripPhyExamCancel.Enabled = true;
            fmain.toolStripPhyExamPrint.Enabled = true;
            fmain.toolStripPhyExamSearch.Enabled = false;





        }

        public void Save()
        {
            fmain.toolStripPhyExamEdit.Enabled = true;
            fmain.toolStripPhyExamDelete.Enabled = false;
            fmain.toolStripPhyExamSave.Enabled = false;
            fmain.toolStripPhyExamCancel.Enabled = false;
            fmain.toolStripPhyExamPrint.Enabled = true;
            fmain.toolStripPhyExamSearch.Enabled = true;

            Availability(overlayShadow1, false);


        }

        public void Availability(Control overlay, bool bl)
        {

            if (bl == true)
            {
                overlay.Visible = false;
                overlay.SendToBack();
            }
            else
            {
                txtPapin.Focus();
                overlay.Visible = true;
                overlay.BringToFront();
            }

        }





        public void Edit()
        {
            if (txtPapin.Text != "")
            {
                fmain.toolStripPhyExamEdit.Enabled = false;
                fmain.toolStripPhyExamDelete.Enabled = false;
                fmain.toolStripPhyExamSave.Enabled = true;
                fmain.toolStripPhyExamCancel.Enabled = true;
                fmain.toolStripPhyExamPrint.Enabled = false;
                fmain.toolStripPhyExamSearch.Enabled = false;

                Availability(overlayShadow1, true);

            }

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Cancel()
        {
            fmain.toolStripPhyExamEdit.Enabled = true;
            fmain.toolStripPhyExamDelete.Enabled = false;
            fmain.toolStripPhyExamSave.Enabled = false;
            fmain.toolStripPhyExamCancel.Enabled = false;
            fmain.toolStripPhyExamPrint.Enabled = false;
            fmain.toolStripPhyExamSearch.Enabled = true;

            Availability(overlayShadow1, false );
        }

        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Search()
        {
            throw new NotImplementedException();
        }

        private void FrmPhysicalExamination_Enter(object sender, EventArgs e)
        {
            Panama_SeaMLC_model.Clear();
            if (!backgroundWorker1.IsBusy)
            { backgroundWorker1.RunWorkerAsync(); }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {

                if ((Application.OpenForms["FrmSearchPhyExam"] as FrmSearchPhyExam) != null)
                { (Application.OpenForms["FrmSearchPhyExam"] as FrmSearchPhyExam).FillDataGridView(); }


            }
            catch (Exception ex)
            {
                MessageBox.Show(this, string.Format("An error occured {0}", ex.Message), Properties.Settings.Default.SystemName.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Exclamation); return;

            }
        }
        public void OpenSearchList()
        {

        }


        private void FrmPhysicalExamination_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Add && e.Modifiers == Keys.Control)
            {
                OpenSearchList();
            }
            else if (e.KeyCode == Keys.P && e.Modifiers == Keys.Control)
            {
                Print();
            }
            else if (e.KeyCode == Keys.F && e.Modifiers == Keys.Control)
            {

                fmain.SearchPhysicalExam();

            }
            else if (e.KeyCode == Keys.S && e.Modifiers == Keys.Control)
            {

                Save();

            }
            else if (e.KeyCode == Keys.F4)
            {

                Edit();

            }
            else if (e.KeyCode == Keys.F5)
            {

                

            }


        }
    }
}
