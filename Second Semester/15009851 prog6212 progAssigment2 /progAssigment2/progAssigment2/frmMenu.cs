//the menu 
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        //
        //

        private void btnInsertAppointment_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInsertAppointment ia = new frmInsertAppointment();
            ia.Show();
        }
        //
        //

        private void btnDelete_Click(object sender, EventArgs e)
        {
            frmDelete del = new frmDelete();
            this.Hide();
            del.Show();

        }
        //
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin l = new frmLogin();
            l.Show();
        }
        //
        //
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate u = new frmUpdate();
            this.Hide();
            u.Show();
        }

        private void btnViewAppoinmenmts_Click(object sender, EventArgs e)
        {
            frmDispaly d = new frmDispaly();
            this.Hide();
            d.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }





       
    }
}
