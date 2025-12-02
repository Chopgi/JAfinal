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

        private void GenMedicalHistory_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(185, 209, 234);
        }

        private void visitMHbut_Click(object sender, EventArgs e)
        {
            Form MedicationHistory = new MedicationHistory();
            MedicationHistory.Show();
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
