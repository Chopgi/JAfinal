using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Student2
{
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
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
                        !string.IsNullOrEmpty(lNameTB.Text) &&
                        !string.IsNullOrEmpty(phoneTB.Text))
                    {
                        cmd.Parameters.AddWithValue("@HospitalMR", getTrueValForSQL(hospitalMRnumTB.Text));
                        cmd.Parameters.AddWithValue("@PtLastName", getTrueValForSQL(lNameTB.Text));
                        cmd.Parameters.AddWithValue("@PtPreviousLastName", DBNull.Value);
                        cmd.Parameters.AddWithValue("@PtFirstName", getTrueValForSQL(fNameTB.Text));
                        cmd.Parameters.AddWithValue("@PtMiddleInitial", getTrueValForSQL(midInitialTB.Text));
                        cmd.Parameters.AddWithValue("@Suffix", getTrueValForSQL(suffixCB.Text));
                        cmd.Parameters.AddWithValue("@HomeAddress", getTrueValForSQL(addressTB.Text));
                        cmd.Parameters.AddWithValue("@HomeCity", getTrueValForSQL(cityTB.Text));
                        cmd.Parameters.AddWithValue("@HomeStateProvinceRegion", getTrueValForSQL(stateCB.Text));
                        cmd.Parameters.AddWithValue("@HomeZip", getTrueValForSQL(zipTB.Text));
                        cmd.Parameters.AddWithValue("@Country", getTrueValForSQL(countryTB.Text));
                        cmd.Parameters.AddWithValue("@Citizenship", getTrueValForSQL(citizenshipTB.Text));
                        cmd.Parameters.AddWithValue("@PtHomePhone", getTrueValForSQL(phoneTB.Text));
                        cmd.Parameters.AddWithValue("@EmergencyPhoneNumber", getTrueValForSQL(emergencyPhoneTB.Text));
                        cmd.Parameters.AddWithValue("@EmailAddress", getTrueValForSQL(emailTB.Text));
                        cmd.Parameters.AddWithValue("@SSN", getTrueValForSQL(ssnTB.Text));
                        cmd.Parameters.AddWithValue("@DOB", DOBpicker.Value);
                        cmd.Parameters.AddWithValue("@Gender", getTrueValForSQL(genderTB.Text));
                        cmd.Parameters.AddWithValue("@EthnicAssociation", getTrueValForSQL(ethinicityTB.Text));
                        cmd.Parameters.AddWithValue("@Religion", getTrueValForSQL(religionTB.Text));
                        cmd.Parameters.AddWithValue("@MaritalStatus", getTrueValForSQL(maritalStatTB.Text));
                        cmd.Parameters.AddWithValue("@EmploymentStatus", getTrueValForSQL(employStatTB.Text));
                        cmd.Parameters.AddWithValue("@DateofExpire", DOEpicker.Value);
                        cmd.Parameters.AddWithValue("@Referral", getTrueValForSQL(referralTB.Text));
                        cmd.Parameters.AddWithValue("@CurrentPrimaryHCPId", getTrueValForSQL(primaryHCPidTB.Text));
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
