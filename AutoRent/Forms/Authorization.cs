using AutoRent.Database;
using AutoRent.Forms;
using System;
using System.Windows.Forms;

namespace AutoRent
{
    public partial class Authorization : Form
    {
        private const string LoginFailed = "The username or password is incorrect.";
        private const string ConnectionFailed = "Could not establish connection with database.";
        public Authorization()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var mgr = new DbManager();
            try
            {
                var result = mgr.Login(loginBox.Text, passwordBox.Text);
                
                if (!result)
                {
                    InvalidLoginLabel.Text = LoginFailed;
                    InvalidLoginLabel.Visible = true;
                    return;
                }

                InvalidLoginLabel.Visible = false;
                var form = new MainPanel();
                form.Closed += (s, args) => this.Close();
                form.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                InvalidLoginLabel.Text = ConnectionFailed;
                InvalidLoginLabel.Visible = true;
                Console.WriteLine(ex);
                throw;
            }
        }
    }
}
