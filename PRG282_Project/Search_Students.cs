using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PRG282_Project
{
    public partial class Search_Students : Form
    {
        public DataHandler handler = new DataHandler();
        public SqlConnection con;
        public Search_Students()
        {
            con = new SqlConnection("Data Source=DESKTOP-9K6ENBP\\SQLEXPRESS;Initial Catalog=PRG282_PROJECT_DB;Integrated Security=True");
            InitializeComponent();
        }

        private void btn_SearchForStudent_Click(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                dataGridView_SearchStd.DataSource = handler.SearchData(int.Parse(txt_StudentNo.Text));

                MessageBox.Show("Data Exists");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                MessageBox.Show("The data you are searching for does not exist!");
            }
            con.Close();
        }
    }
}
