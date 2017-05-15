//Dylan matthews 1509851
//frm Delete
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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }
        //
        //
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection("Server=tcp:progassigments.database.windows.net,1433;Initial Catalog=progAssigment2;Persist Security Info=False;User ID=Dylan;Password=Zxcvbnm12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;"); //connects to db on azure
                myConnection.Open();
                SqlCommand cmd = new SqlCommand();
                string del = txtDelete.Text;
                cmd.CommandText = "DELETE  FROM tblAppoinments WHERE '" + del + "'= contactNumber or PatientSurname='" + del + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = myConnection;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully deleted");
            }
            catch
            {
                MessageBox.Show("lost connection");
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
            frmMenu mn = new frmMenu();
            this.Hide();
            mn.Show();
        }
        //
        //

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin l = new frmLogin();
            l.Show();
        }
    }
}
