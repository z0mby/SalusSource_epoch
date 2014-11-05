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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addPatientbtn_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hides current form
            patientRegistration addPatient = new patientRegistration(); // creates new object from form patientRegistration
            addPatient.Show(); // Displays the addPatient form
            this.Close();
        }

        private void patientDBbtn_Click(object sender, EventArgs e)
        {
            this.Close();
            patientDatabase database = new patientDatabase();
            database.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
