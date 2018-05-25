using System;
using System.Windows.Forms;
using AutoRent.Database;

namespace AutoRent.Forms {
    public partial class Authorization : Form {
        const String LoginFailed = "The username or password is incorrect.";
        const String ConnectionFailed = "Could not establish connection with database.";

        public Authorization() {
            InitializeComponent();
        }

        void LoginButton_Click(Object sender, EventArgs e) {
            var mgr = new DbManager();
            try {
                Boolean result = mgr.VerifyCredentials(loginBox.Text, passwordBox.Text);

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
