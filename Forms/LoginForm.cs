using PasswordManager.Helper;
using System;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class LoginForm : Form
    {
        MainForm mainForm;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(masterPasswordTextBox.Text) || masterPasswordTextBox.Text.Length < 8)
            {
                MessageBox.Show("Password should be at least 8 characters.", "Invalid password");
                return;
            }

            Env.MASTER_PASSWORD_HASH = DeriveKey.Derive(masterPasswordTextBox.Text, 32);

            masterPasswordTextBox.Text = string.Empty;

            mainForm = new MainForm();
            mainForm.Show();
            this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (mainForm == null)
            {
                Application.Exit();
            }
        }

        private void masterPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                loginButton.PerformClick();
            }
        }
    }
}
