namespace ProjectDraft
{
    partial class patientDatabase
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
            this.patientManagementDataSet5 = new ProjectDraft.PatientManagementDataSet5();
            this.patientMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientMasterTableAdapter = new ProjectDraft.PatientManagementDataSet5TableAdapters.PatientMasterTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.patientManagementDataSet6 = new ProjectDraft.PatientManagementDataSet6();
            this.patientMasterBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientMasterTableAdapter1 = new ProjectDraft.PatientManagementDataSet6TableAdapters.PatientMasterTableAdapter();
            this.recIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientMiddleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBirthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientStAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientPhysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientApptDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSSNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmFirstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmLastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmPhoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmStAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientInsuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientSexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientMaritalStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDrugAllergiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientLanguageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientEmZipDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMasterBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // patientManagementDataSet5
            // 
            this.patientManagementDataSet5.DataSetName = "PatientManagementDataSet5";
            this.patientManagementDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientMasterBindingSource
            // 
            this.patientMasterBindingSource.DataMember = "PatientMaster";
            this.patientMasterBindingSource.DataSource = this.patientManagementDataSet5;
            // 
            // patientMasterTableAdapter
            // 
            this.patientMasterTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(262, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(222, 237);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Submit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(125, 318);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(305, 318);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Back";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Patient Database";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.recIDDataGridViewTextBoxColumn,
            this.patientFirstNameDataGridViewTextBoxColumn,
            this.patientLastNameDataGridViewTextBoxColumn,
            this.patientMiddleNameDataGridViewTextBoxColumn,
            this.patientBirthDateDataGridViewTextBoxColumn,
            this.patientPhoneNumberDataGridViewTextBoxColumn,
            this.patientStateDataGridViewTextBoxColumn,
            this.patientStAddressDataGridViewTextBoxColumn,
            this.patientEmailDataGridViewTextBoxColumn,
            this.patientPhysDataGridViewTextBoxColumn,
            this.patientApptDateDataGridViewTextBoxColumn,
            this.patientInfoDataGridViewTextBoxColumn,
            this.patientSSNDataGridViewTextBoxColumn,
            this.patientEmFirstNameDataGridViewTextBoxColumn,
            this.patientEmLastNameDataGridViewTextBoxColumn,
            this.patientEmPhoneNumberDataGridViewTextBoxColumn,
            this.patientEmStAddressDataGridViewTextBoxColumn,
            this.patientInsuranceDataGridViewTextBoxColumn,
            this.patientSexDataGridViewTextBoxColumn,
            this.patientMaritalStatusDataGridViewTextBoxColumn,
            this.patientDrugAllergiesDataGridViewTextBoxColumn,
            this.patientLanguageDataGridViewTextBoxColumn,
            this.patientEmStateDataGridViewTextBoxColumn,
            this.patientZipDataGridViewTextBoxColumn,
            this.patientEmZipDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientMasterBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(13, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // patientManagementDataSet6
            // 
            this.patientManagementDataSet6.DataSetName = "PatientManagementDataSet6";
            this.patientManagementDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientMasterBindingSource1
            // 
            this.patientMasterBindingSource1.DataMember = "PatientMaster";
            this.patientMasterBindingSource1.DataSource = this.patientManagementDataSet6;
            // 
            // patientMasterTableAdapter1
            // 
            this.patientMasterTableAdapter1.ClearBeforeFill = true;
            // 
            // recIDDataGridViewTextBoxColumn
            // 
            this.recIDDataGridViewTextBoxColumn.DataPropertyName = "recID";
            this.recIDDataGridViewTextBoxColumn.HeaderText = "recID";
            this.recIDDataGridViewTextBoxColumn.Name = "recIDDataGridViewTextBoxColumn";
            this.recIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientFirstNameDataGridViewTextBoxColumn
            // 
            this.patientFirstNameDataGridViewTextBoxColumn.DataPropertyName = "patientFirstName";
            this.patientFirstNameDataGridViewTextBoxColumn.HeaderText = "patientFirstName";
            this.patientFirstNameDataGridViewTextBoxColumn.Name = "patientFirstNameDataGridViewTextBoxColumn";
            // 
            // patientLastNameDataGridViewTextBoxColumn
            // 
            this.patientLastNameDataGridViewTextBoxColumn.DataPropertyName = "patientLastName";
            this.patientLastNameDataGridViewTextBoxColumn.HeaderText = "patientLastName";
            this.patientLastNameDataGridViewTextBoxColumn.Name = "patientLastNameDataGridViewTextBoxColumn";
            // 
            // patientMiddleNameDataGridViewTextBoxColumn
            // 
            this.patientMiddleNameDataGridViewTextBoxColumn.DataPropertyName = "patientMiddleName";
            this.patientMiddleNameDataGridViewTextBoxColumn.HeaderText = "patientMiddleName";
            this.patientMiddleNameDataGridViewTextBoxColumn.Name = "patientMiddleNameDataGridViewTextBoxColumn";
            // 
            // patientBirthDateDataGridViewTextBoxColumn
            // 
            this.patientBirthDateDataGridViewTextBoxColumn.DataPropertyName = "patientBirthDate";
            this.patientBirthDateDataGridViewTextBoxColumn.HeaderText = "patientBirthDate";
            this.patientBirthDateDataGridViewTextBoxColumn.Name = "patientBirthDateDataGridViewTextBoxColumn";
            // 
            // patientPhoneNumberDataGridViewTextBoxColumn
            // 
            this.patientPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "patientPhoneNumber";
            this.patientPhoneNumberDataGridViewTextBoxColumn.HeaderText = "patientPhoneNumber";
            this.patientPhoneNumberDataGridViewTextBoxColumn.Name = "patientPhoneNumberDataGridViewTextBoxColumn";
            // 
            // patientStateDataGridViewTextBoxColumn
            // 
            this.patientStateDataGridViewTextBoxColumn.DataPropertyName = "patientState";
            this.patientStateDataGridViewTextBoxColumn.HeaderText = "patientState";
            this.patientStateDataGridViewTextBoxColumn.Name = "patientStateDataGridViewTextBoxColumn";
            // 
            // patientStAddressDataGridViewTextBoxColumn
            // 
            this.patientStAddressDataGridViewTextBoxColumn.DataPropertyName = "patientStAddress";
            this.patientStAddressDataGridViewTextBoxColumn.HeaderText = "patientStAddress";
            this.patientStAddressDataGridViewTextBoxColumn.Name = "patientStAddressDataGridViewTextBoxColumn";
            // 
            // patientEmailDataGridViewTextBoxColumn
            // 
            this.patientEmailDataGridViewTextBoxColumn.DataPropertyName = "patientEmail";
            this.patientEmailDataGridViewTextBoxColumn.HeaderText = "patientEmail";
            this.patientEmailDataGridViewTextBoxColumn.Name = "patientEmailDataGridViewTextBoxColumn";
            // 
            // patientPhysDataGridViewTextBoxColumn
            // 
            this.patientPhysDataGridViewTextBoxColumn.DataPropertyName = "patientPhys";
            this.patientPhysDataGridViewTextBoxColumn.HeaderText = "patientPhys";
            this.patientPhysDataGridViewTextBoxColumn.Name = "patientPhysDataGridViewTextBoxColumn";
            // 
            // patientApptDateDataGridViewTextBoxColumn
            // 
            this.patientApptDateDataGridViewTextBoxColumn.DataPropertyName = "patientApptDate";
            this.patientApptDateDataGridViewTextBoxColumn.HeaderText = "patientApptDate";
            this.patientApptDateDataGridViewTextBoxColumn.Name = "patientApptDateDataGridViewTextBoxColumn";
            // 
            // patientInfoDataGridViewTextBoxColumn
            // 
            this.patientInfoDataGridViewTextBoxColumn.DataPropertyName = "patientInfo";
            this.patientInfoDataGridViewTextBoxColumn.HeaderText = "patientInfo";
            this.patientInfoDataGridViewTextBoxColumn.Name = "patientInfoDataGridViewTextBoxColumn";
            // 
            // patientSSNDataGridViewTextBoxColumn
            // 
            this.patientSSNDataGridViewTextBoxColumn.DataPropertyName = "patientSSN";
            this.patientSSNDataGridViewTextBoxColumn.HeaderText = "patientSSN";
            this.patientSSNDataGridViewTextBoxColumn.Name = "patientSSNDataGridViewTextBoxColumn";
            // 
            // patientEmFirstNameDataGridViewTextBoxColumn
            // 
            this.patientEmFirstNameDataGridViewTextBoxColumn.DataPropertyName = "patientEmFirstName";
            this.patientEmFirstNameDataGridViewTextBoxColumn.HeaderText = "patientEmFirstName";
            this.patientEmFirstNameDataGridViewTextBoxColumn.Name = "patientEmFirstNameDataGridViewTextBoxColumn";
            // 
            // patientEmLastNameDataGridViewTextBoxColumn
            // 
            this.patientEmLastNameDataGridViewTextBoxColumn.DataPropertyName = "patientEmLastName";
            this.patientEmLastNameDataGridViewTextBoxColumn.HeaderText = "patientEmLastName";
            this.patientEmLastNameDataGridViewTextBoxColumn.Name = "patientEmLastNameDataGridViewTextBoxColumn";
            // 
            // patientEmPhoneNumberDataGridViewTextBoxColumn
            // 
            this.patientEmPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "patientEmPhoneNumber";
            this.patientEmPhoneNumberDataGridViewTextBoxColumn.HeaderText = "patientEmPhoneNumber";
            this.patientEmPhoneNumberDataGridViewTextBoxColumn.Name = "patientEmPhoneNumberDataGridViewTextBoxColumn";
            // 
            // patientEmStAddressDataGridViewTextBoxColumn
            // 
            this.patientEmStAddressDataGridViewTextBoxColumn.DataPropertyName = "patientEmStAddress";
            this.patientEmStAddressDataGridViewTextBoxColumn.HeaderText = "patientEmStAddress";
            this.patientEmStAddressDataGridViewTextBoxColumn.Name = "patientEmStAddressDataGridViewTextBoxColumn";
            // 
            // patientInsuranceDataGridViewTextBoxColumn
            // 
            this.patientInsuranceDataGridViewTextBoxColumn.DataPropertyName = "patientInsurance";
            this.patientInsuranceDataGridViewTextBoxColumn.HeaderText = "patientInsurance";
            this.patientInsuranceDataGridViewTextBoxColumn.Name = "patientInsuranceDataGridViewTextBoxColumn";
            // 
            // patientSexDataGridViewTextBoxColumn
            // 
            this.patientSexDataGridViewTextBoxColumn.DataPropertyName = "patientSex";
            this.patientSexDataGridViewTextBoxColumn.HeaderText = "patientSex";
            this.patientSexDataGridViewTextBoxColumn.Name = "patientSexDataGridViewTextBoxColumn";
            // 
            // patientMaritalStatusDataGridViewTextBoxColumn
            // 
            this.patientMaritalStatusDataGridViewTextBoxColumn.DataPropertyName = "patientMaritalStatus";
            this.patientMaritalStatusDataGridViewTextBoxColumn.HeaderText = "patientMaritalStatus";
            this.patientMaritalStatusDataGridViewTextBoxColumn.Name = "patientMaritalStatusDataGridViewTextBoxColumn";
            // 
            // patientDrugAllergiesDataGridViewTextBoxColumn
            // 
            this.patientDrugAllergiesDataGridViewTextBoxColumn.DataPropertyName = "patientDrugAllergies";
            this.patientDrugAllergiesDataGridViewTextBoxColumn.HeaderText = "patientDrugAllergies";
            this.patientDrugAllergiesDataGridViewTextBoxColumn.Name = "patientDrugAllergiesDataGridViewTextBoxColumn";
            // 
            // patientLanguageDataGridViewTextBoxColumn
            // 
            this.patientLanguageDataGridViewTextBoxColumn.DataPropertyName = "patientLanguage";
            this.patientLanguageDataGridViewTextBoxColumn.HeaderText = "patientLanguage";
            this.patientLanguageDataGridViewTextBoxColumn.Name = "patientLanguageDataGridViewTextBoxColumn";
            // 
            // patientEmStateDataGridViewTextBoxColumn
            // 
            this.patientEmStateDataGridViewTextBoxColumn.DataPropertyName = "patientEmState";
            this.patientEmStateDataGridViewTextBoxColumn.HeaderText = "patientEmState";
            this.patientEmStateDataGridViewTextBoxColumn.Name = "patientEmStateDataGridViewTextBoxColumn";
            // 
            // patientZipDataGridViewTextBoxColumn
            // 
            this.patientZipDataGridViewTextBoxColumn.DataPropertyName = "patientZip";
            this.patientZipDataGridViewTextBoxColumn.HeaderText = "patientZip";
            this.patientZipDataGridViewTextBoxColumn.Name = "patientZipDataGridViewTextBoxColumn";
            // 
            // patientEmZipDataGridViewTextBoxColumn
            // 
            this.patientEmZipDataGridViewTextBoxColumn.DataPropertyName = "patientEmZip";
            this.patientEmZipDataGridViewTextBoxColumn.HeaderText = "patientEmZip";
            this.patientEmZipDataGridViewTextBoxColumn.Name = "patientEmZipDataGridViewTextBoxColumn";
            // 
            // patientDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 356);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "patientDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "patientDatabase";
            this.Load += new System.EventHandler(this.patientDatabase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientManagementDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientMasterBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PatientManagementDataSet5 patientManagementDataSet5;
        private System.Windows.Forms.BindingSource patientMasterBindingSource;
        private PatientManagementDataSet5TableAdapters.PatientMasterTableAdapter patientMasterTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PatientManagementDataSet6 patientManagementDataSet6;
        private System.Windows.Forms.BindingSource patientMasterBindingSource1;
        private PatientManagementDataSet6TableAdapters.PatientMasterTableAdapter patientMasterTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientMiddleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientBirthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientStAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientPhysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientApptDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSSNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmFirstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmLastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmPhoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmStAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientInsuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientSexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientMaritalStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDrugAllergiesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientLanguageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientZipDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientEmZipDataGridViewTextBoxColumn;

    }
}