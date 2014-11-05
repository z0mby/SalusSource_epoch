using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectDraft
{
    public partial class patientDatabase : Form
    {
        public patientDatabase()
        {
            InitializeComponent();
        }

        private void patientDatabase_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientManagementDataSet5.PatientMaster' table. You can move, or remove it, as needed.
            this.patientMasterTableAdapter.Fill(this.patientManagementDataSet5.PatientMaster);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.patientMasterTableAdapter.FillBy(this.patientManagementDataSet5.PatientMaster);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
