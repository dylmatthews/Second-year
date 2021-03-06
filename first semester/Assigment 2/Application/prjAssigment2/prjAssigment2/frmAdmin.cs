﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAssigment2
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(rdbAddStock.Checked)
            {
                this.Hide();
                frmAddStock adst = new frmAddStock();
                adst.Show();  //shows selling screen for add stock
            }
            else if (rdbSellStock.Checked)
            {
                this.Hide();
                frmMenu mn = new frmMenu();
                mn.Show();  //shows selling screen 
            }
            else if (rdbViewStock.Checked)
            {
                this.Hide();
                frmViewStock stock = new frmViewStock();
                stock.Show();  //shows  stock screen
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            this.Hide();
            log.Show();  //shows login screen
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
