using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assigment1
{
    public partial class frmReceptionsit : Form
    {
        public frmReceptionsit()
        {
            InitializeComponent();
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddPatient ap = new frmAddPatient();
            ap.Show();
            //takes to add patient screeen
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch s = new frmSearch();
            this.Hide();
            s.Show();
            //takes to search screeen
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        private void btnReport_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReport r = new frmReport();
            r.Show();
            //takes to report screeen
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //exits program
        }
    }
}
