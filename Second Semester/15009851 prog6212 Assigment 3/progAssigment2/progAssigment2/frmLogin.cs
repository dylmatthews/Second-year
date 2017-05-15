//the login screen
//it works
//2016/09/26
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace progAssigment2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //
        //
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection("Server=tcp:progassigments.database.windows.net,1433;Initial Catalog=progAssigment2;Persist Security Info=False;User ID=Dylan;Password=Zxcvbnm12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");  //connects to db on azure

                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblLogin WHERE username='" + txtUserName.Text + "' AND userPassword ='" + txtPassword.Text + "'", myConnection);
                /* in above line the program is selecting the whole data from table and the matching it with the user name and password provided by user. */
                DataTable dt = new DataTable(); //this is creating a virtual table  
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("valid username");
                    this.Hide();
                    frmMenu mn = new frmMenu();
                    mn.Show();
                }
                else
                    MessageBox.Show("Invalid username or password");

            }
            catch (SqlException Ex)
            {
                MessageBox.Show("connection time out...\n\n\n\n\n" + Ex.Message);
            }
            catch (OutOfMemoryException oome)
            {
                MessageBox.Show("An unexpected error happened....\n\n" + oome.Message);
            }
            catch (PlatformNotSupportedException pfnse)
            {
                MessageBox.Show("This program does't support your device...\n\n\n" + pfnse.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error happended...contact your admin with this message /n/n/n:" + ex.Message);
            }
            finally
            {

            }
        }
        //
        //
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                frmRegister reg = new frmRegister();
                this.Hide();
                reg.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form failed to load\n\n" + ex.Message);
            }
        }
    }
}
