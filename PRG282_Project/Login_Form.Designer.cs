namespace PRG282_Project
{
    partial class Login_Form
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
            this.lbl_Register = new System.Windows.Forms.Label();
            this.lbl_DoNotHaveAnAcc = new System.Windows.Forms.Label();
            this.btn_ClrFields = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.checkBox_ShwPassword = new System.Windows.Forms.CheckBox();
            this.txt_PasswordLogin = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.label_usrName = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.btn_CloseFrm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_Register.Font = new System.Drawing.Font("Nirmala UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.lbl_Register.Location = new System.Drawing.Point(104, 409);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(91, 17);
            this.lbl_Register.TabIndex = 17;
            this.lbl_Register.Text = "Register Here";
            this.lbl_Register.Click += new System.EventHandler(this.lbl_Register_Click);
            // 
            // lbl_DoNotHaveAnAcc
            // 
            this.lbl_DoNotHaveAnAcc.AutoSize = true;
            this.lbl_DoNotHaveAnAcc.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DoNotHaveAnAcc.ForeColor = System.Drawing.Color.Black;
            this.lbl_DoNotHaveAnAcc.Location = new System.Drawing.Point(81, 383);
            this.lbl_DoNotHaveAnAcc.Name = "lbl_DoNotHaveAnAcc";
            this.lbl_DoNotHaveAnAcc.Size = new System.Drawing.Size(140, 15);
            this.lbl_DoNotHaveAnAcc.TabIndex = 18;
            this.lbl_DoNotHaveAnAcc.Text = "Don\'t Have an Account?";
            // 
            // btn_ClrFields
            // 
            this.btn_ClrFields.BackColor = System.Drawing.Color.White;
            this.btn_ClrFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ClrFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ClrFields.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ClrFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_ClrFields.Location = new System.Drawing.Point(39, 330);
            this.btn_ClrFields.Name = "btn_ClrFields";
            this.btn_ClrFields.Size = new System.Drawing.Size(216, 35);
            this.btn_ClrFields.TabIndex = 15;
            this.btn_ClrFields.Text = "Clear Fields";
            this.btn_ClrFields.UseVisualStyleBackColor = false;
            this.btn_ClrFields.Click += new System.EventHandler(this.btn_ClrFields_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(86)))), ((int)(((byte)(174)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.FlatAppearance.BorderSize = 0;
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Login.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(39, 272);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(216, 35);
            this.btn_Login.TabIndex = 16;
            this.btn_Login.Text = "LOGIN";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // checkBox_ShwPassword
            // 
            this.checkBox_ShwPassword.AutoSize = true;
            this.checkBox_ShwPassword.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_ShwPassword.ForeColor = System.Drawing.Color.Black;
            this.checkBox_ShwPassword.Location = new System.Drawing.Point(39, 237);
            this.checkBox_ShwPassword.Name = "checkBox_ShwPassword";
            this.checkBox_ShwPassword.Size = new System.Drawing.Size(108, 17);
            this.checkBox_ShwPassword.TabIndex = 14;
            this.checkBox_ShwPassword.Text = "Show Password";
            this.checkBox_ShwPassword.UseVisualStyleBackColor = true;
            this.checkBox_ShwPassword.CheckedChanged += new System.EventHandler(this.checkBox_ShwPassword_CheckedChanged);
            // 
            // txt_PasswordLogin
            // 
            this.txt_PasswordLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_PasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_PasswordLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PasswordLogin.Location = new System.Drawing.Point(39, 191);
            this.txt_PasswordLogin.Multiline = true;
            this.txt_PasswordLogin.Name = "txt_PasswordLogin";
            this.txt_PasswordLogin.PasswordChar = '*';
            this.txt_PasswordLogin.Size = new System.Drawing.Size(216, 28);
            this.txt_PasswordLogin.TabIndex = 12;
            // 
            // txt_UserName
            // 
            this.txt_UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txt_UserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_UserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserName.Location = new System.Drawing.Point(39, 130);
            this.txt_UserName.Multiline = true;
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(216, 28);
            this.txt_UserName.TabIndex = 13;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.Black;
            this.label_password.Location = new System.Drawing.Point(36, 171);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(70, 17);
            this.label_password.TabIndex = 9;
            this.label_password.Text = "Password:";
            // 
            // label_usrName
            // 
            this.label_usrName.AutoSize = true;
            this.label_usrName.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usrName.ForeColor = System.Drawing.Color.Black;
            this.label_usrName.Location = new System.Drawing.Point(36, 110);
            this.label_usrName.Name = "label_usrName";
            this.label_usrName.Size = new System.Drawing.Size(73, 17);
            this.label_usrName.TabIndex = 10;
            this.label_usrName.Text = "Username:";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.Black;
            this.label_login.Location = new System.Drawing.Point(90, 51);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(104, 31);
            this.label_login.TabIndex = 7;
            this.label_login.Text = "LOGIN";
            // 
            // btn_CloseFrm
            // 
            this.btn_CloseFrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(87)))), ((int)(((byte)(174)))));
            this.btn_CloseFrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CloseFrm.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CloseFrm.ForeColor = System.Drawing.Color.White;
            this.btn_CloseFrm.Location = new System.Drawing.Point(258, -1);
            this.btn_CloseFrm.Name = "btn_CloseFrm";
            this.btn_CloseFrm.Size = new System.Drawing.Size(32, 27);
            this.btn_CloseFrm.TabIndex = 19;
            this.btn_CloseFrm.Text = "X";
            this.btn_CloseFrm.UseVisualStyleBackColor = false;
            this.btn_CloseFrm.Click += new System.EventHandler(this.btn_CloseFrm_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(289, 489);
            this.Controls.Add(this.btn_CloseFrm);
            this.Controls.Add(this.lbl_Register);
            this.Controls.Add(this.lbl_DoNotHaveAnAcc);
            this.Controls.Add(this.btn_ClrFields);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.checkBox_ShwPassword);
            this.Controls.Add(this.txt_PasswordLogin);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_usrName);
            this.Controls.Add(this.label_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.Load += new System.EventHandler(this.Login_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.Label lbl_DoNotHaveAnAcc;
        private System.Windows.Forms.Button btn_ClrFields;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.CheckBox checkBox_ShwPassword;
        private System.Windows.Forms.TextBox txt_PasswordLogin;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Label label_usrName;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Button btn_CloseFrm;
    }
}