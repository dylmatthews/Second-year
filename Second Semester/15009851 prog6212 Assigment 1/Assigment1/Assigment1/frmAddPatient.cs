using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assigment1
{
    public partial class frmAddPatient : Form
    {
        public frmAddPatient()
        {
            InitializeComponent();
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.AppendText("patientDetails.txt");
            sw.WriteLine(txtPatientFirstName.Text + "#" + txtPatientLastName.Text + "#" + txtPatientCellnumber.Text);
            MessageBox.Show("Patient is added");
            sw.Close();
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmReceptionsit rec = new frmReceptionsit();
            this.Hide();
            rec.Show();
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
