//the display
//it works
//2016/09/26
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progAssigment2
{
    public partial class frmDispaly : Form
    {
        public frmDispaly()
        {
            InitializeComponent();
        }

        private void frmDispaly_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progAssigment2DataSet.tblAppoinments' table. You can move, or remove it, as needed.
            this.tblAppoinmentsTableAdapter.Fill(this.progAssigment2DataSet.tblAppoinments);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu mn = new frmMenu();
            this.Hide();
            mn.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUpdate u = new frmUpdate();
            this.Hide();
            u.Show();
        }
    }
}
