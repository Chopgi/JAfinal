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
    public partial class AddMedicationHistory : Form
    {
        public AddMedicationHistory()
        {
            InitializeComponent();
        }

        private void AddMedicationHistory_Load(object sender, EventArgs e)
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

                    cmd.CommandText = "INSERT INTO patientmedications(PatientID, Medication, MedicationAmt, MedicationUnit, Instructions, MedicationStartDate, MedicationEndDate, PrescriptionHCP)" + " VALUES(" + SharedMethods.CurrentPatientID + ", @Medication, @MedicationAmt, @MedicationUnit, @Instructions, @MedicationStartDate, @MedicationEndDate, @PrescriptionHCP)";
                    if (!string.IsNullOrEmpty(medicationTB.Text) &&
                        SharedMethods.CurrentPatientID != -1)
                    {
                        cmd.Parameters.AddWithValue("@Medication", getTrueValForSQL(medicationTB.Text));
                        cmd.Parameters.AddWithValue("@MedicationAmt", getTrueValForSQL(medAmtTB.Text));
                        cmd.Parameters.AddWithValue("@MedicationUnit", getTrueValForSQL(medUnitTB.Text));
                        cmd.Parameters.AddWithValue("@Instructions", getTrueValForSQL(instructionsTB.Text));
                        cmd.Parameters.AddWithValue("@MedicationStartDate", MedSDdatePicker.Value);
                        cmd.Parameters.AddWithValue("@MedicationEndDate", MedEDdatePicker.Value);
                        cmd.Parameters.AddWithValue("@PrescriptionHCP", getTrueValForSQL(prescriptionHCPTB.Text));

                        //cmd.Parameters.AddWithValue("@DateEntered", DateTime.Now); saved for future logging function.

                        cmd.Prepare();
                        cmd.ExecuteNonQuery();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Medication name is required.");
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
