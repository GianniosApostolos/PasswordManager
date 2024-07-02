using PasswordManager.Helper;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager.Scripts
{
    internal class RowGenerator : Panel
    {
        public FlowLayoutPanel TargetPanel { get; set; }
        public byte[] AppNameText { get; set; }
        public byte[] PasswordText { get; set; }

        private Panel[] _separatorPanels = new Panel[2];
        private TextBox _appNameTextBox;
        private TextBox _passwordTextBox;
        private Button _showPasswordButton;
        private Button _copyToClipboardButton;
        private Button _editButton;
        private Button _deleteButton;
        private bool _isEditing;
        private bool _isShowingPassword;
        private bool _isOddRow;

        public RowGenerator() { }

        public RowGenerator(FlowLayoutPanel targetPanel)
        {
            TargetPanel = targetPanel;

            _isOddRow = TargetPanel.Controls.Count % 2 == 1;
        }

        public RowGenerator(FlowLayoutPanel targetPanel, byte[] appNameText, byte[] passwordText)
        {
            TargetPanel = targetPanel;
            AppNameText = appNameText;
            PasswordText = passwordText;

            _isOddRow = TargetPanel.Controls.Count % 2 == 1;
        }

        public void GenerateRow()
        {
            InstantiateSeparatorPanels();

            int currentComponentCalculatedPosition;


            this.Width = TargetPanel.Width - 20;
            this.Height = Constants.BACKGROUND_PANEL_HEIGHT;
            this.BackColor = _isOddRow ? Constants.BACKGROUND_COLOR_DARK : Constants.BACKGROUND_COLOR_LIGHT;
            this.BorderStyle = BorderStyle.None;

            _appNameTextBox = new TextBox
            {
                Location = new Point(0, Constants.BACKGROUND_PANEL_HEIGHT / 2),
                Width = Constants.APP_NAME_WIDTH,
                Height = Constants.BACKGROUND_PANEL_HEIGHT / 4,
                BackColor = _isOddRow ? Constants.BACKGROUND_COLOR_DARK : Constants.BACKGROUND_COLOR_LIGHT,
                ForeColor = Constants.FOREGROUND_COLOR,
                BorderStyle = BorderStyle.None,
                Text = Convert.ToBase64String(AppNameText),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Center,
                Multiline = true,
            };

            currentComponentCalculatedPosition = _appNameTextBox.Width;

            _separatorPanels[0].Location = new Point(currentComponentCalculatedPosition, 0);

            currentComponentCalculatedPosition += _separatorPanels[0].Width;

            _passwordTextBox = new TextBox
            {
                Location = new Point(currentComponentCalculatedPosition, Constants.BACKGROUND_PANEL_HEIGHT / 2),
                Width = Constants.PASSWORD_WIDTH,
                Height = Constants.BACKGROUND_PANEL_HEIGHT / 4,
                BackColor = _isOddRow ? Constants.BACKGROUND_COLOR_DARK : Constants.BACKGROUND_COLOR_LIGHT,
                ForeColor = Constants.FOREGROUND_COLOR,
                BorderStyle = BorderStyle.None,
                Text = Convert.ToBase64String(PasswordText),
                ReadOnly = true,
                TextAlign = HorizontalAlignment.Center,
                PasswordChar = '*',
                Multiline = true
            };

            currentComponentCalculatedPosition += _passwordTextBox.Width;

            _separatorPanels[1].Location = new Point(currentComponentCalculatedPosition, 0);

            currentComponentCalculatedPosition += _separatorPanels[1].Width;

            _showPasswordButton = new Button
            {
                Location = new Point(currentComponentCalculatedPosition, 0),
                Width = 50,
                Height = 50,
                BackColor = _isOddRow ? Constants.BACKGROUND_COLOR_DARK : Constants.BACKGROUND_COLOR_LIGHT,
                FlatStyle = FlatStyle.Flat,
                Text = "Show",
                TextAlign = ContentAlignment.MiddleCenter
            };

            _showPasswordButton.Click += (sender, e) => TogglePasswordVisibility();

            currentComponentCalculatedPosition += _showPasswordButton.Width;

            _copyToClipboardButton = new Button
            {
                Location = new Point(currentComponentCalculatedPosition, 0),
                Width = 50,
                Height = 50,
                BackColor = _isOddRow ? Constants.BACKGROUND_COLOR_DARK : Constants.BACKGROUND_COLOR_LIGHT,
                FlatStyle = FlatStyle.Flat,
                Text = "Copy",
                TextAlign = ContentAlignment.MiddleCenter
            };

            _copyToClipboardButton.Click += (sender, e) => CopyToClipboard();

            currentComponentCalculatedPosition += _copyToClipboardButton.Width;

            _editButton = new Button
            {
                Location = new Point(currentComponentCalculatedPosition, 0),
                Width = 50,
                Height = 50,
                BackColor = _isOddRow ? Constants.BACKGROUND_COLOR_DARK : Constants.BACKGROUND_COLOR_LIGHT,
                FlatStyle = FlatStyle.Flat,
                Text = "Edit",
                TextAlign = ContentAlignment.MiddleCenter
            };

            _editButton.Click += (sender, e) => EditRow();

            currentComponentCalculatedPosition += _editButton.Width;

            _deleteButton = new Button
            {
                Location = new Point(currentComponentCalculatedPosition, 0),
                Width = 50,
                Height = 50,
                BackColor = _isOddRow ? Constants.BACKGROUND_COLOR_DARK : Constants.BACKGROUND_COLOR_LIGHT,
                FlatStyle = FlatStyle.Flat,
                Text = "Delete",
                TextAlign = ContentAlignment.MiddleCenter
            };

            _deleteButton.Click += (sender, e) => DeleteRow();

            this.Controls.Add(_appNameTextBox);
            this.Controls.Add(_separatorPanels[0]);
            this.Controls.Add(_passwordTextBox);
            this.Controls.Add(_separatorPanels[1]);
            this.Controls.Add(_showPasswordButton);
            this.Controls.Add(_copyToClipboardButton);
            this.Controls.Add(_editButton);
            this.Controls.Add(_deleteButton);

            TargetPanel.Controls.Add(this);
        }

        private void TogglePasswordVisibility()
        {
            _isShowingPassword = !_isShowingPassword;
            _passwordTextBox.UseSystemPasswordChar = _isShowingPassword;
            _passwordTextBox.Text = _isShowingPassword ? DecryptField(PasswordText) : Convert.ToBase64String(PasswordText);
            _appNameTextBox.Text = _isShowingPassword ? DecryptField(AppNameText) : Convert.ToBase64String(AppNameText);
            _showPasswordButton.Text = _isShowingPassword ? "Hide" : "Show";
        }

        private void CopyToClipboard()
        {
            if (!string.IsNullOrEmpty(_passwordTextBox.Text))
            {
                if (_isShowingPassword)
                {
                    Clipboard.SetText(_passwordTextBox.Text);
                }
                else
                {
                    Clipboard.SetText(DecryptField(PasswordText));
                }
            }
        }

        private void DeleteAllEventHandlers()
        {
            _showPasswordButton.Click -= (sender, e) => TogglePasswordVisibility();
            _copyToClipboardButton.Click -= (sender, e) => CopyToClipboard();
            _editButton.Click -= (sender, e) => EditRow();
            _deleteButton.Click -= (sender, e) => DeleteRow();
        }

        private void EditRow()
        {
            _isEditing = !_isEditing;
            _passwordTextBox.ReadOnly = !_isEditing;
            _editButton.Text = _isEditing ? "Save" : "Edit";
        }

        private void DeleteRow()
        {
            DeleteAllEventHandlers();
            TargetPanel.Controls.Remove(this);
        }

        private void InstantiateSeparatorPanels()
        {
            for (int i = 0; i < _separatorPanels.Length; i++)
            {
                _separatorPanels[i] = new Panel
                {
                    Width = 1,
                    Height = Constants.BACKGROUND_PANEL_HEIGHT,
                    BackColor = Constants.FOREGROUND_COLOR,
                    BorderStyle = BorderStyle.None
                };
            }
        }

        private string DecryptField(byte[] fieldToDecrypt)
        {
            try
            {
                return AesEncryption.Decrypt(fieldToDecrypt, Env.MASTER_PASSWORD_HASH, System.Text.Encoding.ASCII.GetBytes("SIXTEENCHARATERS"));
            }
            catch (Exception e)
            {
                return "Error decrypting field";
            }
        }

    }

}
