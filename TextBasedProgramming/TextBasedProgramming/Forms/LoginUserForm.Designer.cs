namespace TextBasedProgramming.Forms
{
    partial class LoginUserForm
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
            this.lbl_user_name = new System.Windows.Forms.Label();
            this.lbl_user_password = new System.Windows.Forms.Label();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.txt_user_password = new System.Windows.Forms.TextBox();
            this.btn_user_login = new System.Windows.Forms.Button();
            this.btn_user_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_user_name
            // 
            this.lbl_user_name.AutoSize = true;
            this.lbl_user_name.Location = new System.Drawing.Point(13, 13);
            this.lbl_user_name.Name = "lbl_user_name";
            this.lbl_user_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_user_name.TabIndex = 0;
            this.lbl_user_name.Text = "Name";
            // 
            // lbl_user_password
            // 
            this.lbl_user_password.AutoSize = true;
            this.lbl_user_password.Location = new System.Drawing.Point(13, 59);
            this.lbl_user_password.Name = "lbl_user_password";
            this.lbl_user_password.Size = new System.Drawing.Size(53, 13);
            this.lbl_user_password.TabIndex = 0;
            this.lbl_user_password.Text = "Password";
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(89, 10);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(335, 20);
            this.txt_user_name.TabIndex = 1;
            // 
            // txt_user_password
            // 
            this.txt_user_password.Location = new System.Drawing.Point(89, 56);
            this.txt_user_password.Name = "txt_user_password";
            this.txt_user_password.Size = new System.Drawing.Size(335, 20);
            this.txt_user_password.TabIndex = 2;
            this.txt_user_password.UseSystemPasswordChar = true;
            // 
            // btn_user_login
            // 
            this.btn_user_login.Location = new System.Drawing.Point(123, 110);
            this.btn_user_login.Name = "btn_user_login";
            this.btn_user_login.Size = new System.Drawing.Size(75, 23);
            this.btn_user_login.TabIndex = 2;
            this.btn_user_login.Text = "Login";
            this.btn_user_login.UseVisualStyleBackColor = true;
            this.btn_user_login.Click += new System.EventHandler(this.btn_user_login_Click);
            // 
            // btn_user_register
            // 
            this.btn_user_register.Location = new System.Drawing.Point(239, 110);
            this.btn_user_register.Name = "btn_user_register";
            this.btn_user_register.Size = new System.Drawing.Size(75, 23);
            this.btn_user_register.TabIndex = 2;
            this.btn_user_register.Text = "Register";
            this.btn_user_register.UseVisualStyleBackColor = true;
            this.btn_user_register.Click += new System.EventHandler(this.btn_user_register_Click);
            // 
            // LoginUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 165);
            this.Controls.Add(this.btn_user_register);
            this.Controls.Add(this.btn_user_login);
            this.Controls.Add(this.txt_user_password);
            this.Controls.Add(this.txt_user_name);
            this.Controls.Add(this.lbl_user_password);
            this.Controls.Add(this.lbl_user_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginUserForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginUserForm_FormClosed_1);
            this.Load += new System.EventHandler(this.LoginUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_user_name;
        private System.Windows.Forms.Label lbl_user_password;
        private System.Windows.Forms.TextBox txt_user_name;
        private System.Windows.Forms.TextBox txt_user_password;
        private System.Windows.Forms.Button btn_user_login;
        private System.Windows.Forms.Button btn_user_register;
    }
}