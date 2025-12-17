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
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Student2
{
    public partial class SelectPatient : Form
    {
        private class patientItem 
        {
            public int PatientID { get; set; }
            public string PatientInfo { get; set; }
            public patientItem(int patientID, string patientInfo) 
            {
                PatientID = patientID;
                PatientInfo = patientInfo;
            }
            public override string ToString()
            {
                return PatientInfo;
            }
        }
        public SelectPatient()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void visitPDbut_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (currentPatIDtoPass != "-1")
            {
                Form PatientDemographics = new PatientDemographics(this, currentPatIDtoPass);
                PatientDemographics.Show();
            }
            else
            {
                Form PatientDemographics = new PatientDemographics();
                PatientDemographics.Show();
                this.Dispose();

            }
        }

        private string currentPatIDtoPass = "-1";

        private void SelectPatient_Load(object sender, EventArgs e)
        {
            BackColor = Color.CornflowerBlue;
            LoadPatients();
        }

        private void LoadPatients()
        {
            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open();
                    cmd.CommandText = "SELECT PatientID, PtFirstName, PtLastName, PtHomePhone " + "FROM patientdemographics " + "WHERE deleted NOT IN (1)";
                    MySqlDataReader reader = cmd.ExecuteReader();
                    listBoxSP.Items.Clear();
                    while (reader.Read())
                    {
                        int patientID = reader.GetInt32(0);
                        string firstname = reader.GetString(1);
                        string lastname = reader.GetString(2);
                        string homephone = reader.GetString(3);
                        if (Convert.IsDBNull(reader.GetString(3)))
                        {
                            homephone = "0";
                        }

                        listBoxSP.Items.Add(new patientItem(patientID, $"{firstname}, {lastname}, {homephone}"));
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
        }

        private void listBoxSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            var currentPatID = listBoxSP.SelectedItem as patientItem;
            if (currentPatID == null) return;
            
            currentPatIDtoPass = currentPatID.PatientID.ToString();

            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open();
                    cmd.CommandText = "SELECT PtFirstName, PtLastName " + "FROM patientdemographics " + "WHERE PatientID = "+ currentPatID.PatientID.ToString();
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

        private void addButGMH_Click(object sender, EventArgs e)
        {
            AddPatient addForm = new AddPatient();
            addForm.ShowDialog();
            LoadPatients();
        }

        private void modifyButGMH_Click(object sender, EventArgs e)
        {
            if (currentPatIDtoPass == "-1")
            {
                MessageBox.Show("Please select a patient first");
                return;
            }
        }

        private void saveButGMH_Click(object sender, EventArgs e)
        {
            
        }

        private void undoButGMH_Click(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void deleteButGMH_Click(object sender, EventArgs e)
        {
            if (currentPatIDtoPass == "-1")
            {
                MessageBox.Show("Please select a patient first");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string connString = "server=localhost;uid=root;pwd=toor;database=its245";
                using (var conn = new MySqlConnection(connString))
                {
                    try
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        conn.Open();
                        cmd.CommandText = "UPDATE patientdemographics SET deleted = 1 WHERE PatientID = " + currentPatIDtoPass;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Patient deleted successfully");
                        currentPatIDtoPass = "-1";
                        nameAgeLabel.Text = "PatientFname, Lname, Age";
                        LoadPatients();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("DB error " + ex.Message);
                    }
                }
            }
        }
    }
}
