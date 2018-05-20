using System;
using System.Windows.Forms;
using AutoRent.Database;
using AutoRent.Models;

namespace AutoRent.Forms {
    public partial class Authorization : Form {
        const String LoginFailed = "The username or password is incorrect.";
        const String ConnectionFailed = "Could not establish connection with database.";
        readonly LoginModel _loginModel = new LoginModel();

        public Authorization() {
            InitializeComponent();
            loginBox.DataBindings.Add(nameof(TextBox.Text), _loginModel, nameof(LoginModel.UserName));
            passwordBox.DataBindings.Add(nameof(TextBox.Text), _loginModel, nameof(LoginModel.Password));
        }

        void LoginButton_Click(Object sender, EventArgs e) {
            var mgr = new DbManager();
            try {
                Boolean result = mgr.VerifyCredentials(_loginModel.UserName, _loginModel.Password);

                if (!result) {
                    InvalidLoginLabel.Text = LoginFailed;
                    InvalidLoginLabel.Visible = true;
                    return;
                }

                InvalidLoginLabel.Visible = false;
                var form = new MainPanel();
                form.Closed += (s, args) => Close();
                form.Show();
                Hide();
            } catch (Exception ex) {
                InvalidLoginLabel.Text = ConnectionFailed;
                InvalidLoginLabel.Visible = true;
                throw;
            }
        }
    }
}
