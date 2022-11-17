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
    public partial class Registration_Form : Form
    {
        public List<ClientRegistration> Register = new List<ClientRegistration>();

        public FileHandler fH1 = new FileHandler();
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            string Username, Password, ConfirmPasssword;
            try
            {
                Username = txt_User.Text;
                Password = txt_Password.Text;
                ConfirmPasssword = txt_ConfirmPassword.Text;

                if (Password == ConfirmPasssword)
                {
                    ClientRegistration registration = new ClientRegistration(Username, Password);
                    Register.Add(registration);

                    fH1.WriteRegistration(Register);

                    Thread.Sleep(1500);
                    MessageBox.Show("Registration was successfull!");   
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                MessageBox.Show("Data could not be registered properly, please try again!");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lbl_Login_Click(object sender, EventArgs e)
        {
            new Login_Form().Show();
            this.Hide();
        }
        private void btn_ClrFields_Click(object sender, EventArgs e)
        {
            txt_User.Clear();
            txt_Password.Clear();
            txt_ConfirmPassword.Clear();
        }

        private void checkBox_ShwPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_ShwPassword.Checked)
            {
                txt_Password.PasswordChar = '\0';
                txt_ConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txt_Password.PasswordChar = '*';
                txt_ConfirmPassword.PasswordChar = '*';
            }
        }

        //PLEASE IGNORE THIS
        private void Registration_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
