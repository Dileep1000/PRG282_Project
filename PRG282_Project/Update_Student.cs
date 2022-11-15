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
    public partial class Update_Student : Form
    {
        public SqlConnection con;
        public string ImageLocation = "";
        public Update_Student()
        {
            con = new SqlConnection("Data Source=DESKTOP-9K6ENBP\\SQLEXPRESS;Initial Catalog=PRG282_PROJECT_DB;Integrated Security=True");
            InitializeComponent();
        }

        private void btn_UpdateStudent_Click(object sender, EventArgs e)
        {

        }

        private void btn_BrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = " png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ImageLocation = openFileDialog.FileName.ToString();
                pictureBox_StdImage.ImageLocation = ImageLocation;
            }
        }
    }
}
