using System;
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
    public partial class frmAddStock : Form
    {
        public frmAddStock()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdbBatteries.Checked)
            {
                this.Hide();
                frmAddBattery bat = new frmAddBattery();
                bat.Show();
            }
            else if (rdbKeys.Checked)
            {
                this.Hide();
                frmAddKeys keys = new frmAddKeys();
                keys.Show();
            }
            else if (rdbLocks.Checked)
            {
                this.Hide();
                frmAddLocks locks = new frmAddLocks();
                locks.Show();
            }
            else if (rdbRemotes.Checked)
            {
                this.Hide();
                frmAddRemotes remotes = new frmAddRemotes();
                remotes.Show();
            }
            else if (rdbRepairs.Checked)
            {
                this.Hide();
                frmAddRepairs repairs = new frmAddRepairs();
                repairs.Show();
            }
            else if (rdbShop.Checked)
            {
                this.Hide();
                frmAddShop shop = new frmAddShop();
                shop.Show();
            }
        }
    }
}
