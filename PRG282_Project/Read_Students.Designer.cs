namespace PRG282_Project
{
    partial class Read_Students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ReadStudents = new System.Windows.Forms.Label();
            this.btn_DisplayAllStudents = new System.Windows.Forms.Button();
            this.dataGridView_StudentData = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentData)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ReadStudents
            // 
            this.lbl_ReadStudents.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ReadStudents.AutoSize = true;
            this.lbl_ReadStudents.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ReadStudents.Location = new System.Drawing.Point(210, 49);
            this.lbl_ReadStudents.Name = "lbl_ReadStudents";
            this.lbl_ReadStudents.Size = new System.Drawing.Size(269, 24);
            this.lbl_ReadStudents.TabIndex = 1;
            this.lbl_ReadStudents.Text = "Student Data Display Section";
            // 
            // btn_DisplayAllStudents
            // 
            this.btn_DisplayAllStudents.BackColor = System.Drawing.Color.Bisque;
            this.btn_DisplayAllStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DisplayAllStudents.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_DisplayAllStudents.Location = new System.Drawing.Point(251, 399);
            this.btn_DisplayAllStudents.Name = "btn_DisplayAllStudents";
            this.btn_DisplayAllStudents.Size = new System.Drawing.Size(216, 46);
            this.btn_DisplayAllStudents.TabIndex = 3;
            this.btn_DisplayAllStudents.Text = "Display All Students";
            this.btn_DisplayAllStudents.UseVisualStyleBackColor = false;
            this.btn_DisplayAllStudents.Click += new System.EventHandler(this.btn_DisplayAllStudents_Click);
            // 
            // dataGridView_StudentData
            // 
            this.dataGridView_StudentData.AllowUserToAddRows = false;
            this.dataGridView_StudentData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StudentData.Location = new System.Drawing.Point(39, 85);
            this.dataGridView_StudentData.Name = "dataGridView_StudentData";
            this.dataGridView_StudentData.Size = new System.Drawing.Size(645, 298);
            this.dataGridView_StudentData.TabIndex = 2;
            this.dataGridView_StudentData.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dataGridView_StudentData_CellPainting);
            this.dataGridView_StudentData.Paint += new System.Windows.Forms.PaintEventHandler(this.dataGridView_StudentData_Paint);
            // 
            // Read_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(721, 491);
            this.Controls.Add(this.btn_DisplayAllStudents);
            this.Controls.Add(this.dataGridView_StudentData);
            this.Controls.Add(this.lbl_ReadStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Read_Students";
            this.Text = "Read_Students";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ReadStudents;
        private System.Windows.Forms.Button btn_DisplayAllStudents;
        private System.Windows.Forms.DataGridView dataGridView_StudentData;
    }
}