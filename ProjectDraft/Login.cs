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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientManagementDataSet2.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.patientManagementDataSet2.States);
            // TODO: This line of code loads data into the 'patientManagementDataSet1.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter1.Fill(this.patientManagementDataSet1.Doctors);
            // TODO: This line of code loads data into the 'patientManagementDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.patientManagementDataSet.Doctors);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            String username = "Admin";
            String password = "1234";

            if ((userNametxtbox.Text == username) && (passWordtxtbox.Text == password))
            {
                this.Hide();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Wrong Info. Enter Again");
            }
        }
    }
}
