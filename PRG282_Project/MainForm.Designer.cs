namespace PRG282_Project
{
    partial class MainForm
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
            this.Navigation_Pane = new System.Windows.Forms.Panel();
            this.HeaderPane = new System.Windows.Forms.Panel();
            this.Content_Panel = new System.Windows.Forms.Panel();
            this.btn_InsertAndRead = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_CloseFrm = new System.Windows.Forms.Button();
            this.btn_LogOff = new System.Windows.Forms.Button();
            this.btn_ReadStudents = new System.Windows.Forms.Button();
            this.btn_SearchStudents = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_Heading = new System.Windows.Forms.Label();
            this.Navigation_Pane.SuspendLayout();
            this.HeaderPane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Navigation_Pane
            // 
            this.Navigation_Pane.BackColor = System.Drawing.Color.DarkViolet;
            this.Navigation_Pane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Navigation_Pane.Controls.Add(this.lbl_Heading);
            this.Navigation_Pane.Controls.Add(this.btn_SearchStudents);
            this.Navigation_Pane.Controls.Add(this.btn_ReadStudents);
            this.Navigation_Pane.Controls.Add(this.pictureBox5);
            this.Navigation_Pane.Controls.Add(this.pictureBox4);
            this.Navigation_Pane.Controls.Add(this.pictureBox6);
            this.Navigation_Pane.Controls.Add(this.pictureBox7);
            this.Navigation_Pane.Controls.Add(this.pictureBox3);
            this.Navigation_Pane.Controls.Add(this.pictureBox2);
            this.Navigation_Pane.Controls.Add(this.pictureBox1);
            this.Navigation_Pane.Controls.Add(this.btn_LogOff);
            this.Navigation_Pane.Controls.Add(this.btn_Delete);
            this.Navigation_Pane.Controls.Add(this.btn_Update);
            this.Navigation_Pane.Controls.Add(this.btn_InsertAndRead);
            this.Navigation_Pane.Dock = System.Windows.Forms.DockStyle.Left;
            this.Navigation_Pane.Location = new System.Drawing.Point(0, 30);
            this.Navigation_Pane.Name = "Navigation_Pane";
            this.Navigation_Pane.Size = new System.Drawing.Size(200, 491);
            this.Navigation_Pane.TabIndex = 0;
            // 
            // HeaderPane
            // 
            this.HeaderPane.BackColor = System.Drawing.Color.Black;
            this.HeaderPane.Controls.Add(this.btn_CloseFrm);
            this.HeaderPane.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPane.Location = new System.Drawing.Point(0, 0);
            this.HeaderPane.Name = "HeaderPane";
            this.HeaderPane.Size = new System.Drawing.Size(921, 30);
            this.HeaderPane.TabIndex = 1;
            // 
            // Content_Panel
            // 
            this.Content_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_Panel.Location = new System.Drawing.Point(200, 30);
            this.Content_Panel.Name = "Content_Panel";
            this.Content_Panel.Size = new System.Drawing.Size(721, 491);
            this.Content_Panel.TabIndex = 2;
            // 
            // btn_InsertAndRead
            // 
            this.btn_InsertAndRead.BackColor = System.Drawing.Color.Black;
            this.btn_InsertAndRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InsertAndRead.FlatAppearance.BorderSize = 0;
            this.btn_InsertAndRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsertAndRead.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InsertAndRead.ForeColor = System.Drawing.Color.White;
            this.btn_InsertAndRead.Location = new System.Drawing.Point(34, 174);
            this.btn_InsertAndRead.Name = "btn_InsertAndRead";
            this.btn_InsertAndRead.Size = new System.Drawing.Size(166, 36);
            this.btn_InsertAndRead.TabIndex = 0;
            this.btn_InsertAndRead.Text = "Create Students";
            this.btn_InsertAndRead.UseVisualStyleBackColor = false;
            this.btn_InsertAndRead.Click += new System.EventHandler(this.btn_InsertAndRead_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.Black;
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatAppearance.BorderSize = 0;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.Color.White;
            this.btn_Update.Location = new System.Drawing.Point(34, 230);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(166, 36);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "Update Students";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Black;
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatAppearance.BorderSize = 0;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.Color.White;
            this.btn_Delete.Location = new System.Drawing.Point(34, 285);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(166, 36);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "Delete Students";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_CloseFrm
            // 
            this.btn_CloseFrm.BackColor = System.Drawing.Color.Black;
            this.btn_CloseFrm.FlatAppearance.BorderSize = 0;
            this.btn_CloseFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseFrm.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseFrm.ForeColor = System.Drawing.Color.White;
            this.btn_CloseFrm.Location = new System.Drawing.Point(893, 3);
            this.btn_CloseFrm.Name = "btn_CloseFrm";
            this.btn_CloseFrm.Size = new System.Drawing.Size(28, 27);
            this.btn_CloseFrm.TabIndex = 0;
            this.btn_CloseFrm.Text = "X";
            this.btn_CloseFrm.UseVisualStyleBackColor = false;
            this.btn_CloseFrm.Click += new System.EventHandler(this.btn_CloseFrm_Click);
            // 
            // btn_LogOff
            // 
            this.btn_LogOff.BackColor = System.Drawing.Color.White;
            this.btn_LogOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LogOff.FlatAppearance.BorderSize = 0;
            this.btn_LogOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOff.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOff.ForeColor = System.Drawing.Color.Black;
            this.btn_LogOff.Location = new System.Drawing.Point(34, 455);
            this.btn_LogOff.Name = "btn_LogOff";
            this.btn_LogOff.Size = new System.Drawing.Size(166, 36);
            this.btn_LogOff.TabIndex = 0;
            this.btn_LogOff.Text = "Logout";
            this.btn_LogOff.UseVisualStyleBackColor = false;
            this.btn_LogOff.Click += new System.EventHandler(this.btn_LogOff_Click);
            // 
            // btn_ReadStudents
            // 
            this.btn_ReadStudents.BackColor = System.Drawing.Color.Black;
            this.btn_ReadStudents.FlatAppearance.BorderSize = 0;
            this.btn_ReadStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReadStudents.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ReadStudents.ForeColor = System.Drawing.Color.White;
            this.btn_ReadStudents.Location = new System.Drawing.Point(34, 339);
            this.btn_ReadStudents.Name = "btn_ReadStudents";
            this.btn_ReadStudents.Size = new System.Drawing.Size(166, 36);
            this.btn_ReadStudents.TabIndex = 6;
            this.btn_ReadStudents.Text = "Read Students";
            this.btn_ReadStudents.UseVisualStyleBackColor = false;
            this.btn_ReadStudents.Click += new System.EventHandler(this.btn_ReadStudents_Click);
            // 
            // btn_SearchStudents
            // 
            this.btn_SearchStudents.BackColor = System.Drawing.Color.Black;
            this.btn_SearchStudents.FlatAppearance.BorderSize = 0;
            this.btn_SearchStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SearchStudents.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_SearchStudents.ForeColor = System.Drawing.Color.White;
            this.btn_SearchStudents.Location = new System.Drawing.Point(34, 392);
            this.btn_SearchStudents.Name = "btn_SearchStudents";
            this.btn_SearchStudents.Size = new System.Drawing.Size(166, 36);
            this.btn_SearchStudents.TabIndex = 7;
            this.btn_SearchStudents.Text = "Search Students";
            this.btn_SearchStudents.UseVisualStyleBackColor = false;
            this.btn_SearchStudents.Click += new System.EventHandler(this.btn_SearchStudents_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Image = global::PRG282_Project.Properties.Resources.Logout_icon;
            this.pictureBox5.Location = new System.Drawing.Point(0, 455);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(38, 36);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Image = global::PRG282_Project.Properties.Resources.User_database_icon;
            this.pictureBox4.Location = new System.Drawing.Point(34, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(123, 124);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.White;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = global::PRG282_Project.Properties.Resources.Search_Students;
            this.pictureBox6.Location = new System.Drawing.Point(3, 392);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 36);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Image = global::PRG282_Project.Properties.Resources.Read_Students1;
            this.pictureBox7.Location = new System.Drawing.Point(0, 339);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(38, 36);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = global::PRG282_Project.Properties.Resources.Remove_user;
            this.pictureBox3.Location = new System.Drawing.Point(0, 285);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(38, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::PRG282_Project.Properties.Resources.Update_Icon;
            this.pictureBox2.Location = new System.Drawing.Point(0, 230);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::PRG282_Project.Properties.Resources.Icon_1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(38, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_Heading
            // 
            this.lbl_Heading.AutoSize = true;
            this.lbl_Heading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_Heading.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Heading.Location = new System.Drawing.Point(11, 126);
            this.lbl_Heading.Name = "lbl_Heading";
            this.lbl_Heading.Size = new System.Drawing.Size(174, 17);
            this.lbl_Heading.TabIndex = 8;
            this.lbl_Heading.Text = "Student Management DB";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 521);
            this.Controls.Add(this.Content_Panel);
            this.Controls.Add(this.Navigation_Pane);
            this.Controls.Add(this.HeaderPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Navigation_Pane.ResumeLayout(false);
            this.Navigation_Pane.PerformLayout();
            this.HeaderPane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Navigation_Pane;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_InsertAndRead;
        private System.Windows.Forms.Panel HeaderPane;
        private System.Windows.Forms.Panel Content_Panel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button btn_LogOff;
        private System.Windows.Forms.Button btn_CloseFrm;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button btn_ReadStudents;
        private System.Windows.Forms.Button btn_SearchStudents;
        private System.Windows.Forms.Label lbl_Heading;
    }
}