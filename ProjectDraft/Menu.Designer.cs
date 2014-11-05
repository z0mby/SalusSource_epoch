namespace ProjectDraft
{
    partial class Menu
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.manualBtn = new System.Windows.Forms.Button();
            this.reportsBtn = new System.Windows.Forms.Button();
            this.scheduleBtn = new System.Windows.Forms.Button();
            this.addPatientbtn = new System.Windows.Forms.Button();
            this.patientDBbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjectDraft.Properties.Resources.salussourcelogo;
            this.pictureBox1.Location = new System.Drawing.Point(12, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(509, 155);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.exitBtn);
            this.groupBox1.Controls.Add(this.manualBtn);
            this.groupBox1.Controls.Add(this.reportsBtn);
            this.groupBox1.Controls.Add(this.scheduleBtn);
            this.groupBox1.Controls.Add(this.addPatientbtn);
            this.groupBox1.Controls.Add(this.patientDBbtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 287);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(202, 247);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 34);
            this.exitBtn.TabIndex = 13;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // manualBtn
            // 
            this.manualBtn.Location = new System.Drawing.Point(202, 116);
            this.manualBtn.Name = "manualBtn";
            this.manualBtn.Size = new System.Drawing.Size(75, 34);
            this.manualBtn.TabIndex = 12;
            this.manualBtn.Text = "Epoch Manual";
            this.manualBtn.UseVisualStyleBackColor = true;
            // 
            // reportsBtn
            // 
            this.reportsBtn.Location = new System.Drawing.Point(324, 76);
            this.reportsBtn.Name = "reportsBtn";
            this.reportsBtn.Size = new System.Drawing.Size(75, 34);
            this.reportsBtn.TabIndex = 11;
            this.reportsBtn.Text = "Generate Reports";
            this.reportsBtn.UseVisualStyleBackColor = true;
            // 
            // scheduleBtn
            // 
            this.scheduleBtn.Location = new System.Drawing.Point(243, 76);
            this.scheduleBtn.Name = "scheduleBtn";
            this.scheduleBtn.Size = new System.Drawing.Size(75, 34);
            this.scheduleBtn.TabIndex = 10;
            this.scheduleBtn.Text = "Schedule Appointment";
            this.scheduleBtn.UseVisualStyleBackColor = true;
            // 
            // addPatientbtn
            // 
            this.addPatientbtn.Location = new System.Drawing.Point(81, 76);
            this.addPatientbtn.Name = "addPatientbtn";
            this.addPatientbtn.Size = new System.Drawing.Size(75, 34);
            this.addPatientbtn.TabIndex = 9;
            this.addPatientbtn.Text = "Add Patient";
            this.addPatientbtn.UseVisualStyleBackColor = true;
            this.addPatientbtn.Click += new System.EventHandler(this.addPatientbtn_Click);
            // 
            // patientDBbtn
            // 
            this.patientDBbtn.Location = new System.Drawing.Point(162, 76);
            this.patientDBbtn.Name = "patientDBbtn";
            this.patientDBbtn.Size = new System.Drawing.Size(75, 34);
            this.patientDBbtn.TabIndex = 0;
            this.patientDBbtn.Text = "Patient Database";
            this.patientDBbtn.UseVisualStyleBackColor = true;
            this.patientDBbtn.Click += new System.EventHandler(this.patientDBbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(324, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 14;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(111, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Test2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(533, 472);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button manualBtn;
        private System.Windows.Forms.Button reportsBtn;
        private System.Windows.Forms.Button scheduleBtn;
        private System.Windows.Forms.Button addPatientbtn;
        private System.Windows.Forms.Button patientDBbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}