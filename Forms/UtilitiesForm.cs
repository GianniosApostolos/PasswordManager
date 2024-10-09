using PasswordManager.Helper;
using PasswordManager.Scripts;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class UtilitiesForm : Form
    {
        public UtilitiesForm()
        {
            InitializeComponent();
            passLengthTrackBar.SetRange(4, 128);
        }

        private void UtilitiesForm_Load(object sender, EventArgs e)
        {
            Constants.ApplyColorThemeToFormAndControls(this);
        }

        private void passLengthTrackBar_Scroll(object sender, EventArgs e)
        {
            passwordLengthLabel.Text = passLengthTrackBar.Value.ToString();
        }

        private void generatePasswordButton_Click(object sender, EventArgs e)
        {
            Dictionary<PasswordTypes, bool> optionsDictionary = new Dictionary<PasswordTypes, bool>
            {
                { PasswordTypes.ALL, allCheckBox.Checked },
                { PasswordTypes.UPPERCASE, upperCaseCheckBox.Checked },
                { PasswordTypes.LOWERCASE, lowerCaseCheckBox.Checked },
                { PasswordTypes.DIGITS, digitsCheckBox.Checked },
                { PasswordTypes.SYMBOLS, symbolsCheckBox.Checked }
            };

            // Only Generate a password if at least one option is selected
            foreach (var option in optionsDictionary)
            {
                if (option.Value)
                {
                    generatePasswordTextBox.Text = StringGenerator.GeneratePassword(passLengthTrackBar.Value, optionsDictionary);

                    if (Constants.GENERATE_PASSWORD_AND_COPY)
                    {
                        Clipboard.SetText(generatePasswordTextBox.Text);
                    }

                    return;
                }
            }
        }

        private void copyGeneratePasswordButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(generatePasswordTextBox.Text))
            {
                if (Constants.AUTO_CLEAR_CLIPBOARD)
                {
                    ClipboardCleaner.Instance.StartClearing();
                }

                Clipboard.SetText(generatePasswordTextBox.Text);
            }
        }

        private void allCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (allCheckBox.Checked)
            {
                upperCaseCheckBox.Checked = true;
                lowerCaseCheckBox.Checked = true;
                digitsCheckBox.Checked = true;
                symbolsCheckBox.Checked = true;

                upperCaseCheckBox.Enabled = false;
                lowerCaseCheckBox.Enabled = false;
                digitsCheckBox.Enabled = false;
                symbolsCheckBox.Enabled = false;
            }
            else
            {
                upperCaseCheckBox.Enabled = true;
                lowerCaseCheckBox.Enabled = true;
                digitsCheckBox.Enabled = true;
                symbolsCheckBox.Enabled = true;
            }
        }
    }
}
