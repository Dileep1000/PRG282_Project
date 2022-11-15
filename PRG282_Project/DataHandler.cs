using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace PRG282_Project
{
    public class DataHandler
    {
        string connection = "Data Source=DESKTOP-9K6ENBP\\SQLEXPRESS;Initial Catalog=PRG282_PROJECT_DB;Integrated Security=True";

        public DataHandler() 
        {

        }
        public DataTable DisplayStudents() 
        {
            SqlConnection con = new SqlConnection(connection);

            SqlDataAdapter adapter = new SqlDataAdapter("spReadAllData", con);

            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }
        public void UpdateData() 
        {
            
        }
    }
}
