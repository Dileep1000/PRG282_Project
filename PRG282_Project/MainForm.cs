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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void loadform(object Form)
        {
            if(this.Content_Panel.Controls.Count > 0)
                this.Content_Panel.Controls.RemoveAt(0);
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.Content_Panel.Controls.Add(form);
            this.Content_Panel.Tag = form;
            form.Show();
        }

        private void btn_InsertAndRead_Click(object sender, EventArgs e)
        {
            loadform(new Create_Student());
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            loadform(new Update_Student());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            loadform(new Delete_Student());
        }

        private void btn_CloseFrm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form form = new Login_Form();
            form.ShowDialog();
        }

        private void btn_LogOff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Form form = new Login_Form();
            form.ShowDialog();
        }


        //IGNORE THIS PART PLEASE 
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void btn_ReadStudents_Click(object sender, EventArgs e)
        {
            loadform(new Read_Students());
        }

        private void btn_SearchStudents_Click(object sender, EventArgs e)
        {
            loadform(new Search_Students());
        }

        //IGNORE THIS PART PLEASE AS WELL PLEASE
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
