using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace progAssigment2
{
    class dbConnect
    {
        SqlConnection myConnection;
        SqlCommand cmd;
        SqlDataReader reader;

        SqlDataAdapter adapter;
        public void OpenConnection()
        {
            try
            {
                myConnection = new SqlConnection();

                myConnection.ConnectionString = (@"Server=tcp:progassigments.database.windows.net,1433;Initial Catalog=progAssigment2;Persist Security Info=False;User ID=Dylan;Password=Zxcvbnm12;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                myConnection.Open();
                cmd = new SqlCommand();
            }
            catch
            {

            }

        }

        public void InsertInto(string insertInto)
        {
            OpenConnection();
            cmd.CommandText = insertInto;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = myConnection;
            cmd.ExecuteNonQuery();
        }

        public void Delete(string delete)
        {
            OpenConnection();
            cmd.CommandText = delete;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = myConnection;
            cmd.ExecuteNonQuery();
        }

    }


}
