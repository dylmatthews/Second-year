//update appoinment
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
    public partial class frmUpdate : Form
    {
        public frmUpdate()
        {
            InitializeComponent();
        }
        //
        //
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Server=tcp:progassigments.database.windows.net,1433;Initial Catalog=progAssigment2;Persist Security Info=False;User ID=Dylan;Password=Zxcvbnm12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");  //connects to db on azure
            myConnection.Open();
            SqlCommand cmd = new SqlCommand();
            string search = txtSearchUpdate.Text;
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string date = dtpAppointmentDate.Value.ToShortDateString() + " " + cbbTime.Text;
            string number = txtPhoneNumber.Text;

            cmd.Parameters.AddWithValue("@search", search);
            cmd.Parameters.AddWithValue("@PatientName", name);
            cmd.Parameters.AddWithValue("@surname", surname);
            cmd.Parameters.AddWithValue("@dateTime", date);
            cmd.Parameters.AddWithValue("@number", number);
            cmd.CommandText = "UPDATE tblAppoinments SET PatientName=@PatientName, PatientSurname=@surname, contactNumber=@number, AppointmentDateTime=@dateTime  WHERE contactNumber=@search or PatientSurname=@search ";
           
            cmd.CommandType = CommandType.Text;
            cmd.Connection = myConnection;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated succesfull");
        }

        ///
        ////
        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMenu mn = new frmMenu();
            this.Hide();
            mn.Show();
        }
    }
}
