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
        int currentPatIDtoEdit = -1;
        public AddImmunizationHistory(Form f, int patientID)
        {
            InitializeComponent();
            currentPatIDtoEdit = patientID;
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

                    cmd.CommandText = @"INSERT INTO immunizationshistorytable(PatientID, Vaccine, ImmunizationDate, ExperationDate, Delivery, Comments, HCPId)" + " VALUES(" + currentPatIDtoEdit + ", @Vaccine, @ImmunizationDate, @ExperationDate, @Delivery, @Comments, @HCPId)";
                    if (!string.IsNullOrEmpty(vaccineTB.Text) &&
                        currentPatIDtoEdit != -1)
                    {
                        cmd.Parameters.AddWithValue("@Vaccine", getTrueValForSQL(vaccineTB.Text));
                        cmd.Parameters.AddWithValue("@ImmunizationDate", IMMdatepicker.Value);
                        cmd.Parameters.AddWithValue("@ExperationDate", IMMdatepicker.Value);
                        cmd.Parameters.AddWithValue("@Delivery", getTrueValForSQL(deliveryTB.Text));
                        cmd.Parameters.AddWithValue("@Comments", getTrueValForSQL(deliveryTB.Text));
                        cmd.Parameters.AddWithValue("@HCPId", getTrueValForSQL(deliveryTB.Text));

                        cmd.Parameters.AddWithValue("@DateEntered", DateTime.Now);
                        
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
