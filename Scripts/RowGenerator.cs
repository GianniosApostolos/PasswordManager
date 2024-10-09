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

        private Panel[] _separatorPanels = new Panel[5];
        private TextBox _appNameTextBox;
        private TextBox _passwordTextBox;
        private Button _showPasswordButton;
        private Button _copyToClipboardButton;
        private Button _editButton;
        private Button _deleteButton;
        private bool _isEditing;
        private bool _isShowingPassword;
        private bool _isOddRow;
        private bool _rowDecryptedSuccessfully;
        private Color mouseOverBackColor;
        public RowGenerator() { }

        public RowGenerator(FlowLayoutPanel targetPanel)
        {
            TargetPanel = targetPanel;

            _isOddRow = TargetPanel.Controls.Count % 2 == 1;
        }

        public RowGenerator(FlowLayoutPanel targetPanel, byte[] appNameText, byte[] passwordText)
        {
            this.DoubleBuffered = true;

            TargetPanel = targetPanel;
            AppNameText = appNameText;
            PasswordText = passwordText;

            _isOddRow = TargetPanel.Controls.Count % 2 == 1;

            mouseOverBackColor = _isOddRow ? Constants.BACKGROUND_COLOR_LIGHT : Constants.BACKGROUND_COLOR_DARK;
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
                BackColor = this.BackColor,
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
                BackColor = this.BackColor,
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

            currentComponentCalculatedPosition += 10;

            _showPasswordButton = new Button
            {
                Location = new Point(currentComponentCalculatedPosition, 0),
                Width = 50,
                Height = 50,
                ForeColor = Constants.FOREGROUND_COLOR,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = mouseOverBackColor, },
                Text = "Show",
                TextAlign = ContentAlignment.MiddleCenter
            };

            _showPasswordButton.Click += (sender, e) => TogglePasswordVisibility();

            currentComponentCalculatedPosition += _showPasswordButton.Width;

            _separatorPanels[2].Location = new Point(currentComponentCalculatedPosition, 0);

            currentComponentCalculatedPosition += _separatorPanels[2].Width;

            _copyToClipboardButton = new Button
            {
                Location = new Point(currentComponentCalculatedPosition, 0),
                Width = 50,
                Height = 50,
                ForeColor = Constants.FOREGROUND_COLOR,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = mouseOverBackColor, },
                Text = "Copy",
                TextAlign = ContentAlignment.MiddleCenter,
            };

            _copyToClipboardButton.Click += (sender, e) => CopyToClipboard();

            currentComponentCalculatedPosition += _copyToClipboardButton.Width;

            _separatorPanels[3].Location = new Point(currentComponentCalculatedPosition, 0);

            currentComponentCalculatedPosition += _separatorPanels[3].Width;

            _editButton = new Button
            {
                Location = new Point(currentComponentCalculatedPosition, 0),
                Width = 50,
                Height = 50,
                ForeColor = Constants.FOREGROUND_COLOR,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = mouseOverBackColor, },
                Text = "Edit",
                TextAlign = ContentAlignment.MiddleCenter,
                Enabled = false
            };

            _editButton.Click += (sender, e) => EditRow();

            currentComponentCalculatedPosition += _editButton.Width;

            _separatorPanels[4].Location = new Point(currentComponentCalculatedPosition, 0);

            currentComponentCalculatedPosition += _separatorPanels[4].Width;

            _deleteButton = new Button
            {
                Location = new Point(currentComponentCalculatedPosition, 0),
                Width = 50,
                Height = 50,
                ForeColor = Constants.FOREGROUND_COLOR,
                BackColor = Color.Transparent,
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0, MouseOverBackColor = mouseOverBackColor, },
                Text = "Delete",
                TextAlign = ContentAlignment.MiddleCenter
            };

            _deleteButton.Click += (sender, e) => DeleteRow();

            // Docking the action buttons to the right side of the row
            // This is done after the buttons are created to avoid the buttons being docked in the wrong order.
            _deleteButton.Dock = DockStyle.Right;
            _separatorPanels[4].Dock = DockStyle.Right;
            _editButton.Dock = DockStyle.Right;
            _separatorPanels[3].Dock = DockStyle.Right;
            _copyToClipboardButton.Dock = DockStyle.Right;
            _separatorPanels[2].Dock = DockStyle.Right;
            _showPasswordButton.Dock = DockStyle.Right;

            // Adding the components to the row in order to display them.
            this.Controls.Add(_appNameTextBox);
            this.Controls.Add(_separatorPanels[0]);
            this.Controls.Add(_passwordTextBox);
            this.Controls.Add(_separatorPanels[1]);
            this.Controls.Add(_showPasswordButton);
            this.Controls.Add(_separatorPanels[2]);
            this.Controls.Add(_copyToClipboardButton);
            this.Controls.Add(_separatorPanels[3]);
            this.Controls.Add(_editButton);
            this.Controls.Add(_separatorPanels[4]);
            this.Controls.Add(_deleteButton);

            TargetPanel.Controls.Add(this);
        }

        private void TogglePasswordVisibility()
        {
            _isShowingPassword = !_isShowingPassword;

            if (!Constants.SHOW_ONLY_NAMES_ON_SHOW)
            {
                _passwordTextBox.UseSystemPasswordChar = _isShowingPassword;
                _passwordTextBox.Text = _isShowingPassword ? DecryptField(PasswordText) : Convert.ToBase64String(PasswordText);
            }

            _appNameTextBox.Text = _isShowingPassword ? DecryptField(AppNameText) : Convert.ToBase64String(AppNameText);
            _showPasswordButton.Text = _isShowingPassword ? "Hide" : "Show";
            _editButton.Enabled = !_editButton.Enabled;
        }
        private void CopyToClipboard()
        {
            if (Constants.AUTO_CLEAR_CLIPBOARD)
            {
                ClipboardCleaner.Instance.StartClearing();
            }

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
            _editButton.Text = _isEditing ? "Save" : "Edit";

            if (_isShowingPassword && _isEditing && _rowDecryptedSuccessfully)
            {
                _passwordTextBox.ReadOnly = false;
                Console.WriteLine("Editing row");
            }
            else if (_isShowingPassword && _rowDecryptedSuccessfully)
            {
                _passwordTextBox.ReadOnly = true;
                Console.WriteLine("Saving row");

                this.PasswordText = AesEncryption.Encrypt(_passwordTextBox.Text, Env.MASTER_PASSWORD_HASH);
                this._passwordTextBox.Text = Convert.ToBase64String(PasswordText);
                TogglePasswordVisibility();
            }
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
                _rowDecryptedSuccessfully = true;
                return AesEncryption.Decrypt(fieldToDecrypt, Env.MASTER_PASSWORD_HASH);
            }
            catch (Exception e)
            {
                _rowDecryptedSuccessfully = false;
                return "Error decrypting field";
            }
        }

        public void HideActionButtons()
        {
            _showPasswordButton.Visible = false;
            _copyToClipboardButton.Visible = false;
            _editButton.Visible = false;
            _deleteButton.Visible = false;
            _separatorPanels[2].Visible = false;
            _separatorPanels[3].Visible = false;
            _separatorPanels[4].Visible = false;

        }

        public void ShowActionButtons()
        {
            _showPasswordButton.Visible = true;
            _copyToClipboardButton.Visible = true;
            _editButton.Visible = true;
            _deleteButton.Visible = true;
            _separatorPanels[2].Visible = true;
            _separatorPanels[3].Visible = true;
            _separatorPanels[4].Visible = true;
        }
    }
}
