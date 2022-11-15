using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG282_Project
{
    public partial class Registration_Form : Form
    {
        public Registration_Form()
        {
            InitializeComponent();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (txt_User.Text == " " && txt_Password.Text == " " && txt_ConfirmPassword.Text == " ")
            {
                MessageBox.Show("Please fill all the fields to register successfully!", "Registration was unsuccessfull.", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
