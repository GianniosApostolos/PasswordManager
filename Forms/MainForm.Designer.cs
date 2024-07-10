namespace PasswordManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addRowBtn = new System.Windows.Forms.Button();
            this.rowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.clearClipboardButton = new System.Windows.Forms.Button();
            this.lockButton = new System.Windows.Forms.Button();
            this.utilsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prefsButton = new System.Windows.Forms.Button();
            this.overwriteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // addRowBtn
            // 
            this.addRowBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.addRowBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addRowBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.addRowBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.addRowBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.addRowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRowBtn.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.addRowBtn.ForeColor = System.Drawing.Color.White;
            this.addRowBtn.Location = new System.Drawing.Point(0, 384);
            this.addRowBtn.Name = "addRowBtn";
            this.addRowBtn.Size = new System.Drawing.Size(166, 66);
            this.addRowBtn.TabIndex = 1;
            this.addRowBtn.Text = "+";
            this.addRowBtn.UseVisualStyleBackColor = false;
            this.addRowBtn.Click += new System.EventHandler(this.addRowBtn_Click);
            // 
            // rowPanel
            // 
            this.rowPanel.AutoScroll = true;
            this.rowPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.rowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowPanel.Location = new System.Drawing.Point(0, 0);
            this.rowPanel.Name = "rowPanel";
            this.rowPanel.Size = new System.Drawing.Size(634, 398);
            this.rowPanel.TabIndex = 2;
            this.rowPanel.SizeChanged += new System.EventHandler(this.rowPanel_SizeChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.appNameLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 49);
            this.panel1.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordLabel.Location = new System.Drawing.Point(160, 4);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(150, 23);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // appNameLabel
            // 
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.appNameLabel.Location = new System.Drawing.Point(4, 4);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(150, 23);
            this.appNameLabel.TabIndex = 0;
            this.appNameLabel.Text = "App Name";
            this.appNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearClipboardButton
            // 
            this.clearClipboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.clearClipboardButton.FlatAppearance.BorderSize = 0;
            this.clearClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearClipboardButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearClipboardButton.ForeColor = System.Drawing.Color.White;
            this.clearClipboardButton.Location = new System.Drawing.Point(0, 161);
            this.clearClipboardButton.Name = "clearClipboardButton";
            this.clearClipboardButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.clearClipboardButton.Size = new System.Drawing.Size(166, 50);
            this.clearClipboardButton.TabIndex = 8;
            this.clearClipboardButton.Text = "Clear clipboard";
            this.clearClipboardButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearClipboardButton.UseVisualStyleBackColor = true;
            this.clearClipboardButton.Click += new System.EventHandler(this.clearClipboardButton_Click);
            // 
            // lockButton
            // 
            this.lockButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lockButton.FlatAppearance.BorderSize = 0;
            this.lockButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lockButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockButton.ForeColor = System.Drawing.Color.White;
            this.lockButton.Location = new System.Drawing.Point(0, 0);
            this.lockButton.Name = "lockButton";
            this.lockButton.Size = new System.Drawing.Size(166, 111);
            this.lockButton.TabIndex = 9;
            this.lockButton.Text = "LOCK";
            this.lockButton.UseVisualStyleBackColor = true;
            this.lockButton.Click += new System.EventHandler(this.lockButton_Click);
            // 
            // utilsButton
            // 
            this.utilsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.utilsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.utilsButton.FlatAppearance.BorderSize = 0;
            this.utilsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.utilsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.utilsButton.ForeColor = System.Drawing.Color.White;
            this.utilsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.utilsButton.Location = new System.Drawing.Point(0, 111);
            this.utilsButton.Margin = new System.Windows.Forms.Padding(0);
            this.utilsButton.Name = "utilsButton";
            this.utilsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.utilsButton.Size = new System.Drawing.Size(166, 50);
            this.utilsButton.TabIndex = 10;
            this.utilsButton.Text = "Utilities";
            this.utilsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.utilsButton.UseVisualStyleBackColor = false;
            this.utilsButton.Click += new System.EventHandler(this.utilsButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.panel2.Controls.Add(this.prefsButton);
            this.panel2.Controls.Add(this.overwriteButton);
            this.panel2.Controls.Add(this.saveButton);
            this.panel2.Controls.Add(this.addRowBtn);
            this.panel2.Controls.Add(this.clearClipboardButton);
            this.panel2.Controls.Add(this.utilsButton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(634, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 450);
            this.panel2.TabIndex = 11;
            // 
            // prefsButton
            // 
            this.prefsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.prefsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.prefsButton.FlatAppearance.BorderSize = 0;
            this.prefsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prefsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prefsButton.ForeColor = System.Drawing.Color.White;
            this.prefsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.prefsButton.Location = new System.Drawing.Point(0, 211);
            this.prefsButton.Margin = new System.Windows.Forms.Padding(0);
            this.prefsButton.Name = "prefsButton";
            this.prefsButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.prefsButton.Size = new System.Drawing.Size(166, 50);
            this.prefsButton.TabIndex = 14;
            this.prefsButton.Text = "Preferences";
            this.prefsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prefsButton.UseVisualStyleBackColor = false;
            this.prefsButton.Click += new System.EventHandler(this.prefsButton_Click);
            // 
            // overwriteButton
            // 
            this.overwriteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.overwriteButton.FlatAppearance.BorderSize = 0;
            this.overwriteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.overwriteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.overwriteButton.ForeColor = System.Drawing.Color.White;
            this.overwriteButton.Location = new System.Drawing.Point(130, 344);
            this.overwriteButton.Name = "overwriteButton";
            this.overwriteButton.Size = new System.Drawing.Size(33, 30);
            this.overwriteButton.TabIndex = 13;
            this.overwriteButton.Text = "🗘";
            this.overwriteButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.overwriteButton.UseVisualStyleBackColor = true;
            this.overwriteButton.Click += new System.EventHandler(this.overwriteButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(0, 334);
            this.saveButton.Name = "saveButton";
            this.saveButton.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.saveButton.Size = new System.Drawing.Size(166, 50);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lockButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 111);
            this.panel3.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(634, 52);
            this.panel4.TabIndex = 12;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.rowPanel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(634, 398);
            this.panel5.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Text = "EzManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addRowBtn;
        private System.Windows.Forms.FlowLayoutPanel rowPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button clearClipboardButton;
        private System.Windows.Forms.Button lockButton;
        private System.Windows.Forms.Button utilsButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button overwriteButton;
        private System.Windows.Forms.Button prefsButton;
    }
}

