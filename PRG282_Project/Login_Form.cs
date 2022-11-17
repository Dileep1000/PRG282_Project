using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PRG282_Project
{
    public partial class Login_Form : Form
    {
        
        //Creating a list using the ClientCredentials class
        public List<ClientCredentials> creds = new List<ClientCredentials>();

        //Making use of a filehandler class to perform write operation to text file
        public FileHandler fH = new FileHandler();
        

        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void btn_CloseFrm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string Username = "BelgiumCampusITversity", Password = "Programming";
            

            if (txt_UserName.Text == Username && txt_PasswordLogin.Text == Password)
            {
                ClientCredentials credentials = new ClientCredentials(Username, Password);
                creds.Add(credentials);

                fH.Write(creds);

                Thread.Sleep(1500);
                MessageBox.Show("Logged in successfully!");

                Thread.Sleep(2000);
                MainForm form = new MainForm();
                form.ShowDialog();
                this.Hide();
            }
            else if (txt_UserName.Text != Username || txt_PasswordLogin.Text != Password)
            {
                MessageBox.Show("This account does not exist! Click Register below to Redirect to Registration Page to Create a New Account.");
            }
        }

        private void btn_ClrFields_Click(object sender, EventArgs e)
        {
            txt_UserName.Clear();
            txt_PasswordLogin.Clear();
        }

        private void checkBox_ShwPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShwPassword.Checked)
            {
                txt_PasswordLogin.PasswordChar = '\0';
            }
            else
            {
                txt_PasswordLogin.PasswordChar = '*';
            }
        }

        private void lbl_Register_Click(object sender, EventArgs e)
        {
            new Registration_Form().Show();
            this.Hide();
        }
    }
}
