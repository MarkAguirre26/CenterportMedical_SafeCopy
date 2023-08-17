namespace MedicalManagementSoftware
{
    partial class frm_VisitDetail
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
            this.cmd_ok = new System.Windows.Forms.Button();
            this.cmd_cancel = new System.Windows.Forms.Button();
            this.txtPorpose = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_ok
            // 
            this.cmd_ok.Location = new System.Drawing.Point(166, 101);
            this.cmd_ok.Name = "cmd_ok";
            this.cmd_ok.Size = new System.Drawing.Size(156, 37);
            this.cmd_ok.TabIndex = 3;
            this.cmd_ok.Text = "&OK";
            this.cmd_ok.UseVisualStyleBackColor = true;
            this.cmd_ok.Click += new System.EventHandler(this.cmd_ok_Click);
            // 
            // cmd_cancel
            // 
            this.cmd_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_cancel.Location = new System.Drawing.Point(328, 101);
            this.cmd_cancel.Name = "cmd_cancel";
            this.cmd_cancel.Size = new System.Drawing.Size(156, 37);
            this.cmd_cancel.TabIndex = 4;
            this.cmd_cancel.Text = "&Cancel";
            this.cmd_cancel.UseVisualStyleBackColor = true;
            this.cmd_cancel.Click += new System.EventHandler(this.cmd_cancel_Click);
            // 
            // txtPorpose
            // 
            this.txtPorpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPorpose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorpose.Location = new System.Drawing.Point(34, 51);
            this.txtPorpose.Multiline = true;
            this.txtPorpose.Name = "txtPorpose";
            this.txtPorpose.Size = new System.Drawing.Size(483, 35);
            this.txtPorpose.TabIndex = 303;
            this.txtPorpose.TabStop = false;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(31, 30);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(100, 15);
            this.label27.TabIndex = 302;
            this.label27.Text = "Purpose of Visit:";
            // 
            // frm_VisitDetail
            // 
            this.AcceptButton = this.cmd_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmd_cancel;
            this.ClientSize = new System.Drawing.Size(561, 154);
            this.ControlBox = false;
            this.Controls.Add(this.txtPorpose);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.cmd_cancel);
            this.Controls.Add(this.cmd_ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_VisitDetail";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient Visit Details";
            this.Load += new System.EventHandler(this.frm_VisitDetail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_ok;
        private System.Windows.Forms.Button cmd_cancel;
        public System.Windows.Forms.TextBox txtPorpose;
        private System.Windows.Forms.Label label27;
    }
}