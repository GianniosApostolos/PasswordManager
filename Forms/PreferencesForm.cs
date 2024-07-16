using PasswordManager.Helper;
using PasswordManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager.Forms
{
    public partial class PreferencesForm : Form
    {
        // All properties below are in Application Settings.
        private bool confirmModalOnLock;
        private bool confirmModalOnOverwrite;
        private bool showOnlyNamesOnShow;
        private bool showRandomCharsOnDecryptFail;
        private Color foregroundColor;
        private Color backgroundColorDark;
        private Color backgroundColorLight;
        private bool generateAndCopyPassword;
        private bool autoClearClipboard;
        private int autoClearClipboardSeconds;

        public PreferencesForm()
        {
            InitializeComponent();
        }
        private void PreferencesForm_Load(object sender, EventArgs e)
        {
            BindApplicationPropertiesToForm();
            Constants.ApplyColorThemeToFormAndControls(this);
        }

        private void confirmModalOnLockCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            confirmModalOnLock = confirmModalOnLockCheckBox.Checked;
        }

        private void confirmModalOnOverwriteCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            confirmModalOnOverwrite = confirmModalOnOverwriteCheckBox.Checked;
        }

        private void showOnlyNamesOnShowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            showOnlyNamesOnShow = showOnlyNamesOnShowCheckBox.Checked;
        }

        private void showRandomCharsOnDecryptFailCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            showRandomCharsOnDecryptFail = showRandomCharsOnDecryptFailCheckBox.Checked;
        }

        private void generateAndCopyPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            generateAndCopyPassword = generateAndCopyPasswordCheckBox.Checked;
        }

        private void autoClearClipboardCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            autoClearClipboard = autoClearClipboardCheckBox.Checked;

            autoClearClipboardSecondsTextBox.Enabled = autoClearClipboard;
        }

        private void autoClearClipboardSecondsTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(autoClearClipboardSecondsTextBox.Text, out int seconds))
            {
                autoClearClipboardSeconds = seconds;
            }
        }

        private void foregroundColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                foregroundColor = colorDialog.Color;
            }
        }

        private void backgroundColorDarkButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundColorDark = colorDialog.Color;
            }
        }

        private void backgroundColorLightButton_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                backgroundColorLight = colorDialog.Color;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            SaveAllSettings();
        }

        private void BindApplicationPropertiesToForm()
        {
            confirmModalOnLockCheckBox.Checked = Constants.CONFIRM_MODAL_ON_LOCK;
            confirmModalOnOverwriteCheckBox.Checked = Constants.CONFIRM_MODAL_ON_OVERWRITE;
            showOnlyNamesOnShowCheckBox.Checked = Constants.SHOW_ONLY_NAMES_ON_SHOW;
            showRandomCharsOnDecryptFailCheckBox.Checked = Constants.RANDOM_CHARS_ON_DECRYPT_FAIL;
            foregroundColor = Constants.FOREGROUND_COLOR;
            backgroundColorDark = Constants.BACKGROUND_COLOR_DARK;
            backgroundColorLight = Constants.BACKGROUND_COLOR_LIGHT;
            generateAndCopyPasswordCheckBox.Checked = Constants.GENERATE_PASSWORD_AND_COPY;
            autoClearClipboardCheckBox.Checked = Constants.AUTO_CLEAR_CLIPBOARD;
            autoClearClipboardSecondsTextBox.Text = Constants.AUTO_CLEAR_CLIPBOARD_SECONDS.ToString();
        }

        private void SaveAllSettings()
        {
            Settings.Default.ConfirmModalOnLock = confirmModalOnLock;
            Settings.Default.ConfirmModalOnOverwrite = confirmModalOnOverwrite;
            Settings.Default.ShowOnlyNamesOnShow = showOnlyNamesOnShow;
            Settings.Default.ShowRandomCharsOnDecryptFail = showRandomCharsOnDecryptFail;
            Settings.Default.ForegroundColor = foregroundColor;
            Settings.Default.BackgroundColorDark = backgroundColorDark;
            Settings.Default.BackgroundColorLight = backgroundColorLight;
            Settings.Default.GenerateAndCopyPassword = generateAndCopyPassword;
            Settings.Default.AutoClearClipboard = autoClearClipboard;
            Settings.Default.AutoClearClipboardSeconds = autoClearClipboardSeconds;
            Settings.Default.Save();
        }

        private void resetColorsButton_Click(object sender, EventArgs e)
        {
            Settings.Default.ForegroundColor = Constants.FOREGROUND_COLOR_DEFAULT;
            Settings.Default.BackgroundColorDark = Constants.BACKGROUND_COLOR_DARK_DEFAULT;
            Settings.Default.BackgroundColorLight = Constants.BACKGROUND_COLOR_LIGHT_DEFAULT;
            Settings.Default.Save();
        }
    }
}
