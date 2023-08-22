namespace MedicalManagementSoftware.Report
{
    partial class FrmPanamaReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Viewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btn_page8 = new System.Windows.Forms.Button();
            this.btn_page7 = new System.Windows.Forms.Button();
            this.btn_page6 = new System.Windows.Forms.Button();
            this.btn_page2 = new System.Windows.Forms.Button();
            this.btn_page3 = new System.Windows.Forms.Button();
            this.btn_page4 = new System.Windows.Forms.Button();
            this.btn_page5 = new System.Windows.Forms.Button();
            this.btn_page1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnFirstPage = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnLastPage = new System.Windows.Forms.Button();
            this.lblLoading = new System.Windows.Forms.Label();
            this.cmdPrint = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Viewer1
            // 
            this.Viewer1.ActiveViewIndex = -1;
            this.Viewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Viewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Viewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.Viewer1.DisplayStatusBar = false;
            this.Viewer1.Location = new System.Drawing.Point(7, -2);
            this.Viewer1.Name = "Viewer1";
            this.Viewer1.ShowCloseButton = false;
            this.Viewer1.ShowLogo = false;
            this.Viewer1.Size = new System.Drawing.Size(857, 644);
            this.Viewer1.TabIndex = 1;
            this.Viewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btn_page8
            // 
            this.btn_page8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_page8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_page8.Location = new System.Drawing.Point(318, 3);
            this.btn_page8.Name = "btn_page8";
            this.btn_page8.Size = new System.Drawing.Size(29, 30);
            this.btn_page8.TabIndex = 37;
            this.btn_page8.Text = "8";
            this.btn_page8.UseVisualStyleBackColor = true;
            this.btn_page8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn_page7
            // 
            this.btn_page7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_page7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_page7.Location = new System.Drawing.Point(283, 3);
            this.btn_page7.Name = "btn_page7";
            this.btn_page7.Size = new System.Drawing.Size(29, 30);
            this.btn_page7.TabIndex = 36;
            this.btn_page7.Text = "7";
            this.btn_page7.UseVisualStyleBackColor = true;
            this.btn_page7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn_page6
            // 
            this.btn_page6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_page6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_page6.Location = new System.Drawing.Point(248, 3);
            this.btn_page6.Name = "btn_page6";
            this.btn_page6.Size = new System.Drawing.Size(29, 30);
            this.btn_page6.TabIndex = 35;
            this.btn_page6.Text = "6";
            this.btn_page6.UseVisualStyleBackColor = true;
            this.btn_page6.Click += new System.EventHandler(this.btn_page6_Click);
            // 
            // btn_page2
            // 
            this.btn_page2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_page2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_page2.Location = new System.Drawing.Point(108, 3);
            this.btn_page2.Name = "btn_page2";
            this.btn_page2.Size = new System.Drawing.Size(29, 30);
            this.btn_page2.TabIndex = 34;
            this.btn_page2.Text = "2";
            this.btn_page2.UseVisualStyleBackColor = true;
            this.btn_page2.Click += new System.EventHandler(this.btn_page2_Click);
            // 
            // btn_page3
            // 
            this.btn_page3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_page3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_page3.Location = new System.Drawing.Point(143, 3);
            this.btn_page3.Name = "btn_page3";
            this.btn_page3.Size = new System.Drawing.Size(29, 30);
            this.btn_page3.TabIndex = 33;
            this.btn_page3.Text = "3";
            this.btn_page3.UseVisualStyleBackColor = true;
            this.btn_page3.Click += new System.EventHandler(this.btn_page3_Click);
            // 
            // btn_page4
            // 
            this.btn_page4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_page4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_page4.Location = new System.Drawing.Point(178, 3);
            this.btn_page4.Name = "btn_page4";
            this.btn_page4.Size = new System.Drawing.Size(29, 30);
            this.btn_page4.TabIndex = 32;
            this.btn_page4.Text = "4";
            this.btn_page4.UseVisualStyleBackColor = true;
            this.btn_page4.Click += new System.EventHandler(this.btn_page4_Click);
            // 
            // btn_page5
            // 
            this.btn_page5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_page5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_page5.Location = new System.Drawing.Point(213, 3);
            this.btn_page5.Name = "btn_page5";
            this.btn_page5.Size = new System.Drawing.Size(29, 30);
            this.btn_page5.TabIndex = 31;
            this.btn_page5.Text = "5";
            this.btn_page5.UseVisualStyleBackColor = true;
            this.btn_page5.Click += new System.EventHandler(this.btn_page5_Click);
            // 
            // btn_page1
            // 
            this.btn_page1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btn_page1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_page1.Location = new System.Drawing.Point(73, 3);
            this.btn_page1.Name = "btn_page1";
            this.btn_page1.Size = new System.Drawing.Size(29, 30);
            this.btn_page1.TabIndex = 30;
            this.btn_page1.Text = "1";
            this.btn_page1.UseVisualStyleBackColor = true;
            this.btn_page1.Click += new System.EventHandler(this.btn_page1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(768, 660);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnFirstPage
            // 
            this.btnFirstPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnFirstPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFirstPage.Location = new System.Drawing.Point(3, 3);
            this.btnFirstPage.Name = "btnFirstPage";
            this.btnFirstPage.Size = new System.Drawing.Size(29, 30);
            this.btnFirstPage.TabIndex = 0;
            this.btnFirstPage.Text = "|<";
            this.btnFirstPage.UseVisualStyleBackColor = true;
            this.btnFirstPage.Click += new System.EventHandler(this.btnFirstPage_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Location = new System.Drawing.Point(38, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 30);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnForward.Location = new System.Drawing.Point(353, 3);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(29, 30);
            this.btnForward.TabIndex = 2;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnLastPage
            // 
            this.btnLastPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnLastPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLastPage.Location = new System.Drawing.Point(388, 3);
            this.btnLastPage.Name = "btnLastPage";
            this.btnLastPage.Size = new System.Drawing.Size(29, 30);
            this.btnLastPage.TabIndex = 3;
            this.btnLastPage.Text = ">|";
            this.btnLastPage.UseVisualStyleBackColor = true;
            this.btnLastPage.Click += new System.EventHandler(this.btnLastPage_Click);
            // 
            // lblLoading
            // 
            this.lblLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblLoading.Location = new System.Drawing.Point(375, 308);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(93, 24);
            this.lblLoading.TabIndex = 39;
            this.lblLoading.Text = "Loading...";
            this.lblLoading.Visible = false;
            // 
            // cmdPrint
            // 
            this.cmdPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdPrint.Location = new System.Drawing.Point(7, 660);
            this.cmdPrint.Name = "cmdPrint";
            this.cmdPrint.Size = new System.Drawing.Size(95, 30);
            this.cmdPrint.TabIndex = 40;
            this.cmdPrint.Text = "Print";
            this.cmdPrint.UseVisualStyleBackColor = true;
            this.cmdPrint.Click += new System.EventHandler(this.cmdPrint_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnFirstPage);
            this.flowLayoutPanel1.Controls.Add(this.btnBack);
            this.flowLayoutPanel1.Controls.Add(this.btn_page1);
            this.flowLayoutPanel1.Controls.Add(this.btn_page2);
            this.flowLayoutPanel1.Controls.Add(this.btn_page3);
            this.flowLayoutPanel1.Controls.Add(this.btn_page4);
            this.flowLayoutPanel1.Controls.Add(this.btn_page5);
            this.flowLayoutPanel1.Controls.Add(this.btn_page6);
            this.flowLayoutPanel1.Controls.Add(this.btn_page7);
            this.flowLayoutPanel1.Controls.Add(this.btn_page8);
            this.flowLayoutPanel1.Controls.Add(this.btnForward);
            this.flowLayoutPanel1.Controls.Add(this.btnLastPage);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(224, 657);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(422, 36);
            this.flowLayoutPanel1.TabIndex = 41;
            // 
            // FrmPanamaReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 702);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.cmdPrint);
            this.Controls.Add(this.lblLoading);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Viewer1);
            this.Name = "FrmPanamaReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panama Report";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmPanamaReport_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer Viewer1;
        private System.Windows.Forms.Button btn_page8;
        private System.Windows.Forms.Button btn_page7;
        private System.Windows.Forms.Button btn_page6;
        private System.Windows.Forms.Button btn_page2;
        private System.Windows.Forms.Button btn_page3;
        private System.Windows.Forms.Button btn_page4;
        private System.Windows.Forms.Button btn_page5;
        private System.Windows.Forms.Button btn_page1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnFirstPage;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnLastPage;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Button cmdPrint;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}