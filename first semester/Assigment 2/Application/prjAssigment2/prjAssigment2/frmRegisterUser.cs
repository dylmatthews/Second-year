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
    public partial class frmRegisterUser : Form
    {
        public frmRegisterUser()
        {
            InitializeComponent();
        }

        private void bntSubmit_Click(object sender, EventArgs e)
        {

            if(!(txtName.Text==""))
            {
                if (txtPassword.Text.Equals(txtPassword1.Text))
                {
                    if (!(cmbJobStatus.Text.Equals("")))
                    {
                        if (!(cmbRelationshipStatus.Text.Equals("")))
                        {
                            string line = txtName.Text + "," + txtPassword.Text + "," + cmbJobStatus.Text +
                                            "," + cmbRelationshipStatus.Text;
                            write2File(line);

                        }
                        else
                        {
                            MessageBox.Show("Select a relationship status");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select a job status");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match!!");
                }
                

                
            }
            else
            {
                MessageBox.Show("Enter a name!!");
            }

        }
        
        private void lblPasswordComfirmed_Click(object sender, EventArgs e)
        {
                           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text="";
            txtPassword.Text = "";
            txtPassword1.Text = "";
            cmbJobStatus.SelectedIndex=-1;
            cmbRelationshipStatus.SelectedIndex = -1;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPassword1.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassword1.PasswordChar = '*';
            }
        }

        public void back()
        {
            frmLogin l = new frmLogin();
            this.Hide();
            l.Show();
        }

        public void write2File(string line)
        {
            try
            {
                StreamWriter writer = File.AppendText("users.txt");
                writer.WriteLine(line);
                writer.Close();
                MessageBox.Show("Saved user");
                back();
            }
            catch
            {
                MessageBox.Show("Error writing to file");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            back();
        }
 
    }
}
