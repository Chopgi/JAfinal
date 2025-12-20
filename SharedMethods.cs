using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student2
{
    internal static class SharedMethods
    {
        public static int CurrentPatientID = -1; //default if no patient is selected
        public static string CurrentUser; //Stored for use in log
        public static void RefreshNameLabel(Label labelToUpdate)
        {
            string connString = "server=localhost;uid=root;pwd=toor;database=its245";
            using (var conn = new MySqlConnection(connString))
            {
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    conn.Open();
                    cmd.CommandText = "SELECT PtFirstName, PtLastName " + "FROM patientdemographics " + "WHERE PatientID = " + CurrentPatientID;
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        labelToUpdate.Text = reader.GetString(0) + " " + reader.GetString(1);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
        }

        public static void PopulateCB(ComboBox CbToPopulate) 
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
                    CbToPopulate.DisplayMember = "FullPatInfo";
                    CbToPopulate.ValueMember = "PatientID";
                    CbToPopulate.DataSource = ds.Tables["patientDataset"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("DB error " + ex.Message);
                }
            }
            CbToPopulate.SelectedValue = CurrentPatientID;
        }

        







    }
}
