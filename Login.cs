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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(185, 209, 234);
            loginBut.Cursor = Cursors.Hand;
            this.AcceptButton = loginBut;
        }

        private void loginBut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(usernameTB.Text) && !string.IsNullOrEmpty(passwordTB.Text))
            {
                string connString = "server=localhost;uid=root;pwd=toor;database=its245";
                using (var conn = new MySqlConnection(connString))
                {
                    try
                    {
                        MySqlCommand cmd = conn.CreateCommand();
                        conn.Open();
                        cmd.CommandText = "SELECT UserName, Password " + "FROM login " + "WHERE deleted NOT IN (1) AND " + "UserName IN ('" + usernameTB.Text + "')";
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            string DBuser = reader.GetString(0);
                            string DBpass = reader.GetString(1);
                            if (usernameTB.Text == DBuser && passwordTB.Text == DBpass)
                            {
                                SharedMethods.CurrentUser = DBuser;
                                Form SelectPatient = new SelectPatient();
                                SelectPatient.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid username or password.");
                            }
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("DB error: " + ex.Message);
                    }
                } 
            }
            else
            {
                MessageBox.Show("Please input both a username and password.");
            }
        }
    }
}
