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
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(txtPasswordComfirm.Text))
            {
                try
                {
                    StreamWriter sw = File.AppendText("login.txt");
                    sw.WriteLine(txtUserName.Text + "#" + txtPassword.Text); 
                    MessageBox.Show("Your username and password has been saved! :)");
                    sw.Close();
                    this.Hide();
                    frmLogin fl = new frmLogin();
                    fl.Show();
                }
                catch 
                {

                }
               
            }
            else
            {
                MessageBox.Show("Passwords don't match!!");
            }
        }

        /// <summary>
        //////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
 


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
