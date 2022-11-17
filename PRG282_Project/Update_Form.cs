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
    public partial class Update_Form : Form
    {
        public Update_Form()
        {
            InitializeComponent();
        }

        private void update_studentbtn_Click(object sender, EventArgs e)
        {
            DataHandler dt = new DataHandler();
            dt.UpdateDetails(
            int.Parse(txt_StudentNou.Text),
               txt_StdNameu.Text,
                txt_StdSurnameu.Text,
                txt_Birthdateu.Text,
                txt_Genderu.Text,
                Student_Imgu.Text,
               int.Parse(txt_Phoneu.Text),
                txt_Addressu.Text,
                txt_ModCodeu.Text,
               txt_ModNameu.Text, txt_ModDescripu.Text, txt_Resourcesu.Text);
        }
    }
}
