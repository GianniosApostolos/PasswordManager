﻿using PasswordManager.Helper;
using PasswordManager.Scripts;
using System;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class RowInfoForm : Form
    {
        FlowLayoutPanel flowLayoutPanel;

        public RowInfoForm(FlowLayoutPanel flowLayoutPanel)
        {

            InitializeComponent();
            this.flowLayoutPanel = flowLayoutPanel;

        }

        private void createButton_Click(object sender, EventArgs e)
        {

            byte[] encryptedAppTextBox = AesEncryption.Encrypt(appNameTextBox.Text, Env.MASTER_PASSWORD_HASH, System.Text.Encoding.ASCII.GetBytes(Env.IV));

            byte[] encryptedPasswordTextBox = AesEncryption.Encrypt(passwordTextBox.Text, Env.MASTER_PASSWORD_HASH, System.Text.Encoding.ASCII.GetBytes(Env.IV));

            RowGenerator rowGenerator = new RowGenerator(flowLayoutPanel, encryptedAppTextBox, encryptedPasswordTextBox);
            rowGenerator.GenerateRow();

        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !passwordTextBox.UseSystemPasswordChar;
        }
    }
}
