using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

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
       
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("spReadAllData", con);
                SqlDataReader read;
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dataTable = new DataTable();

                con.Open();

                using (read = cmd.ExecuteReader())
                {
                    dataTable.Load(read);
                    return dataTable;
                }
            }          
        }
        public void InsertData(int StudNo, string Name, string Surname, byte[] picture, string DateOfBirth, string Gender, int Phone, string Address, string ModCode, string ModName, string ModDescrip, string Resources) 
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("spInsertData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentNo ", StudNo);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Surname", Surname);
                cmd.Parameters.AddWithValue("@Picture", picture);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@ModuleCode", ModCode);
                cmd.Parameters.AddWithValue("@ModuleName", ModName);
                cmd.Parameters.AddWithValue("@ModuleDescription", ModDescrip);
                cmd.Parameters.AddWithValue("@OnlineResources", Resources);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void UpdateData(int StudNo, string Name, string Surname, byte[] picture, string DateOfBirth, string Gender, int Phone, string Address, string ModCode, string ModName, string ModDescrip, string Resources) 
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("spUpdateData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@StudentNo ", StudNo);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Surname", Surname);
                cmd.Parameters.AddWithValue("@Picture", picture);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@ModuleCode", ModCode);
                cmd.Parameters.AddWithValue("@ModuleName", ModName);
                cmd.Parameters.AddWithValue("@ModuleDescription", ModDescrip);
                cmd.Parameters.AddWithValue("@OnlineResources", Resources);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void DeleteData(int StudentNumber) 
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("spDeleteData", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentNo", StudentNumber);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public DataTable SearchData(int StudentNumber) 
        {
            using (SqlConnection con = new SqlConnection(connection))
            {
                SqlCommand cmd = new SqlCommand("spSearchData", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@StudentNo", StudentNumber);

                con.Open();
                DataTable dt = new DataTable();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    dt.Load(read);
                    return dt;
                }
            }
        }
    }
}
