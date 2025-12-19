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
            if (currentPatIDtoPass != -1)
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

        private int currentPatIDtoPass = -1; //default if no patient is selected

        private void SelectPatient_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(185, 209, 234);
            refreshListBox();

        }

        public void refreshListBox()
        {
            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open(); //Opening connection to database
                    cmd.CommandText = "SELECT PatientID, PtFirstName, PtLastName, PtHomePhone " + "FROM patientdemographics " + "WHERE deleted NOT IN (1)";
                    MySqlDataReader reader = cmd.ExecuteReader(); //Helps me read the command that we executed
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
            currentPatIDtoPass = currentPatID.PatientID;



            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open(); //Opening connection to database
                    cmd.CommandText = "SELECT PtFirstName, PtLastName " + "FROM patientdemographics " + "WHERE PatientID = "+ currentPatID.PatientID;
                    MySqlDataReader reader = cmd.ExecuteReader(); //Helps me read the command that we executed
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
    }
}
