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
using System.IO;


namespace PRG282_Project
{
    public partial class Create_Student : Form
    {
        public DataHandler handler = new DataHandler();
        public SqlConnection con;
        public string imgLocation;
        public Create_Student()
        {    
            con = new SqlConnection("Data Source=DESKTOP-9K6ENBP\\SQLEXPRESS;Initial Catalog=PRG282_PROJECT_DB;Integrated Security=True");
            InitializeComponent();
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            int StudentNumber = int.Parse(txt_StudentNo.Text); 
            int Phone = int.Parse(txt_Phone.Text);

            byte[] Images = File.ReadAllBytes(imgLocation);
            
            con.Open();

            try
            {

                handler.InsertData(StudentNumber, txt_StdName.Text, txt_StdSurname.Text, Images, txt_Birthdate.Text, txt_Gender.Text
                    , Phone, txt_Address.Text, txt_ModCode.Text, txt_ModName.Text, txt_ModDescrip.Text, 
                    txt_Resources.Text); 
                //command.Parameters.Add(new SqlParameter("@Images", img));
                //command.Parameters.Add("@Images", SqlDbType.VarBinary, 8000).Value = img;

                MessageBox.Show("Data has been successfully inserted into the database");

                    txt_StudentNo.Clear();
                    txt_StdName.Clear();
                    txt_StdSurname.Clear();
                    txt_Gender.Clear();
                    txt_Address.Clear();
                    txt_Birthdate.Clear();
                    txt_ModCode.Clear();
                    txt_ModName.Clear();
                    txt_ModDescrip.Clear();
                    txt_Phone.Clear();
                    txt_Resources.Clear();
                    pictureBox_StdImage = null;         
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                MessageBox.Show("The data could not be inserted into the database!", "Please try again.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btn_BrowseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = " png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = openFileDialog.FileName.ToString();
                pictureBox_StdImage.ImageLocation = imgLocation;                
            }
        }
    }
}
