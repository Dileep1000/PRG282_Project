namespace PRG282_Project
{
    partial class Registration_Form
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_GetStarted = new System.Windows.Forms.Label();
            this.lbl_usrName = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.lbl_Confirm = new System.Windows.Forms.Label();
            this.txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.checkBox_ShwPassword = new System.Windows.Forms.CheckBox();
            this.btn_Register = new System.Windows.Forms.Button();
            this.btn_ClrFields = new System.Windows.Forms.Button();
            this.lbl_AlreadyHaveAnAcc = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(87)))), ((int)(((byte)(174)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.Location = new System.Drawing.Point(258, -1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(31, 27);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.Text = "X";
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_GetStarted
            // 
            this.lbl_GetStarted.AutoSize = true;
            this.lbl_GetStarted.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_GetStarted.ForeColor = System.Drawing.Color.Black;
            this.lbl_GetStarted.Location = new System.Drawing.Point(70, 34);
            this.lbl_GetStarted.Name = "lbl_GetStarted";
            this.lbl_GetStarted.Size = new System.Drawing.Size(149, 31);
            this.lbl_GetStarted.TabIndex = 1;
            this.lbl_GetStarted.Text = "Get Started";
            // 
            // lbl_usrName
            // 
            this.lbl_usrName.AutoSize = true;
            this.lbl_usrName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usrName.ForeColor = System.Drawing.Color.Black;
            this.lbl_usrName.Location = new System.Drawing.Point(34, 90);
            this.lbl_usrName.Name = "lbl_usrName";
            this.lbl_usrName.Size = new System.Drawing.Size(73, 17);
            this.lbl_usrName.TabIndex = 2;
            this.lbl_usrName.Text = "Username:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.Color.Black;
            this.lbl_password.Location = new System.Drawing.Point(34, 151);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(70, 17);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password:";
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_User.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_User.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.Location = new System.Drawing.Point(37, 110);
            this.txt_User.Multiline = true;
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(216, 28);
            this.txt_User.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Password.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.Location = new System.Drawing.Point(37, 171);
            this.txt_Password.Multiline = true;
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(216, 28);
            this.txt_Password.TabIndex = 3;
            // 
            // lbl_Confirm
            // 
            this.lbl_Confirm.AutoSize = true;
            this.lbl_Confirm.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Confirm.ForeColor = System.Drawing.Color.Black;
            this.lbl_Confirm.Location = new System.Drawing.Point(34, 221);
            this.lbl_Confirm.Name = "lbl_Confirm";
            this.lbl_Confirm.Size = new System.Drawing.Size(124, 17);
            this.lbl_Confirm.TabIndex = 2;
            this.lbl_Confirm.Text = "Confirm Password:";
            // 
            // txt_ConfirmPassword
            // 
            this.txt_ConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_ConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ConfirmPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ConfirmPassword.Location = new System.Drawing.Point(37, 241);
            this.txt_ConfirmPassword.Multiline = true;
            this.txt_ConfirmPassword.Name = "txt_ConfirmPassword";
            this.txt_ConfirmPassword.PasswordChar = '*';
            this.txt_ConfirmPassword.Size = new System.Drawing.Size(216, 28);
            this.txt_ConfirmPassword.TabIndex = 3;
            // 
            // checkBox_ShwPassword
            // 
            this.checkBox_ShwPassword.AutoSize = true;
            this.checkBox_ShwPassword.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShwPassword.ForeColor = System.Drawing.Color.Black;
            this.checkBox_ShwPassword.Location = new System.Drawing.Point(37, 275);
            this.checkBox_ShwPassword.Name = "checkBox_ShwPassword";
            this.checkBox_ShwPassword.Size = new System.Drawing.Size(108, 17);
            this.checkBox_ShwPassword.TabIndex = 4;
            this.checkBox_ShwPassword.Text = "Show Password";
            this.checkBox_ShwPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShwPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShwPassword_CheckedChanged);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.White;
            this.btn_Register.Location = new System.Drawing.Point(37, 330);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(216, 35);
            this.btn_Register.TabIndex = 5;
            this.btn_Register.Text = "Register";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // btn_ClrFields
            // 
            this.btn_ClrFields.BackColor = System.Drawing.Color.White;
            this.btn_ClrFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClrFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClrFields.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClrFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ClrFields.Location = new System.Drawing.Point(37, 388);
            this.btn_ClrFields.Name = "btn_ClrFields";
            this.btn_ClrFields.Size = new System.Drawing.Size(216, 35);
            this.btn_ClrFields.TabIndex = 5;
            this.btn_ClrFields.Text = "Clear Fields";
            this.btn_ClrFields.UseVisualStyleBackColor = false;
            this.btn_ClrFields.Click += new System.EventHandler(this.btn_ClrFields_Click);
            // 
            // lbl_AlreadyHaveAnAcc
            // 
            this.lbl_AlreadyHaveAnAcc.AutoSize = true;
            this.lbl_AlreadyHaveAnAcc.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AlreadyHaveAnAcc.ForeColor = System.Drawing.Color.Black;
            this.lbl_AlreadyHaveAnAcc.Location = new System.Drawing.Point(73, 443);
            this.lbl_AlreadyHaveAnAcc.Name = "lbl_AlreadyHaveAnAcc";
            this.lbl_AlreadyHaveAnAcc.Size = new System.Drawing.Size(151, 15);
            this.lbl_AlreadyHaveAnAcc.TabIndex = 6;
            this.lbl_AlreadyHaveAnAcc.Text = "Already Have an Account?";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Login.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lbl_Login.Location = new System.Drawing.Point(103, 471);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(76, 17);
            this.lbl_Login.TabIndex = 6;
            this.lbl_Login.Text = "Login Here";
            this.lbl_Login.Click += new System.EventHandler(this.lbl_Login_Click);
            // 
            // Registration_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(288, 544);
            this.Controls.Add(this.lbl_Login);
            this.Controls.Add(this.lbl_AlreadyHaveAnAcc);
            this.Controls.Add(this.btn_ClrFields);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.checkBox_ShwPassword);
            this.Controls.Add(this.txt_ConfirmPassword);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.lbl_Confirm);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_usrName);
            this.Controls.Add(this.lbl_GetStarted);
            this.Controls.Add(this.btn_Close);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(165)))), ((int)(((byte)(169)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Page";
            this.Load += new System.EventHandler(this.Registration_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Label lbl_GetStarted;
        private System.Windows.Forms.Label lbl_usrName;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Label lbl_Confirm;
        private System.Windows.Forms.TextBox txt_ConfirmPassword;
        private System.Windows.Forms.CheckBox checkBox_ShwPassword;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_ClrFields;
        private System.Windows.Forms.Label lbl_AlreadyHaveAnAcc;
        private System.Windows.Forms.Label lbl_Login;
    }
}

