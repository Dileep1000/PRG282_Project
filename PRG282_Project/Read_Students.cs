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
    public partial class Read_Students : Form
    {
        public DataHandler handler = new DataHandler();
        public Read_Students()
        {
            InitializeComponent();
        }
        
        private void btn_DisplayAllStudents_Click(object sender, EventArgs e)
        {
            dataGridView_StudentData.DataSource = handler.DisplayStudents();
        }
    }
}
