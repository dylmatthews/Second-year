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
    public partial class frmForgotPassword : Form
    {
        string[,] users;
        int count;
        public frmForgotPassword()
        {
            InitializeComponent();
        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        public void start ()
        {
            int cn = 0;
            try
            {

                StreamReader sr = new StreamReader("login.txt");
                int cnt = 0;
                string line = sr.ReadLine();
                while (line != null)
                {
                    cnt++; //counts to see how big to make array
                    line = sr.ReadLine();
                }
                sr.Close();
                users = new string[cnt, 2];
                StreamReader s = new StreamReader("login.txt");
             
                string lin = s.ReadLine();
                while (lin != null)

                {  
                    string[] temp = lin.Split('#');
                    users[cn, 0] = temp[0];
                    users[cn, 1] = temp[1];
                    
                    lin = s.ReadLine();
                    cn++;
                  
                }
                s.Close();
            }
            catch
            {

            }
            count=cn;
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            start();

            if (txtNewPassword.Text.Equals(txtComfirmPassword.Text))
            {

                bool foundName=false;
                for (int i = 0; i < count; i++)
                {
                    if (foundName == false)
                    {
                       
                        if (users[i,0].Equals(txtUsername.Text))
                        {

                            MessageBox.Show("Found name");
                            users[i,1] = txtNewPassword.Text;
                             foundName = true;
                        }
                        else
                        {
                            foundName = false;
                        }
                       
                    }
                   
                }

                if (foundName==false)
                {
                    MessageBox.Show("Name not found");
                }

                else
                {
                    write2file();
                    frmLogin lo = new frmLogin();
                    this.Hide();
                    lo.Show();
                }
             
            }
            else
            {
                MessageBox.Show("Passwords don't match");
            }

        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>
        public void write2file ()
        {
            StreamWriter fs = new StreamWriter("login.txt");
            for(int i=0; i<users.GetLength(0); i++)
            {
                fs.WriteLine(users[i,0] + "#" + users[i,1]) ;

                if (i==users.GetLength(0)-1)
                {
                    MessageBox.Show("Updated password");
                }

            }
          
            fs.Close();
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmLogin lo = new frmLogin();
            this.Hide();
            lo.Show();

        }

        /// <summary>
        /// /////////////////////////////////////////////////////////////////////
        /// </summary>

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      
    }
}
