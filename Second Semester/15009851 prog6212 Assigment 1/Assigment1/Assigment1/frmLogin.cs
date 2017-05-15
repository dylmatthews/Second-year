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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            frmRegisterUser ru = new frmRegisterUser();  
            this.Hide();
            ru.Show();
           //go to register screen
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool found = false;
            try
            {
                StreamReader sr = new StreamReader("login.txt"); //opens file
                string line  = sr.ReadLine();
                while (line!=null & found == false)
                {
                    string [] temp = line.Split('#');
                    if (txtUserName.Text.Equals(temp[0]))
                    {
                        if (txtPassword.Text.Equals(temp[1]))
                        {
                            MessageBox.Show("Welcome");
                            found = true;
                            frmReceptionsit rec = new frmReceptionsit();
                            this.Hide();
                            rec.Show();
                            //takes user to reception screen
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password");
                            found = true;
                        }
                    }
                    
                    line = sr.ReadLine();
                }

                if (found==false)
                {
                    MessageBox.Show("User name not found");
                }

            }
            catch
            {

            }
          
        }
        
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>

        private void btnForgotPassword_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmForgotPassword ffp = new frmForgotPassword();
            ffp.Show();
            // shows forgot password screen
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //exits program
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        private void ckbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0'; //changes to show user password
            }
            else
            {
                txtPassword.PasswordChar = '*';//shows passworfd as password
            }
           
        }

        
    }
}
