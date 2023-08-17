namespace MedicalManagementSoftware
{
    partial class frm_camera
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
            this.cmd_capture = new System.Windows.Forms.Button();
            this.cmd_reset = new System.Windows.Forms.Button();
            this.cmd_save = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imgVideo = new System.Windows.Forms.PictureBox();
            this.imgCapture = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_capture
            // 
            this.cmd_capture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_capture.Enabled = false;
            this.cmd_capture.Location = new System.Drawing.Point(75, 3);
            this.cmd_capture.Name = "cmd_capture";
            this.cmd_capture.Size = new System.Drawing.Size(66, 23);
            this.cmd_capture.TabIndex = 1;
            this.cmd_capture.Text = "Capture";
            this.cmd_capture.UseVisualStyleBackColor = true;
            this.cmd_capture.Click += new System.EventHandler(this.cmd_capture_Click);
            // 
            // cmd_reset
            // 
            this.cmd_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_reset.Enabled = false;
            this.cmd_reset.Location = new System.Drawing.Point(147, 3);
            this.cmd_reset.Name = "cmd_reset";
            this.cmd_reset.Size = new System.Drawing.Size(66, 23);
            this.cmd_reset.TabIndex = 2;
            this.cmd_reset.Text = "Reset";
            this.cmd_reset.UseVisualStyleBackColor = true;
            this.cmd_reset.Click += new System.EventHandler(this.cmd_reset_Click);
            // 
            // cmd_save
            // 
            this.cmd_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_save.Enabled = false;
            this.cmd_save.Location = new System.Drawing.Point(3, 3);
            this.cmd_save.Name = "cmd_save";
            this.cmd_save.Size = new System.Drawing.Size(66, 23);
            this.cmd_save.TabIndex = 3;
            this.cmd_save.Text = "&OK";
            this.cmd_save.UseVisualStyleBackColor = true;
            this.cmd_save.Click += new System.EventHandler(this.cmd_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imgVideo
            // 
            this.imgVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgVideo.Location = new System.Drawing.Point(3, 3);
            this.imgVideo.Name = "imgVideo";
            this.imgVideo.Size = new System.Drawing.Size(333, 287);
            this.imgVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imgVideo.TabIndex = 0;
            this.imgVideo.TabStop = false;
            // 
            // imgCapture
            // 
            this.imgCapture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgCapture.Location = new System.Drawing.Point(3, 3);
            this.imgCapture.Name = "imgCapture";
            this.imgCapture.Size = new System.Drawing.Size(333, 287);
            this.imgCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCapture.TabIndex = 4;
            this.imgCapture.TabStop = false;
            this.imgCapture.Visible = false;
            this.imgCapture.Paint += new System.Windows.Forms.PaintEventHandler(this.imgCapture_Paint);
            this.imgCapture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.imgCapture_MouseDown);
            this.imgCapture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.imgCapture_MouseMove);
            this.imgCapture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.imgCapture_MouseUp);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.cmd_save);
            this.flowLayoutPanel1.Controls.Add(this.cmd_capture);
            this.flowLayoutPanel1.Controls.Add(this.cmd_reset);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(57, 292);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 30);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(29, 368);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(270, 21);
            this.cboCamera.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button2_Click);
            // 
            // frm_camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(339, 407);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.imgVideo);
            this.Controls.Add(this.imgCapture);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_camera";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Capture Image";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_camera_FormClosing);
            this.Load += new System.EventHandler(this.frm_camera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCapture)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgVideo;
        private System.Windows.Forms.Button cmd_capture;
        private System.Windows.Forms.Button cmd_reset;
        private System.Windows.Forms.Button cmd_save;
        private System.Windows.Forms.PictureBox imgCapture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Button button1;
    }
}