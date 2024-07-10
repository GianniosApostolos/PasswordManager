using PasswordManager.Forms;
using PasswordManager.Helper;
using PasswordManager.Scripts;
using System;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class MainForm : Form
    {
        FlowLayoutPanel flowLayoutPanel;

        private bool _isLoggingOut;
        private bool _actionButtonsVisible = true;
        public MainForm()
        {
            InitializeComponent();
            flowLayoutPanel = rowPanel;
            appNameLabel.Width = Constants.APP_NAME_WIDTH;
            passwordLabel.Width = Constants.PASSWORD_WIDTH;
            SerializeJson.CreateRowObjectsFromJson(flowLayoutPanel);
        }

        private void addRowBtn_Click(object sender, EventArgs e)
        {
            RowInfoForm rowInfoForm = new RowInfoForm(flowLayoutPanel);
            rowInfoForm.Show();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_isLoggingOut)
            {
                Application.Exit();
            }
        }

        private void clearClipboardButton_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
        }

        private void lockButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("You will not be able to reveal your contents or copy passwords to clipboard.\n\nAre you sure?", "Logging out", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                _isLoggingOut = true;

                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Close();
            }
        }

        private void utilsButton_Click(object sender, EventArgs e)
        {
            UtilitiesForm utilitiesForm = new UtilitiesForm();
            utilitiesForm.Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SerializeJson.SerializeRowObjectsToJson(targetPanel: flowLayoutPanel, overwritePreviousSave: false);
        }

        private void overwriteButton_Click(object sender, EventArgs e)
        {
            SerializeJson.SerializeRowObjectsToJson(targetPanel: flowLayoutPanel, overwritePreviousSave: true);
        }

        private void prefsButton_Click(object sender, EventArgs e)
        {
            PreferencesForm preferencesForm = new PreferencesForm();
            preferencesForm.Show();
        }

        private void rowPanel_SizeChanged(object sender, EventArgs e)
        {
            DynamicLayoutHandler.ResizeRows(flowLayoutPanel);

            if (_actionButtonsVisible && this.Width <= 710)
            {
                DynamicLayoutHandler.HideActionButtons(flowLayoutPanel);
                _actionButtonsVisible = false;
            }
            else if (!_actionButtonsVisible && this.Width > 710)
            {
                DynamicLayoutHandler.ShowActionButtons(flowLayoutPanel);
                _actionButtonsVisible = true;
            }
        }
    }
}
