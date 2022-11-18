namespace PRG282_Project
{
    partial class Search_Students
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
            this.lbl_SearchStudent = new System.Windows.Forms.Label();
            this.txt_StudentNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_StdNo = new System.Windows.Forms.Label();
            this.btn_SearchForStudent = new System.Windows.Forms.Button();
            this.dataGridView_SearchStd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchStd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_SearchStudent
            // 
            this.lbl_SearchStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_SearchStudent.AutoSize = true;
            this.lbl_SearchStudent.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SearchStudent.Location = new System.Drawing.Point(240, 27);
            this.lbl_SearchStudent.Name = "lbl_SearchStudent";
            this.lbl_SearchStudent.Size = new System.Drawing.Size(217, 24);
            this.lbl_SearchStudent.TabIndex = 7;
            this.lbl_SearchStudent.Text = "Search Student Section";
            // 
            // txt_StudentNo
            // 
            this.txt_StudentNo.Location = new System.Drawing.Point(269, 96);
            this.txt_StudentNo.Name = "txt_StudentNo";
            this.txt_StudentNo.Size = new System.Drawing.Size(143, 20);
            this.txt_StudentNo.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 21;
            // 
            // lbl_StdNo
            // 
            this.lbl_StdNo.AutoSize = true;
            this.lbl_StdNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StdNo.Location = new System.Drawing.Point(168, 96);
            this.lbl_StdNo.Name = "lbl_StdNo";
            this.lbl_StdNo.Size = new System.Drawing.Size(86, 17);
            this.lbl_StdNo.TabIndex = 22;
            this.lbl_StdNo.Text = "Student No:";
            // 
            // btn_SearchForStudent
            // 
            this.btn_SearchForStudent.BackColor = System.Drawing.Color.Bisque;
            this.btn_SearchForStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchForStudent.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SearchForStudent.Location = new System.Drawing.Point(434, 89);
            this.btn_SearchForStudent.Name = "btn_SearchForStudent";
            this.btn_SearchForStudent.Size = new System.Drawing.Size(103, 33);
            this.btn_SearchForStudent.TabIndex = 34;
            this.btn_SearchForStudent.Text = "Search";
            this.btn_SearchForStudent.UseVisualStyleBackColor = false;
            this.btn_SearchForStudent.Click += new System.EventHandler(this.btn_SearchForStudent_Click);
            // 
            // dataGridView_SearchStd
            // 
            this.dataGridView_SearchStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_SearchStd.Location = new System.Drawing.Point(49, 168);
            this.dataGridView_SearchStd.Name = "dataGridView_SearchStd";
            this.dataGridView_SearchStd.Size = new System.Drawing.Size(615, 251);
            this.dataGridView_SearchStd.TabIndex = 35;
            // 
            // Search_Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(721, 491);
            this.Controls.Add(this.dataGridView_SearchStd);
            this.Controls.Add(this.btn_SearchForStudent);
            this.Controls.Add(this.txt_StudentNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_StdNo);
            this.Controls.Add(this.lbl_SearchStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search_Students";
            this.Text = "Search_Students";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_SearchStd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_SearchStudent;
        private System.Windows.Forms.TextBox txt_StudentNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_StdNo;
        private System.Windows.Forms.Button btn_SearchForStudent;
        private System.Windows.Forms.DataGridView dataGridView_SearchStd;
    }
}