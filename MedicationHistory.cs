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
    public partial class MedicationHistory : Form
    {
        string currentPatIDtoPass = "-1";
        public MedicationHistory()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        public MedicationHistory(Form f, string patientID)
        {
            InitializeComponent();
            f.Dispose();
            this.FormClosed += (s, args) => Application.Exit();
            currentPatIDtoPass = patientID;

            refreshNameLabel();
        }

        private void MedicationHistory_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(185, 209, 234);
            refreshDataGrid();
            populateCB();
        }

        public void refreshDataGrid()
        {
            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT Medication, MedicationAmt AS 'Amount', MedicationUnit AS Unit, Instructions, MedicationStartDate AS StartDate, MedicationEndDate AS EndDate, PrescriptionHCP FROM patientmedications WHERE PatientID = " + currentPatIDtoPass, conn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
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

        private void visitGMHbut_Click(object sender, EventArgs e)
        {
            Form GenMedicalHistory = new GenMedicalHistory(this, currentPatIDtoPass);
            GenMedicalHistory.Show();
        }


        private void visitPDbut_Click(object sender, EventArgs e)
        {
            Form PatientDemographics = new PatientDemographics(this, currentPatIDtoPass);
            PatientDemographics.Show();
        }

        private void visitIHbut_Click(object sender, EventArgs e)
        {
            Form ImmunizationHistory = new ImmunizationHistory(this, currentPatIDtoPass);
            ImmunizationHistory.Show();
        }

        private void selectPatientCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentPatIDtoPass = selectPatientCB.SelectedValue.ToString();
            refreshNameLabel();
            MedicationHistory_Load(sender,  e);
        }

        private void addButMH_Click(object sender, EventArgs e)
        {
            Form AddMedicationHistory = new AddMedicationHistory();
            AddMedicationHistory.Owner = this;
            AddMedicationHistory.ShowDialog();
            refreshDataGrid();
            populateCB();
        }
    }
}
