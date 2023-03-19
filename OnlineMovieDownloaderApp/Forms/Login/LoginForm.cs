using OnlineMovieDownloaderApp.Data;
using OnlineMovieDownloaderApp.Forms.Admin;
using OnlineMovieDownloaderApp.Model;
using OnlineMovieDownloaderApp.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineMovieDownloaderApp.Forms.Login
{
    public partial class LoginForm : Form
    {
        private UserRepository userRepo = new UserRepository();
        public LoginForm()
        {
            InitializeComponent();
            panel.BackColor = Color.FromArgb(100, 194, 193, 192);
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            string _email = emailInput.Text.Trim();
            string _password = StringEncryption.GetMD5Hash(passwordInput.Text.Trim());

            // check if form is valid
            if (!IsFormValid())
                return;

            var userResult = await userRepo.GetAll();

            UserModel userByEmail = new UserModel();
            bool userFoundFlag = false;
            foreach (var item in userResult)
            {
                if (item.Email == _email && item.Password == _password)
                {
                    userByEmail = item;
                    userFoundFlag = true;
                    break;
                }
            }
            // check if user found
            if (!userFoundFlag)
            {
                MessageBox.Show("Account not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();

            ConfigSettings.SetUserId(userByEmail.Id); // save id

            CheckUserRole(userByEmail.Id);
        }
        private async void CheckUserRole(string id)
        {
            var result = await userRepo.GetOne(id);
            switch (result.Role)
            {
                case "admin":
                    MessageBox.Show("Login Successful, admin!", "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.SwitchMainForm(new AdminMainForm());
                    break;
                default:
                    MessageBox.Show("You are not allowed to use this app.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConfigSettings.SetUserId("");
                    Program.SwitchMainForm(new LoginForm());
                    break;
            }
        }

        private bool IsFormValid()
        {
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            bool checkEmail = emailInput.Text.Trim() == String.Empty;
            bool checkPassword = passwordInput.Text.Trim() == String.Empty;

            // check email if entered
            if (checkEmail)
                errorProvider.SetError(emailInput, "Please enter your email first.");
            else
                errorProvider.SetError(emailInput, "");
            // check password if entered
            if (checkPassword)
                errorProvider.SetError(passwordInput, "Please enter your password first.");
            else
                errorProvider.SetError(passwordInput, "");

            return !checkEmail && !checkPassword;
        }

        private void emailInput_KeyDown(object sender, KeyEventArgs e)
        {
            OnEnterPress(sender, e);
        }

        private void passwordInput_KeyDown(object sender, KeyEventArgs e)
        {
            OnEnterPress(sender, e);
        }
        private void OnEnterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginBtn_Click(sender, e);
            }
        }
    }
}
