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
        public MedicationHistory()
        {
            InitializeComponent();
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void MedicationHistory_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(185, 209, 234);
        }

        private void visitGMHbut_Click(object sender, EventArgs e)
        {
            Form GenMedicalHistory = new GenMedicalHistory();
            GenMedicalHistory.Show();
            this.Hide();
        }

        private void visitLOGINbut_Click(object sender, EventArgs e)
        {
            Form Login = new Login();
            Login.Show();
            this.Hide();
        }
    }
}
