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

namespace prjAssigment2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("users.txt");
                string line = sr.ReadLine();
                if (!(txtPassword.Text.Length==0))
                {
                    while (line != null)
                    {
                        string[] temp = line.Split(',');

                        if (temp[0].Equals(txtName.Text))
                        {
                            if(txtPassword.Text.Equals(temp[1]))
                            {
                                MessageBox.Show("Login Succesful");
                                if (temp[2].Equals("Admin"))
                                {
                                    this.Hide();
                                    frmAdmin ad = new frmAdmin();
                                    ad.Show();
                                }
                                else
                                {
                                    this.Hide();
                                    frmMenu mn = new frmMenu();
                                    mn.Show();
                                }
                              
                            }
                          
                        }
                        line = sr.ReadLine();
                        
                    }


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ "shit" );
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRegisterUser ru = new frmRegisterUser();
            ru.Show();
        }
    }
}
