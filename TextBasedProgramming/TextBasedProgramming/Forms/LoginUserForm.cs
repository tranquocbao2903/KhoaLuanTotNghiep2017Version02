using System;
using System.Windows.Forms;
using TextBasedProgramming.Helpers;

namespace TextBasedProgramming.Forms
{
    public partial class LoginUserForm : Form
    {
        Function function = new Function();

        public LoginUserForm()
        {
            InitializeComponent();
        }

        private void LoginUserForm_Load(object sender, EventArgs e)
        {
            //Connect with database
            function.ConnectDatabase();
            //Default test user
            txt_user_name.Text = "Tran Quoc Bao";
            txt_user_password.Text = "123456789";
        }

        private void LoginUserForm_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            //Shut down application
            Application.Exit();
        }

        private void btn_user_login_Click(object sender, EventArgs e)
        {
            string username = txt_user_name.Text.Trim();
            string password = txt_user_password.Text.Trim();

            string existUsername = function.getSingleData("username", "testuser", username);
            if (existUsername == username)
            {
                string existPassword = function.getSingleData("userpassword", "testuser", function.EncodeSHA1(password));
                if (existPassword == function.EncodeSHA1(password))
                {
                    //MessageBox.Show("Login successfully");
                    Hide();
                    StartForm startForm = new StartForm();
                    startForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Password isn't correct. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("Username isn't correct. Please try again.");
            }

        }

        private void btn_user_register_Click(object sender, EventArgs e)
        {

        }

        private void LoginUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

    }
}
