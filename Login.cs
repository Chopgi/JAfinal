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
            bool GMHcheck = false;
            bool MHcheck = false; // Placeholders
            this.FormClosed += (s, args) => Application.Exit(); //Close the process when form is closed
            // todo: generate patient report file upon login
            //       Begin logging upon login
            //       Make login button bring user to Select patient
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(185, 209, 234);
            loginLabel.Text=(this.Name);

        }

        private void visitGMHbut_Click(object sender, EventArgs e)
        {
            //left in for debugging
            Form GenMedicalHistory = new GenMedicalHistory();
            GenMedicalHistory.Show();
            this.Hide();

        }

        private void visitMHbut_Click(object sender, EventArgs e)
        {
            
            Form MedicationHistory = new MedicationHistory();
            MedicationHistory.Show();
            this.Hide();
        }

        private void loginBut_Click(object sender, EventArgs e)
        {

        }
    }
}
