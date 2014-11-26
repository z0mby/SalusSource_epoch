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
        private string drugA;
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
            String appointmentDate = "test";
            String insuranceProvider = null;
            String drugAllergies = null;
            String additionalInfo = null;
            String emFirstName = null;
            String emLastName = null;
            String emPhone = null;
            String emAddress = null;
            String emState = null;
            String emZip = null;

            // Connection String
            String sSQLTable = "dbo.PatientMaster";
            string sSQLConnectionString = "Data Source=JUSTINCOOPER\\SQLEXPRESS;Initial Catalog=PatientManagement;Integrated Security=True";
            SqlConnection SqlConn = new SqlConnection(sSQLConnectionString);


            // Grabbing data from user 
            firstName = firstNametxt.Text;
            lastName = lastNametxt.Text;
            middleName = middleNametxt.Text;
            sex = sextxt.Text;
            ssn = ssntxt.Text;
            maritalStatus = maritaltxt.Text;
            birthDate = birthdDatetxt.Text;
            address = addresstxt.Text;
            phoneNumber = phonetxt.Text;
            city = citytxt.Text;
            state = stateComboBox.SelectedValue.ToString();
            zip = ziptxt.Text;
            email = emailtxt.Text;
            doctor = doctorComboBox.SelectedValue.ToString();
            language = languagetxt.Text;
            // pseudo for calendar.getDate.toString
            insuranceProvider = insuranceComboBox.SelectedValue.ToString();
            drugAllergies = allergiestxt.Text;
            additionalInfo = addInfoRichtxt.Text;
            emFirstName = emFirstNametxt.Text;
            emLastName = emLastNametxt.Text;
            emPhone = emPhonetxt.Text;
            emAddress = emAddresstxt.Text;
            emState = emStatecomboBox.SelectedValue.ToString();
            emZip = emZiptxt.Text;



                SqlConn.Open();

                String sInsertSQL = null;
                sInsertSQL = "INSERT INTO " + sSQLTable + " (patientFirstName, patientLastName, patientMiddleName, patientBirthDate, patientPhoneNumber, patientState, patientStAddress, patientEmail, patientPhys, patientApptDate, patientInfo, patientSSN, patientEmFirstName, patientEmLastName, patientEmPhoneNumber, patientEmStAddress, patientInsurance, patientSex, patientMaritalStatus, patientDrugAllergies, patientLanguage, patientEmState, patientZip, patientEmZip  " + " ) VALUES ('" + firstName + "','" + lastName + "','" + middleName + "','" + birthDate + "','" + phoneNumber + "','" + state + "','" + address + "','" + email + "','" + doctor + "','" + appointmentDate + "','" + additionalInfo + "','" + ssn + "','" + emFirstName + "','" + emLastName + "','" + emPhone + "','" + emAddress + "','" + insuranceProvider + "','" + sex + "','" + maritalStatus + "','" + drugAllergies + "','" + language + "','" + emState + "','" + zip + "','" + emZip + "')";

                SqlCommand SqlInsertCmd = new SqlCommand(sInsertSQL, SqlConn);

                SqlInsertCmd.ExecuteNonQuery();

                SqlConn.Close();



                

                this.Close();
                MessageBox.Show("Success!");
                Menu menu = new Menu();
                menu.Show();

            
            
            


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
