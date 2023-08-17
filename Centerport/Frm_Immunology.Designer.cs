namespace MedicalManagementSoftware
{
    partial class Frm_Immunology
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dt_bday = new System.Windows.Forms.DateTimePicker();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_position = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_agency = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cmd_load1 = new System.Windows.Forms.Button();
            this.lbl_medical_cn = new System.Windows.Forms.Label();
            this.txt_LabNo = new System.Windows.Forms.TextBox();
            this.txt_PathoLogist_Lic = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_PathoLogist = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_MedTech_lic = new System.Windows.Forms.TextBox();
            this.dt_result_Date = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_MedTech = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOtherRefValue = new System.Windows.Forms.TextBox();
            this.txtOtherName = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCutOff = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtOtherResult = new System.Windows.Forms.TextBox();
            this.txtAntiHBResult = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbAntiHBReActive = new System.Windows.Forms.RadioButton();
            this.rbAntiHBNonReActive = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbHBsAGReActive = new System.Windows.Forms.RadioButton();
            this.rbHBsAGNonReActive = new System.Windows.Forms.RadioButton();
            this.txtPSA = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.overlayShadow1 = new MedicalManagementSoftware.Class.OverlayShadow();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_bday);
            this.groupBox1.Controls.Add(this.txt_gender);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_age);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_position);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_agency);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 81);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PATIENT INFORMATION";
            // 
            // dt_bday
            // 
            this.dt_bday.CustomFormat = "00/00/0000";
            this.dt_bday.Enabled = false;
            this.dt_bday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_bday.Location = new System.Drawing.Point(531, 20);
            this.dt_bday.Name = "dt_bday";
            this.dt_bday.ShowUpDown = true;
            this.dt_bday.Size = new System.Drawing.Size(114, 21);
            this.dt_bday.TabIndex = 259;
            // 
            // txt_gender
            // 
            this.txt_gender.BackColor = System.Drawing.SystemColors.Control;
            this.txt_gender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_gender.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_gender.Location = new System.Drawing.Point(774, 20);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.ReadOnly = true;
            this.txt_gender.Size = new System.Drawing.Size(96, 22);
            this.txt_gender.TabIndex = 258;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Arial", 9F);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(720, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 257;
            this.label5.Text = "Gender:";
            // 
            // txt_age
            // 
            this.txt_age.BackColor = System.Drawing.SystemColors.Control;
            this.txt_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_age.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_age.Location = new System.Drawing.Point(682, 20);
            this.txt_age.Name = "txt_age";
            this.txt_age.ReadOnly = true;
            this.txt_age.Size = new System.Drawing.Size(34, 22);
            this.txt_age.TabIndex = 256;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(649, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 15);
            this.label4.TabIndex = 255;
            this.label4.Text = "Age:";
            // 
            // txt_position
            // 
            this.txt_position.BackColor = System.Drawing.SystemColors.Control;
            this.txt_position.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_position.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_position.Location = new System.Drawing.Point(531, 46);
            this.txt_position.Name = "txt_position";
            this.txt_position.ReadOnly = true;
            this.txt_position.Size = new System.Drawing.Size(339, 22);
            this.txt_position.TabIndex = 254;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Arial", 9F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(475, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 252;
            this.label2.Text = "Position:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(467, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 251;
            this.label3.Text = "Birth date:";
            // 
            // txt_agency
            // 
            this.txt_agency.BackColor = System.Drawing.SystemColors.Control;
            this.txt_agency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_agency.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_agency.Location = new System.Drawing.Point(74, 46);
            this.txt_agency.Name = "txt_agency";
            this.txt_agency.ReadOnly = true;
            this.txt_agency.Size = new System.Drawing.Size(385, 22);
            this.txt_agency.TabIndex = 250;
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.Control;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Font = new System.Drawing.Font("Arial", 9.75F);
            this.txt_name.Location = new System.Drawing.Point(74, 20);
            this.txt_name.Name = "txt_name";
            this.txt_name.ReadOnly = true;
            this.txt_name.Size = new System.Drawing.Size(385, 22);
            this.txt_name.TabIndex = 249;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Arial", 9F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 246;
            this.label1.Text = "Agency:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.SystemColors.Control;
            this.label24.Font = new System.Drawing.Font("Arial", 9F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(24, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 15);
            this.label24.TabIndex = 245;
            this.label24.Text = "Name:";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.cmd_load1);
            this.panel3.Controls.Add(this.lbl_medical_cn);
            this.panel3.Controls.Add(this.txt_LabNo);
            this.panel3.Controls.Add(this.txt_PathoLogist_Lic);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txt_PathoLogist);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txt_MedTech_lic);
            this.panel3.Controls.Add(this.dt_result_Date);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_MedTech);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Font = new System.Drawing.Font("Arial", 9F);
            this.panel3.Location = new System.Drawing.Point(18, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(887, 60);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(856, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 297;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmd_load1
            // 
            this.cmd_load1.Location = new System.Drawing.Point(856, 3);
            this.cmd_load1.Name = "cmd_load1";
            this.cmd_load1.Size = new System.Drawing.Size(23, 23);
            this.cmd_load1.TabIndex = 296;
            this.cmd_load1.Text = "...";
            this.cmd_load1.UseVisualStyleBackColor = true;
            this.cmd_load1.Click += new System.EventHandler(this.cmd_load1_Click);
            // 
            // lbl_medical_cn
            // 
            this.lbl_medical_cn.AutoSize = true;
            this.lbl_medical_cn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medical_cn.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_medical_cn.Location = new System.Drawing.Point(373, 28);
            this.lbl_medical_cn.Name = "lbl_medical_cn";
            this.lbl_medical_cn.Size = new System.Drawing.Size(155, 25);
            this.lbl_medical_cn.TabIndex = 295;
            this.lbl_medical_cn.Text = "lbl_medical_cn";
            this.lbl_medical_cn.Visible = false;
            // 
            // txt_LabNo
            // 
            this.txt_LabNo.BackColor = System.Drawing.Color.White;
            this.txt_LabNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_LabNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LabNo.Location = new System.Drawing.Point(111, 31);
            this.txt_LabNo.Name = "txt_LabNo";
            this.txt_LabNo.Size = new System.Drawing.Size(112, 21);
            this.txt_LabNo.TabIndex = 4;
            // 
            // txt_PathoLogist_Lic
            // 
            this.txt_PathoLogist_Lic.BackColor = System.Drawing.Color.White;
            this.txt_PathoLogist_Lic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PathoLogist_Lic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PathoLogist_Lic.Location = new System.Drawing.Point(708, 31);
            this.txt_PathoLogist_Lic.Name = "txt_PathoLogist_Lic";
            this.txt_PathoLogist_Lic.Size = new System.Drawing.Size(131, 21);
            this.txt_PathoLogist_Lic.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Arial", 9F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(45, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 15);
            this.label13.TabIndex = 262;
            this.label13.Text = "LAB. NO.:";
            // 
            // txt_PathoLogist
            // 
            this.txt_PathoLogist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_PathoLogist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_PathoLogist.BackColor = System.Drawing.Color.White;
            this.txt_PathoLogist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_PathoLogist.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_PathoLogist.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PathoLogist.Location = new System.Drawing.Point(319, 31);
            this.txt_PathoLogist.Name = "txt_PathoLogist";
            this.txt_PathoLogist.Size = new System.Drawing.Size(293, 21);
            this.txt_PathoLogist.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Arial", 9F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(618, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 15);
            this.label14.TabIndex = 263;
            this.label14.Text = "LICENSE NO.:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.Control;
            this.label15.Font = new System.Drawing.Font("Arial", 9F);
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(225, 35);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 15);
            this.label15.TabIndex = 264;
            this.label15.Text = "PATHOLOGIST:";
            // 
            // txt_MedTech_lic
            // 
            this.txt_MedTech_lic.BackColor = System.Drawing.Color.White;
            this.txt_MedTech_lic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MedTech_lic.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedTech_lic.Location = new System.Drawing.Point(708, 4);
            this.txt_MedTech_lic.Name = "txt_MedTech_lic";
            this.txt_MedTech_lic.Size = new System.Drawing.Size(131, 21);
            this.txt_MedTech_lic.TabIndex = 3;
            // 
            // dt_result_Date
            // 
            this.dt_result_Date.CustomFormat = "00/00/0000";
            this.dt_result_Date.Font = new System.Drawing.Font("Arial", 9F);
            this.dt_result_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_result_Date.Location = new System.Drawing.Point(111, 5);
            this.dt_result_Date.Name = "dt_result_Date";
            this.dt_result_Date.ShowUpDown = true;
            this.dt_result_Date.Size = new System.Drawing.Size(112, 21);
            this.dt_result_Date.TabIndex = 1;
            this.dt_result_Date.ValueChanged += new System.EventHandler(this.dt_result_Date_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Arial", 9F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 15);
            this.label9.TabIndex = 255;
            this.label9.Text = "RESULT DATE:";
            // 
            // txt_MedTech
            // 
            this.txt_MedTech.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_MedTech.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_MedTech.BackColor = System.Drawing.Color.White;
            this.txt_MedTech.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_MedTech.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_MedTech.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MedTech.Location = new System.Drawing.Point(319, 4);
            this.txt_MedTech.Name = "txt_MedTech";
            this.txt_MedTech.Size = new System.Drawing.Size(293, 21);
            this.txt_MedTech.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Arial", 9F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(618, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 15);
            this.label8.TabIndex = 256;
            this.label8.Text = "LICENSE NO.:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Arial", 9F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(237, 8);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 15);
            this.label10.TabIndex = 258;
            this.label10.Text = "MED. TECH.:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.txtOtherRefValue);
            this.groupBox2.Controls.Add(this.txtOtherName);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.txtCutOff);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Controls.Add(this.txtOtherResult);
            this.groupBox2.Controls.Add(this.txtAntiHBResult);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.txtPSA);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkBlue;
            this.groupBox2.Location = new System.Drawing.Point(18, 163);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 263);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtOtherRefValue
            // 
            this.txtOtherRefValue.BackColor = System.Drawing.Color.White;
            this.txtOtherRefValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherRefValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherRefValue.Location = new System.Drawing.Point(333, 84);
            this.txtOtherRefValue.Name = "txtOtherRefValue";
            this.txtOtherRefValue.Size = new System.Drawing.Size(142, 21);
            this.txtOtherRefValue.TabIndex = 319;
            this.txtOtherRefValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOtherName
            // 
            this.txtOtherName.BackColor = System.Drawing.Color.White;
            this.txtOtherName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherName.Location = new System.Drawing.Point(140, 83);
            this.txtOtherName.Name = "txtOtherName";
            this.txtOtherName.Size = new System.Drawing.Size(142, 21);
            this.txtOtherName.TabIndex = 318;
            this.txtOtherName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.radioButton1);
            this.panel4.Controls.Add(this.radioButton2);
            this.panel4.Font = new System.Drawing.Font("Arial", 9F);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(563, 177);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 23);
            this.panel4.TabIndex = 313;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(168, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(72, 19);
            this.radioButton1.TabIndex = 312;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Reactive";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(9, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(98, 19);
            this.radioButton2.TabIndex = 311;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non Reactive";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged_1);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Control;
            this.label23.Font = new System.Drawing.Font("Arial", 9F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(363, 62);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 15);
            this.label23.TabIndex = 317;
            this.label23.Text = "< 4.0 ng/ml";
            // 
            // txtCutOff
            // 
            this.txtCutOff.Font = new System.Drawing.Font("Arial", 9F);
            this.txtCutOff.Location = new System.Drawing.Point(333, 205);
            this.txtCutOff.Name = "txtCutOff";
            this.txtCutOff.Size = new System.Drawing.Size(142, 21);
            this.txtCutOff.TabIndex = 313;
            this.txtCutOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.SystemColors.Control;
            this.label22.Font = new System.Drawing.Font("Arial", 9F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(96, 88);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 15);
            this.label22.TabIndex = 316;
            this.label22.Text = "Other :";
            // 
            // txtOtherResult
            // 
            this.txtOtherResult.BackColor = System.Drawing.Color.White;
            this.txtOtherResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOtherResult.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtherResult.Location = new System.Drawing.Point(565, 82);
            this.txtOtherResult.Name = "txtOtherResult";
            this.txtOtherResult.Size = new System.Drawing.Size(249, 21);
            this.txtOtherResult.TabIndex = 310;
            this.txtOtherResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOtherResult.TextChanged += new System.EventHandler(this.txt_tumorOther_TextChanged);
            // 
            // txtAntiHBResult
            // 
            this.txtAntiHBResult.Location = new System.Drawing.Point(564, 228);
            this.txtAntiHBResult.Name = "txtAntiHBResult";
            this.txtAntiHBResult.Size = new System.Drawing.Size(248, 21);
            this.txtAntiHBResult.TabIndex = 316;
            this.txtAntiHBResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbAntiHBReActive);
            this.panel2.Controls.Add(this.rbAntiHBNonReActive);
            this.panel2.Font = new System.Drawing.Font("Arial", 9F);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(564, 202);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(249, 23);
            this.panel2.TabIndex = 311;
            // 
            // rbAntiHBReActive
            // 
            this.rbAntiHBReActive.AutoSize = true;
            this.rbAntiHBReActive.Location = new System.Drawing.Point(168, 1);
            this.rbAntiHBReActive.Name = "rbAntiHBReActive";
            this.rbAntiHBReActive.Size = new System.Drawing.Size(72, 19);
            this.rbAntiHBReActive.TabIndex = 315;
            this.rbAntiHBReActive.TabStop = true;
            this.rbAntiHBReActive.Text = "Reactive";
            this.rbAntiHBReActive.UseVisualStyleBackColor = true;
            this.rbAntiHBReActive.CheckedChanged += new System.EventHandler(this.rbAntiHBReActive_CheckedChanged);
            // 
            // rbAntiHBNonReActive
            // 
            this.rbAntiHBNonReActive.AutoSize = true;
            this.rbAntiHBNonReActive.Location = new System.Drawing.Point(9, 1);
            this.rbAntiHBNonReActive.Name = "rbAntiHBNonReActive";
            this.rbAntiHBNonReActive.Size = new System.Drawing.Size(98, 19);
            this.rbAntiHBNonReActive.TabIndex = 314;
            this.rbAntiHBNonReActive.TabStop = true;
            this.rbAntiHBNonReActive.Text = "Non Reactive";
            this.rbAntiHBNonReActive.UseVisualStyleBackColor = true;
            this.rbAntiHBNonReActive.CheckedChanged += new System.EventHandler(this.rbAntiHBNonReActive_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.rbHBsAGReActive);
            this.panel1.Controls.Add(this.rbHBsAGNonReActive);
            this.panel1.Font = new System.Drawing.Font("Arial", 9F);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(564, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 23);
            this.panel1.TabIndex = 310;
            // 
            // rbHBsAGReActive
            // 
            this.rbHBsAGReActive.AutoSize = true;
            this.rbHBsAGReActive.Location = new System.Drawing.Point(168, 2);
            this.rbHBsAGReActive.Name = "rbHBsAGReActive";
            this.rbHBsAGReActive.Size = new System.Drawing.Size(72, 19);
            this.rbHBsAGReActive.TabIndex = 312;
            this.rbHBsAGReActive.TabStop = true;
            this.rbHBsAGReActive.Text = "Reactive";
            this.rbHBsAGReActive.UseVisualStyleBackColor = true;
            this.rbHBsAGReActive.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbHBsAGNonReActive
            // 
            this.rbHBsAGNonReActive.AutoSize = true;
            this.rbHBsAGNonReActive.Location = new System.Drawing.Point(9, 2);
            this.rbHBsAGNonReActive.Name = "rbHBsAGNonReActive";
            this.rbHBsAGNonReActive.Size = new System.Drawing.Size(98, 19);
            this.rbHBsAGNonReActive.TabIndex = 311;
            this.rbHBsAGNonReActive.TabStop = true;
            this.rbHBsAGNonReActive.Text = "Non Reactive";
            this.rbHBsAGNonReActive.UseVisualStyleBackColor = true;
            this.rbHBsAGNonReActive.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // txtPSA
            // 
            this.txtPSA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPSA.Location = new System.Drawing.Point(565, 58);
            this.txtPSA.Name = "txtPSA";
            this.txtPSA.Size = new System.Drawing.Size(248, 21);
            this.txtPSA.TabIndex = 309;
            this.txtPSA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.SystemColors.Control;
            this.label21.Font = new System.Drawing.Font("Arial", 9F);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(271, 209);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 15);
            this.label21.TabIndex = 308;
            this.label21.Text = "Cut Off:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.SystemColors.Control;
            this.label20.Font = new System.Drawing.Font("Arial", 9F);
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(96, 206);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 15);
            this.label20.TabIndex = 303;
            this.label20.Text = "Anti-HBS :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Arial", 9F);
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(96, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 15);
            this.label19.TabIndex = 302;
            this.label19.Text = "RPR :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(71, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(118, 15);
            this.label17.TabIndex = 301;
            this.label17.Text = "IMMUNOLOGY TEST";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Font = new System.Drawing.Font("Arial", 9F);
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(96, 156);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(51, 15);
            this.label18.TabIndex = 300;
            this.label18.Text = "HBsAg :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.Control;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(71, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 15);
            this.label16.TabIndex = 299;
            this.label16.Text = "TUMOR MARKER";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Arial", 9F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(96, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 298;
            this.label12.Text = "PSA :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.DarkBlue;
            this.label11.Location = new System.Drawing.Point(659, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 16);
            this.label11.TabIndex = 265;
            this.label11.Text = "RESULT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.DarkBlue;
            this.label7.Location = new System.Drawing.Point(326, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 16);
            this.label7.TabIndex = 264;
            this.label7.Text = "REFERENCE VALUES";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.DarkBlue;
            this.label6.Location = new System.Drawing.Point(100, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 263;
            this.label6.Text = "TEST";
            // 
            // overlayShadow1
            // 
            this.overlayShadow1.Location = new System.Drawing.Point(18, 99);
            this.overlayShadow1.Name = "overlayShadow1";
            this.overlayShadow1.Size = new System.Drawing.Size(887, 328);
            this.overlayShadow1.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(817, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(20, 23);
            this.button2.TabIndex = 320;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(817, 177);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(20, 23);
            this.button3.TabIndex = 321;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(817, 202);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(20, 23);
            this.button4.TabIndex = 322;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Frm_Immunology
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 445);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.overlayShadow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(938, 524);
            this.Name = "Frm_Immunology";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Immunology";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Immunology_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Immunology_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Immunology_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_bday;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_position;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_agency;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cmd_load1;
        private System.Windows.Forms.Label lbl_medical_cn;
        private System.Windows.Forms.TextBox txt_LabNo;
        private System.Windows.Forms.TextBox txt_PathoLogist_Lic;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_PathoLogist;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_MedTech_lic;
        private System.Windows.Forms.DateTimePicker dt_result_Date;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_MedTech;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbHBsAGReActive;
        private System.Windows.Forms.RadioButton rbHBsAGNonReActive;
        private System.Windows.Forms.TextBox txtPSA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbAntiHBReActive;
        private System.Windows.Forms.RadioButton rbAntiHBNonReActive;
        private System.Windows.Forms.TextBox txtAntiHBResult;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtOtherResult;
        private System.Windows.Forms.TextBox txtCutOff;
        private Class.OverlayShadow overlayShadow1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtOtherName;
        private System.Windows.Forms.TextBox txtOtherRefValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}