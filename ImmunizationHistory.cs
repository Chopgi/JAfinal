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
    public partial class ImmunizationHistory : Form
    {
        int currentPatIDtoPass = -1;
        public ImmunizationHistory()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        public ImmunizationHistory(Form f, int patientID)
        {
            InitializeComponent();
            f.Dispose();
            this.FormClosed += (s, args) => Application.Exit();
            currentPatIDtoPass = patientID;

            refreshNameLabel();
        }

        private void visitPDbut_Click(object sender, EventArgs e)
        {
            Form PatientDemographics = new PatientDemographics(this, currentPatIDtoPass);
            PatientDemographics.Show();
        }

        private void visitGMHbut_Click(object sender, EventArgs e)
        {
            Form GenMedicalHistory = new GenMedicalHistory(this, currentPatIDtoPass);
            GenMedicalHistory.Show();
        }

        private void visitMHbut_Click(object sender, EventArgs e)
        {
            Form MedicationHistory = new MedicationHistory(this, currentPatIDtoPass);
            MedicationHistory.Show();
        }

        private void ImmunizationHistory_Load(object sender, EventArgs e)
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
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT Vaccine, ImmunizationDate, ExperationDate AS 'EXP Date', Delivery, Comments, HCPId FROM immunizationshistorytable WHERE PatientID = " + currentPatIDtoPass, conn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
            populateCB();
        }

        public void populateCB()
        {
            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open();
                    DataTable dt = new DataTable();
                    DataSet ds = new DataSet();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT PatientID, PtFirstName, PtLastName, PtHomePhone " + "FROM patientdemographics " + "WHERE deleted NOT IN (1)", conn);
                    da.Fill(ds, "patientDataset");

                    dt = ds.Tables["patientDataset"];
                    dt.Columns.Add("FullPatInfo", typeof(string), "PtLastName + ', ' + PtFirstName + ' (' + PtHomePhone + ')'");
                    selectPatientCB.DisplayMember = "FullPatInfo";
                    selectPatientCB.ValueMember = "PatientID";
                    selectPatientCB.DataSource = ds.Tables["patientDataset"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
            selectPatientCB.SelectedValue = currentPatIDtoPass;
        }

        public void refreshNameLabel()
        {
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

        private void selectPatientCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentPatIDtoPass = (int)selectPatientCB.SelectedValue;
            refreshNameLabel();
            ImmunizationHistory_Load(sender, e);
        }

        private void addButMH_Click(object sender, EventArgs e)
        {
            Form AddImmunizationHistory = new AddImmunizationHistory(this, currentPatIDtoPass);
            AddImmunizationHistory.Owner = this;
            AddImmunizationHistory.ShowDialog();
            //refreshListBox();
        }
    }
}
