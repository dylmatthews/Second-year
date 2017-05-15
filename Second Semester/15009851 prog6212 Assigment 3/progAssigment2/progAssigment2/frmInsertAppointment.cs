
//the insert appoinments
//it works
//2016/09/26using System;
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
    public partial class frmInsertAppointment : Form
    {
        public frmInsertAppointment()
        {
            InitializeComponent();
        }
        //
        //
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection myConnection = new SqlConnection("Server=tcp:progassigments.database.windows.net,1433;Initial Catalog=progAssigment2;Persist Security Info=False;User ID=Dylan;Password=Zxcvbnm12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");  //connects to db on azure
                myConnection.Open();
                SqlCommand cmd = new SqlCommand();
                string name = txtName.Text;
                string surname = txtSurname.Text;
                string date = dtpAppointmentDate.Value.ToShortDateString() + " " + cbbTime.Text;
                int num =0;
                try
                {
                     num = Convert.ToInt32(txtPhoneNumber.Text);
                }
                catch (Exception ex) {
                    MessageBox.Show("You didnt enter a number" + ex.Message);
                   
                }
                string number = "" + num;

                cmd.Parameters.AddWithValue("@PatientName", name);
                cmd.Parameters.AddWithValue("@surname", surname);
                cmd.Parameters.AddWithValue("@dateTime", date);
                cmd.Parameters.AddWithValue("@number", number);
                cmd.CommandText = "Insert into tblAppoinments values (@PatientName, @surname,  @number,@dateTime)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = myConnection;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
            }
            catch (SqlException Ex)
            {
                MessageBox.Show("That appoinment date and time has been taken\n\n" + Ex.Message);
            }
            catch (DBConcurrencyException dbce)
            {
                MessageBox.Show("Failed to insert into database....\n\n\n" + dbce.Message);
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
        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                frmLogin l = new frmLogin();
                this.Hide();
                l.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Form failed to load\n\n" + ex.Message);
            }
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
            try
            {
                frmMenu mn = new frmMenu();
                this.Hide();
                mn.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Form failed to load\n\n" + ex.Message);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    
    }
}
