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
    public partial class PatientDemographics : Form
    {
        public PatientDemographics()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        public PatientDemographics(Form f)
        {
            InitializeComponent();
            f.Dispose();
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void PatientDemographics_Load(object sender, EventArgs e)
        {
            SharedMethods.RefreshNameLabel(nameAgeLabel);
            SharedMethods.PopulateCB(selectPatientCB);
            BackColor = Color.FromArgb(185, 209, 234);
            refreshDataGrid();
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
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM patientdemographics WHERE PatientID = " + SharedMethods.CurrentPatientID, conn);
                    da.Fill(dt);
                    dataGridViewPD.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
        }
        
        private void visitMHbut_Click(object sender, EventArgs e)
        {
            Form MedicationHistory = new MedicationHistory(this);
            MedicationHistory.Show();
        }

        private void visitGMHbut_Click(object sender, EventArgs e)
        {
            Form GenMedicalHistory = new GenMedicalHistory(this);
            GenMedicalHistory.Show();
        }

        private void visitIHbut_Click(object sender, EventArgs e)
        {
            Form ImmunizationHistory = new ImmunizationHistory(this);
            ImmunizationHistory.Show();
        }

        private void selectPatientCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SharedMethods.CurrentPatientID = (int)selectPatientCB.SelectedValue;
            SharedMethods.RefreshNameLabel(nameAgeLabel);
            refreshDataGrid();
        }

        private void addButPD_Click(object sender, EventArgs e)
        {
            Form AddPatient = new AddPatient();
            AddPatient.Owner = this;
            AddPatient.ShowDialog();
            refreshDataGrid();
            SharedMethods.PopulateCB(selectPatientCB);
        }
    }
}
