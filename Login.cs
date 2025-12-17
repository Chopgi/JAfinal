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
            bool MHcheck = false;
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(185, 209, 234);
            
            loginBut.Cursor = Cursors.Hand;
            usernameTB.TabIndex = 0;
            passwordTB.TabIndex = 1;
            loginBut.TabIndex = 2;
            
            this.AcceptButton = loginBut;
        }

        private void visitGMHbut_Click(object sender, EventArgs e)
        {
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
            Form SelectPatient = new SelectPatient();
            SelectPatient.Show();
            this.Hide();
        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            
        }
    }
}
