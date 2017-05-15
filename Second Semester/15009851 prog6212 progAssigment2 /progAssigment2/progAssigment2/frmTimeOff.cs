/// didnt complete this page would be to much redundency
////
////
///

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
    public partial class frmTimeOff : Form
    {
        public frmTimeOff()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Server=tcp:progassigments.database.windows.net,1433;Initial Catalog=progAssigment2;Persist Security Info=False;User ID=Dylan;Password=Zxcvbnm12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                   
            if (cbbTime.Text.Equals("full day"))
            {
                try
                {
                    
                    // dbConnect db = new dbConnect();

                    myConnection.Open();
                    SqlCommand cmd = new SqlCommand();
                    string name = "day off";
                    string surname = "day off";
                    string date = dtpAppointmentDate.Value.ToShortDateString() + " 09:00"  ;
                    string number = "day off";


                    cmd.Parameters.AddWithValue("@PatientName", name);
                    cmd.Parameters.AddWithValue("@surname", surname);
                    cmd.Parameters.AddWithValue("@dateTime", date);
                    cmd.Parameters.AddWithValue("@number", number);
                    cmd.CommandText = "Insert into tblAppoinments values (@PatientName, @surname,  @number,@dateTime)";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = myConnection;
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException Ex)
                {
                    MessageBox.Show("That appoinment date and time has been taken\n\n" + Ex.Message);
                }

            }
        }
    }
}
