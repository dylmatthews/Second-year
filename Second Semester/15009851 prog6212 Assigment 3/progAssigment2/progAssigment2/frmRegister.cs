//register a user to login in
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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }
        //
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //
        //

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin l = new frmLogin();
            this.Hide();
            l.Show();
        }
       //
        //
        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                // dbConnect db = new dbConnect();
                SqlConnection myConnection = new SqlConnection("Server=tcp:progassigments.database.windows.net,1433;Initial Catalog=progAssigment2;Persist Security Info=False;User ID=Dylan;Password=Zxcvbnm12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");  //connects to db on azure
                myConnection.Open();
                SqlCommand cmd = new SqlCommand();
                string username = txtUserName.Text;
                string password = txtPassword.Text;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.CommandText = "Insert into tblLogin values (@Username,  @Password)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = myConnection;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            catch (SqlException se)
            {
                MessageBox.Show("connection time out...\n\n\n\n\n" + se.Message);
            }
            catch (DBConcurrencyException dbce)
            {
                MessageBox.Show("Failed to create new user....\n\n\n" + dbce.Message);
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
    }
}
