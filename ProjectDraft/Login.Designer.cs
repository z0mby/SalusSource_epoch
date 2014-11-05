namespace ProjectDraft
{
    partial class Login
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
            this.components = new System.ComponentModel.Container();
            this.patientManagementDataSet = new ProjectDraft.PatientManagementDataSet();
            this.doctorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorsTableAdapter = new ProjectDraft.PatientManagementDataSetTableAdapters.DoctorsTableAdapter();
            this.doctorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientManagementDataSet1 = new ProjectDraft.PatientManagementDataSet1();
            this.doctorsTableAdapter1 = new ProjectDraft.PatientManagementDataSet1TableAdapters.DoctorsTableAdapter();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientManagementDataSet2 = new ProjectDraft.PatientManagementDataSet2();
            this.statesTableAdapter = new ProjectDraft.PatientManagementDataSet2TableAdapters.StatesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.passWordtxtbox = new System.Windows.Forms.TextBox();
            this.userNametxtbox = new System.Windows.Forms.TextBox();
            this.passWordlbl = new System.Windows.Forms.Label();
            this.userNamelbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientManagementDataSet
            // 
            this.patientManagementDataSet.DataSetName = "PatientManagementDataSet";
            this.patientManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsBindingSource
            // 
            this.doctorsBindingSource.DataMember = "Doctors";
            this.doctorsBindingSource.DataSource = this.patientManagementDataSet;
            // 
            // doctorsTableAdapter
            // 
            this.doctorsTableAdapter.ClearBeforeFill = true;
            // 
            // doctorsBindingSource1
            // 
            this.doctorsBindingSource1.DataMember = "Doctors";
            this.doctorsBindingSource1.DataSource = this.patientManagementDataSet1;
            // 
            // patientManagementDataSet1
            // 
            this.patientManagementDataSet1.DataSetName = "PatientManagementDataSet1";
            this.patientManagementDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorsTableAdapter1
            // 
            this.doctorsTableAdapter1.ClearBeforeFill = true;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.patientManagementDataSet2;
            // 
            // patientManagementDataSet2
            // 
            this.patientManagementDataSet2.DataSetName = "PatientManagementDataSet2";
            this.patientManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginbtn);
            this.groupBox1.Controls.Add(this.passWordtxtbox);
            this.groupBox1.Controls.Add(this.userNametxtbox);
            this.groupBox1.Controls.Add(this.passWordlbl);
            this.groupBox1.Controls.Add(this.userNamelbl);
            this.groupBox1.Location = new System.Drawing.Point(68, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 176);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Login";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(166, 127);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passWordtxtbox
            // 
            this.passWordtxtbox.Location = new System.Drawing.Point(166, 62);
            this.passWordtxtbox.Name = "passWordtxtbox";
            this.passWordtxtbox.PasswordChar = '*';
            this.passWordtxtbox.Size = new System.Drawing.Size(100, 20);
            this.passWordtxtbox.TabIndex = 3;
            this.passWordtxtbox.Text = "password";
            // 
            // userNametxtbox
            // 
            this.userNametxtbox.Location = new System.Drawing.Point(166, 34);
            this.userNametxtbox.Name = "userNametxtbox";
            this.userNametxtbox.Size = new System.Drawing.Size(100, 20);
            this.userNametxtbox.TabIndex = 2;
            this.userNametxtbox.Text = "username";
            // 
            // passWordlbl
            // 
            this.passWordlbl.AutoSize = true;
            this.passWordlbl.Location = new System.Drawing.Point(62, 62);
            this.passWordlbl.Name = "passWordlbl";
            this.passWordlbl.Size = new System.Drawing.Size(53, 13);
            this.passWordlbl.TabIndex = 1;
            this.passWordlbl.Text = "Password";
            // 
            // userNamelbl
            // 
            this.userNamelbl.AutoSize = true;
            this.userNamelbl.Location = new System.Drawing.Point(59, 34);
            this.userNamelbl.Name = "userNamelbl";
            this.userNamelbl.Size = new System.Drawing.Size(55, 13);
            this.userNamelbl.TabIndex = 0;
            this.userNamelbl.Text = "Username";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectDraft.Properties.Resources.salussourcelogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 155);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(533, 472);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PatientManagementDataSet patientManagementDataSet;
        private System.Windows.Forms.BindingSource doctorsBindingSource;
        private PatientManagementDataSetTableAdapters.DoctorsTableAdapter doctorsTableAdapter;
        private PatientManagementDataSet1 patientManagementDataSet1;
        private System.Windows.Forms.BindingSource doctorsBindingSource1;
        private PatientManagementDataSet1TableAdapters.DoctorsTableAdapter doctorsTableAdapter1;
        private PatientManagementDataSet2 patientManagementDataSet2;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private PatientManagementDataSet2TableAdapters.StatesTableAdapter statesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.TextBox passWordtxtbox;
        private System.Windows.Forms.TextBox userNametxtbox;
        private System.Windows.Forms.Label passWordlbl;
        private System.Windows.Forms.Label userNamelbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

