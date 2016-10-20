/* this is the login screen
 * Dylan Matthews
 * 01/06/2016
 * 
 * */

using FinalStockControlSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalStockControlSystem
{
    public partial class frmLogin : Form, IExit, IFailedLogin
    {
        public frmLogin()
        {
            InitializeComponent();
            rdbStop.Checked = true;
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btnSubmit_Click(object sender, EventArgs e) //it submits the user name and password
        {
            bool found = false;
            ChildLogin cd = new ChildLogin();
            try
            {
                StreamReader sr = new StreamReader("users.txt");
                string line = sr.ReadLine();
                if (!(txtPassword.Text.Length==0))
                {

                    while (line != null)
                    {
                        string[] temp = line.Split(',');
                       ChildLogin cdr = new ChildLogin(temp[0],temp[1],temp[2]); //OOP
                       var name = txtName.Text;
                       dynamic password = txtPassword.Text;
                        if (cdr.User.Equals(name))
                        {
                          
                            if(password.Equals(cdr.password))
                            {
                                found = true;
                                MessageBox.Show("Login Succesful");
                                if (cdr.Status.Equals("Admin"))
                                {
                                    
                                    this.Hide();
                                    frmAdmin ad = new frmAdmin();
                                    ad.Show();
                                }
                                else
                                {

                                    frmSell s = new frmSell();
                                    this.Hide();
                                    s.Show();
                                }
                              
                            }
                            else
                            {

                            }
                          
                        }
                        
                        line = sr.ReadLine();
                        
                    }


                }

                if (found==false)
                {
                    IFailedLogin();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public  virtual void IFailedLogin() //this is a virtual method
        {
            MessageBox.Show("Failed login");
        }


        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        public virtual void IExit() //this is a virtual method
        {
            MessageBox.Show("Thanks for using the program");
            Application.Exit();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) //used to display message and exit program
        {
         IExit();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void helpToolStripMenuItem_Click(object sender, EventArgs e) //this takes you to the help form
        {
            frmHelp h = new frmHelp();
            this.Hide();
            h.Show();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void rdbBangRang_CheckedChanged(object sender, EventArgs e) //this calls the overloaded constructor  and plays the selected sound
        {
            sound snd = new sound(4);
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void rdbSummit_CheckedChanged(object sender, EventArgs e)//this calls the overloaded constructor  and plays the selected sound
        {
              sound snd = new sound("Hello");
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void rdbStop_CheckedChanged(object sender, EventArgs e)//this calls the overloaded constructor  and plays the selected sound
        {
            sound snd = new sound(12.65);
        }


        private void bntRegister_Click(object sender, EventArgs e) //takes you to the register form
        {
            this.Hide();
            frmRegisterUser ru = new frmRegisterUser();
            ru.Show();
        }
      

    }
}
