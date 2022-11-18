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
        public BindingSource bSource = new BindingSource();
        
        public Read_Students()
        {
            InitializeComponent();
        }
        
        private void btn_DisplayAllStudents_Click(object sender, EventArgs e)
        {
            bSource.DataSource = handler.DisplayStudents();

            dataGridView_StudentData.DataSource = bSource;

            /*
            DataTable dt = handler.DisplayStudents();

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                DataGridViewTextBoxColumn studentNo = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(studentNo);

                //add two columns here
                DataGridViewTextBoxColumn Name = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(Name);

                DataGridViewTextBoxColumn Surname = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(Surname);

                Bitmap img;
                img = new Bitmap(dt.Rows[i].ItemArray[3].ToString());
                this.Controls.Add(dataGridView_StudentData);
                DataGridViewImageColumn imageCol = new DataGridViewImageColumn();
                dataGridView_StudentData.Columns.Add(imageCol);
                imageCol.ImageLayout = DataGridViewImageCellLayout.Zoom;

                // add rest of columns here
                DataGridViewTextBoxColumn DateOfBirth = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(DateOfBirth);

                DataGridViewTextBoxColumn Gender = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(Gender);

                DataGridViewTextBoxColumn Phone = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(Phone);

                DataGridViewTextBoxColumn Address = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(Address);

                DataGridViewTextBoxColumn ModuleCode = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(ModuleCode);

                DataGridViewTextBoxColumn ModuleName = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(ModuleName);

                DataGridViewTextBoxColumn ModuleDescription = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(ModuleDescription);

                DataGridViewTextBoxColumn OnlineResources = new DataGridViewTextBoxColumn();
                dataGridView_StudentData.Columns.Add(OnlineResources);

                dataGridView_StudentData.Rows.Add();

                dataGridView_StudentData.Rows[i].Cells[0].Value = dt.Rows[i].ItemArray[0];
                dataGridView_StudentData.Rows[i].Cells[1].Value = dt.Rows[i].ItemArray[1];
                dataGridView_StudentData.Rows[i].Cells[2].Value = dt.Rows[i].ItemArray[2];
                dataGridView_StudentData.Rows[i].Cells[3].Value = img;
                dataGridView_StudentData.Rows[i].Cells[4].Value = dt.Rows[i].ItemArray[4];
                dataGridView_StudentData.Rows[i].Cells[5].Value = dt.Rows[i].ItemArray[5];
                dataGridView_StudentData.Rows[i].Cells[6].Value = dt.Rows[i].ItemArray[6];
                dataGridView_StudentData.Rows[i].Cells[7].Value = dt.Rows[i].ItemArray[7];
                dataGridView_StudentData.Rows[i].Cells[8].Value = dt.Rows[i].ItemArray[8];
                dataGridView_StudentData.Rows[i].Cells[9].Value = dt.Rows[i].ItemArray[9];
                dataGridView_StudentData.Rows[i].Cells[10].Value = dt.Rows[i].ItemArray[10];
                dataGridView_StudentData.Rows[i].Cells[11].Value = dt.Rows[i].ItemArray[11];
                dataGridView_StudentData.Rows[i].Cells[12].Value = dt.Rows[i].ItemArray[12];
            }

            //dataGridView_StudentData.DataSource = handler.DisplayStudents();
            */
        }

        /*
        private void dataGridView_StudentData_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView_StudentData_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.ColumnIndex == 3)
            //{
            //    using (Image img = Image.FromFile(@"C:\Users\Dilee\Desktop\Coughing cat.png"))
            //    {
            //        e.Graphics.DrawImage(img, e.CellBounds.Left, e.CellBounds.Top - 1, e.CellBounds.Right, e.CellBounds.Bottom - 1);

            //        e.PaintContent(e.ClipBounds);
            //        e.Handled = true;
            //    }
            //}
        }
        */
    }
}
