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
    public partial class GenMedicalHistory : Form
    {
        string currentPatIDtoPass = "-1";
        public GenMedicalHistory()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        public GenMedicalHistory(Form f, string patientID)
        {
            InitializeComponent();
            f.Dispose();
            this.FormClosed += (s, args) => Application.Exit();
            currentPatIDtoPass = patientID;

            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open();
                    cmd.CommandText = "SELECT PtFirstName, PtLastName " + "FROM patientdemographics " + "WHERE PatientID = " + currentPatIDtoPass;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        nameAgeLabel.Text = reader.GetString(0) + " " + reader.GetString(1);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
        }

        private void GenMedicalHistory_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(185, 209, 234);
            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM patientdemographics WHERE PatientID = " + currentPatIDtoPass, conn);
                    da.Fill(dt);
                    dataGridViewGMH.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
        }

        private void visitMHbut_Click(object sender, EventArgs e)
        {
            Form MedicationHistory = new MedicationHistory(this, currentPatIDtoPass);
            MedicationHistory.Show();
        }

        private void visitLOGINbut_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
            this.Hide();
        }

        private void visitPDbut_Click(object sender, EventArgs e)
        {
            Form PatientDemographics = new PatientDemographics(this, currentPatIDtoPass);
            PatientDemographics.Show();
        }

    }
}
