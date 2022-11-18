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
    public partial class Delete_Student : Form
    {
        public DataHandler handler = new DataHandler();
        public BindingSource bSource = new BindingSource();
        public SqlConnection con;
        public Delete_Student()
        {
            con = new SqlConnection("Data Source=DESKTOP-9K6ENBP\\SQLEXPRESS;Initial Catalog=PRG282_PROJECT_DB;Integrated Security=True");
            InitializeComponent();
        }

        private void btn_DeleteStudent_Click(object sender, EventArgs e)
        {
            con.Open();

            try
            {
                handler.DeleteData(int.Parse(txt_StudentNo.Text));
            
                MessageBox.Show("Data has been successfully deleted");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                MessageBox.Show("The data could not be deleted!", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            bSource.DataSource = handler.DisplayStudents();

            dataGridView_DeleteStd.DataSource = bSource;
        }
    }
}
