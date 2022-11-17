namespace PRG282_Project
{
    partial class Delete_Student
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
            this.dataGridView_DeleteStd = new System.Windows.Forms.DataGridView();
            this.btn_DeleteStudent = new System.Windows.Forms.Button();
            this.txt_StudentNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_StdNo = new System.Windows.Forms.Label();
            this.lbl_DeleteStudent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeleteStd)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_DeleteStd
            // 
            this.dataGridView_DeleteStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DeleteStd.Location = new System.Drawing.Point(53, 154);
            this.dataGridView_DeleteStd.Name = "dataGridView_DeleteStd";
            this.dataGridView_DeleteStd.Size = new System.Drawing.Size(615, 270);
            this.dataGridView_DeleteStd.TabIndex = 41;
            // 
            // btn_DeleteStudent
            // 
            this.btn_DeleteStudent.BackColor = System.Drawing.Color.Bisque;
            this.btn_DeleteStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteStudent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DeleteStudent.Location = new System.Drawing.Point(438, 94);
            this.btn_DeleteStudent.Name = "btn_DeleteStudent";
            this.btn_DeleteStudent.Size = new System.Drawing.Size(103, 33);
            this.btn_DeleteStudent.TabIndex = 40;
            this.btn_DeleteStudent.Text = "Delete";
            this.btn_DeleteStudent.UseVisualStyleBackColor = false;
            this.btn_DeleteStudent.Click += new System.EventHandler(this.btn_DeleteStudent_Click);
            // 
            // txt_StudentNo
            // 
            this.txt_StudentNo.Location = new System.Drawing.Point(273, 101);
            this.txt_StudentNo.Name = "txt_StudentNo";
            this.txt_StudentNo.Size = new System.Drawing.Size(143, 20);
            this.txt_StudentNo.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(258, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 37;
            // 
            // lbl_StdNo
            // 
            this.lbl_StdNo.AutoSize = true;
            this.lbl_StdNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StdNo.Location = new System.Drawing.Point(172, 101);
            this.lbl_StdNo.Name = "lbl_StdNo";
            this.lbl_StdNo.Size = new System.Drawing.Size(86, 17);
            this.lbl_StdNo.TabIndex = 38;
            this.lbl_StdNo.Text = "Student No:";
            // 
            // lbl_DeleteStudent
            // 
            this.lbl_DeleteStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_DeleteStudent.AutoSize = true;
            this.lbl_DeleteStudent.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeleteStudent.Location = new System.Drawing.Point(244, 32);
            this.lbl_DeleteStudent.Name = "lbl_DeleteStudent";
            this.lbl_DeleteStudent.Size = new System.Drawing.Size(212, 24);
            this.lbl_DeleteStudent.TabIndex = 36;
            this.lbl_DeleteStudent.Text = "Delete Student Section";
            // 
            // Delete_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(721, 491);
            this.Controls.Add(this.dataGridView_DeleteStd);
            this.Controls.Add(this.btn_DeleteStudent);
            this.Controls.Add(this.txt_StudentNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_StdNo);
            this.Controls.Add(this.lbl_DeleteStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Delete_Student";
            this.Text = "Delete_Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DeleteStd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_DeleteStd;
        private System.Windows.Forms.Button btn_DeleteStudent;
        private System.Windows.Forms.TextBox txt_StudentNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_StdNo;
        private System.Windows.Forms.Label lbl_DeleteStudent;
    }
}