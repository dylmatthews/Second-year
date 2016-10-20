/* this is the menu screen
 * Dylan Matthews
 * 01/06/2016
 * 
 * */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjAssigment3
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if(rdbBatteries.Checked)
            {
                this.Hide();
                frmSellBatteries bat = new frmSellBatteries();
                bat.Show(); //shows selling screen for batteries
            }
            else if (rdbKeys.Checked)
            {
                this.Hide();
                frmSellKeys keys = new frmSellKeys();
                keys.Show(); //shows selling screen for keys
            }
            else if (rdbLocks.Checked)
            {
                this.Hide();
                frmSellLcoks locks = new frmSellLcoks();
                locks.Show(); //shows selling screen for locks
            }
            else if (rdbRemotes.Checked)
            {
                this.Hide();
                frmSellRemotes remotes = new frmSellRemotes();
                remotes.Show();  //shows selling screen for rmeotes
            }
            else if (rdbRepairs.Checked)
            {
                this.Hide();
                frmSellRepairs repairs = new frmSellRepairs();
                repairs.Show();  //shows selling screen for repairs
            }
            else if (rdbShop.Checked)
            {
                this.Hide();
                frmSellShop shop = new frmSellShop();
                shop.Show();  //shows selling screen for shop
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.Show(); //shows selling screen for login
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
