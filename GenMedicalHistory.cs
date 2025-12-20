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
        public GenMedicalHistory()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        public GenMedicalHistory(Form f)
        {
            InitializeComponent();
            f.Dispose();
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void GenMedicalHistory_Load(object sender, EventArgs e)
        {
            SharedMethods.RefreshNameLabel(nameAgeLabel);
            SharedMethods.PopulateCB(selectPatientCB);
            BackColor = Color.FromArgb(185, 209, 234);
            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM generalmedicalhistory WHERE deleted NOT IN (1) AND PatientID = " + SharedMethods.CurrentPatientID, conn);
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
            Form MedicationHistory = new MedicationHistory(this);
            MedicationHistory.Show();
        }

        private void visitPDbut_Click(object sender, EventArgs e)
        {
            Form PatientDemographics = new PatientDemographics(this);
            PatientDemographics.Show();
        }

        private void visitIHbut_Click(object sender, EventArgs e)
        {
            Form ImmunizationHistory = new ImmunizationHistory(this);
            ImmunizationHistory.Show();
        }

        private void selectPatientCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SharedMethods.CurrentPatientID = (int)selectPatientCB.SelectedValue;
            GenMedicalHistory_Load(sender, e);
        }
    }
}
