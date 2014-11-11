using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectDraft
{
    public partial class patientRegistration : Form
    {
        public patientRegistration()
        {
            InitializeComponent();
        }

        private void patientRegistration_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'patientManagementDataSet4.InsuranceProviders' table. You can move, or remove it, as needed.
            this.insuranceProvidersTableAdapter1.Fill(this.patientManagementDataSet4.InsuranceProviders);
            // TODO: This line of code loads data into the 'patientManagementDataSet3.InsuranceProviders' table. You can move, or remove it, as needed.
           // this.insuranceProvidersTableAdapter.Fill(this.patientManagementDataSet3.InsuranceProviders);
            // TODO: This line of code loads data into the 'patientManagementDataSet2.States' table. You can move, or remove it, as needed.
            this.statesTableAdapter.Fill(this.patientManagementDataSet2.States);
            // TODO: This line of code loads data into the 'patientManagementDataSet.Doctors' table. You can move, or remove it, as needed.
            this.doctorsTableAdapter.Fill(this.patientManagementDataSet.Doctors);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            firstNametxt.Clear();
            lastNametxt.Clear();
            middleNametxt.Clear();
            sextxt.Clear();
            ssntxt.Clear();
            maritaltxt.Clear();
            birthdDatetxt.Clear();
            addresstxt.Clear();
            phonetxt.Clear();
            citytxt.Clear();
            ziptxt.Clear();
            emailtxt.Clear();
            languagetxt.Clear();
            addInfoRichtxt.Clear();
        }

        private void firstNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String firstName = null;
            String lastName = null;
            String middleName = null;
            String sex = null;
            String ssn = null;
            String maritalStatus = null;
            String birthDate = null;
            String address = null;
            String phoneNumber = null;
            String city = null;
            String state = null;
            String zip = null;
            String email = null;
            String doctor = null;
            String language = null;
            String appointmentDate = null;
            String insuranceProvider = null;
            String drugAllergies = null;
            String additionalInfo = null;

            // Connection String
            String sSQLlTabel = "dbo.PatientManagement";
            string sSQLConnectionString = "Data Source=JUSTINCOOPER\\SQLEXPRESS;Initial Catalog=PatientManagement;Integrated Security=True";
            SqlConnection SqlConn = new SqlConnection(sSQLConnectionString);


            // Grabbing data from user 
            firstName = firstNametxt.Text;
            lastName = lastNametxt.Text;
            // testing that the value is grabbed
            MessageBox.Show(firstName);
        }
    }
}
