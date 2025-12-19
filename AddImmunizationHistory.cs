using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student2
{
    public partial class AddImmunizationHistory : Form
    {
        string currentPatIDtoPass = "-1";
        public AddImmunizationHistory(Form f, string patientID)
        {
            InitializeComponent();
            currentPatIDtoPass = patientID;
        }
        public AddImmunizationHistory()
        {
            InitializeComponent();
        }

        private void AddImmunizationHistory_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(185, 209, 234);
        }

        private void cancelBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private object getTrueValForSQL(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return DBNull.Value;
            }
            else
            {
                return value;
            }
        }

        private void saveBut_Click(object sender, EventArgs e)
        {
            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open();
                    cmd.Connection = conn;

                    cmd.CommandText = @"INSERT INTO patientdemographics(`HospitalMR#`, PtLastName, PtPreviousLastName, PtFirstName, PtMiddleInitial, Suffix, HomeAddress, HomeCity, `HomeState/Province/Region`, HomeZip, Country, Citizenship, PtHomePhone, EmergencyPhoneNumber, EmailAddress, SSN, DOB, Gender, EthnicAssociation, Religion, MaritalStatus, EmploymentStatus, DateofExpire, Referral, CurrentPrimaryHCPId, Comments, DateEntered, NextOfKinID, NextOfKinRelationshipToPatient)" + " VALUES(@HospitalMR, @PtLastName, @PtPreviousLastName, @PtFirstName, @PtMiddleInitial, @Suffix, @HomeAddress, @HomeCity, @HomeStateProvinceRegion, @HomeZip, @Country, @Citizenship, @PtHomePhone, @EmergencyPhoneNumber, @EmailAddress, @SSN, @DOB, @Gender, @EthnicAssociation, @Religion, @MaritalStatus, @EmploymentStatus, @DateofExpire, @Referral, @CurrentPrimaryHCPId, @Comments, @DateEntered, @NextOfKinID, @NextOfKinRelationshipToPatient)";
                    if (!string.IsNullOrEmpty(fNameTB.Text) &&
                        !string.IsNullOrEmpty(lNameTB.Text))
                    {
                        cmd.Parameters.AddWithValue("@PtLastName", getTrueValForSQL(lNameTB.Text));
                        cmd.Parameters.AddWithValue("@PtPreviousLastName", DBNull.Value);
                        cmd.Parameters.AddWithValue("@PtFirstName", getTrueValForSQL(fNameTB.Text));

                        cmd.Parameters.AddWithValue("@DOB", DOBpicker.Value);

                        cmd.Parameters.AddWithValue("@DateofExpire", DOEpicker.Value);
                        cmd.Parameters.AddWithValue("@Referral", getTrueValForSQL(referralTB.Text));
                        cmd.Parameters.AddWithValue("@Comments", getTrueValForSQL(commentsTB.Text));
                        cmd.Parameters.AddWithValue("@DateEntered", DateTime.Now);
                        cmd.Parameters.AddWithValue("@NextOfKinID", DBNull.Value);
                        cmd.Parameters.AddWithValue("@NextOfKinRelationshipToPatient", DBNull.Value);
                        cmd.Prepare();
                        cmd.ExecuteNonQuery();

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("First Name, Last Name, and Phone Number are required fields.");
                        return;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
        }
    }
}
