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
    public partial class SelectPatient : Form
    {
        public SelectPatient()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(185, 209, 234);
            this.FormClosed += (s, args) => Application.Exit();
        }

        private void visitPDbut_Click(object sender, EventArgs e)
        {

        }
    }
}
