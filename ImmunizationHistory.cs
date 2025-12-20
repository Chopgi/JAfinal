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
        public ImmunizationHistory()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        public ImmunizationHistory(Form f)
        {
            InitializeComponent();
            f.Dispose();
            this.FormClosed += (s, args) => Application.Exit();
        }


        private void ImmunizationHistory_Load(object sender, EventArgs e)
        {
            SharedMethods.RefreshNameLabel(nameAgeLabel);
            SharedMethods.PopulateCB(selectPatientCB);
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
                    conn.Open();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT Vaccine, ImmunizationDate, ExperationDate AS 'EXP Date', Delivery, Comments, HCPId FROM immunizationshistorytable WHERE PatientID = " + SharedMethods.CurrentPatientID, conn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
        }

        private void visitPDbut_Click(object sender, EventArgs e)
        {
            Form PatientDemographics = new PatientDemographics(this);
            PatientDemographics.Show();
        }

        private void visitGMHbut_Click(object sender, EventArgs e)
        {
            Form GenMedicalHistory = new GenMedicalHistory(this);
            GenMedicalHistory.Show();
        }

        private void visitMHbut_Click(object sender, EventArgs e)
        {
            Form MedicationHistory = new MedicationHistory(this);
            MedicationHistory.Show();
        }

        private void selectPatientCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SharedMethods.CurrentPatientID = (int)selectPatientCB.SelectedValue;
            SharedMethods.RefreshNameLabel(nameAgeLabel);
            refreshListBox();
        }

        private void addButMH_Click(object sender, EventArgs e)
        {
            Form AddImmunizationHistory = new AddImmunizationHistory();
            AddImmunizationHistory.Owner = this;
            AddImmunizationHistory.ShowDialog();
            refreshListBox();
        }
    }
}
