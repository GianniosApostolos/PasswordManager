namespace PasswordManager.Forms
{
    partial class PreferencesForm
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
            this.components = new System.ComponentModel.Container();
            this.confirmModalOnLockCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmModalOnLockLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmModalOnOverwriteCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.showOnlyNamesOnShowCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.colorPickerDialog = new System.Windows.Forms.ColorDialog();
            this.label10 = new System.Windows.Forms.Label();
            this.showRandomCharsOnDecryptFailCheckBox = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.generateAndCopyPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.autoClearClipboardCheckBox = new System.Windows.Forms.CheckBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.autoClearClipboardSecondsTextBox = new System.Windows.Forms.TextBox();
            this.resetColorsButton = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // confirmModalOnLockCheckBox
            // 
            this.confirmModalOnLockCheckBox.AutoSize = true;
            this.confirmModalOnLockCheckBox.Location = new System.Drawing.Point(192, 78);
            this.confirmModalOnLockCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmModalOnLockCheckBox.Name = "confirmModalOnLockCheckBox";
            this.confirmModalOnLockCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirmModalOnLockCheckBox.Size = new System.Drawing.Size(15, 14);
            this.confirmModalOnLockCheckBox.TabIndex = 0;
            this.confirmModalOnLockCheckBox.UseVisualStyleBackColor = true;
            this.confirmModalOnLockCheckBox.CheckedChanged += new System.EventHandler(this.confirmModalOnLockCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show confirmation Modals";
            // 
            // confirmModalOnLockLabel
            // 
            this.confirmModalOnLockLabel.AutoSize = true;
            this.confirmModalOnLockLabel.Location = new System.Drawing.Point(18, 74);
            this.confirmModalOnLockLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmModalOnLockLabel.Name = "confirmModalOnLockLabel";
            this.confirmModalOnLockLabel.Size = new System.Drawing.Size(67, 21);
            this.confirmModalOnLockLabel.TabIndex = 2;
            this.confirmModalOnLockLabel.Text = "On Lock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 115);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "On Overwrite";
            // 
            // confirmModalOnOverwriteCheckBox
            // 
            this.confirmModalOnOverwriteCheckBox.AutoSize = true;
            this.confirmModalOnOverwriteCheckBox.Location = new System.Drawing.Point(192, 122);
            this.confirmModalOnOverwriteCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.confirmModalOnOverwriteCheckBox.Name = "confirmModalOnOverwriteCheckBox";
            this.confirmModalOnOverwriteCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.confirmModalOnOverwriteCheckBox.Size = new System.Drawing.Size(15, 14);
            this.confirmModalOnOverwriteCheckBox.TabIndex = 3;
            this.confirmModalOnOverwriteCheckBox.UseVisualStyleBackColor = true;
            this.confirmModalOnOverwriteCheckBox.CheckedChanged += new System.EventHandler(this.confirmModalOnOverwriteCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(17, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "Data Display";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 280);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Only Show names";
            this.toolTip.SetToolTip(this.label6, "Only decrypt and show the application names\r\n");
            // 
            // showOnlyNamesOnShowCheckBox
            // 
            this.showOnlyNamesOnShowCheckBox.AutoSize = true;
            this.showOnlyNamesOnShowCheckBox.Location = new System.Drawing.Point(192, 287);
            this.showOnlyNamesOnShowCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showOnlyNamesOnShowCheckBox.Name = "showOnlyNamesOnShowCheckBox";
            this.showOnlyNamesOnShowCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showOnlyNamesOnShowCheckBox.Size = new System.Drawing.Size(15, 14);
            this.showOnlyNamesOnShowCheckBox.TabIndex = 9;
            this.showOnlyNamesOnShowCheckBox.UseVisualStyleBackColor = true;
            this.showOnlyNamesOnShowCheckBox.CheckedChanged += new System.EventHandler(this.showOnlyNamesOnShowCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(423, 24);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 30);
            this.label7.TabIndex = 11;
            this.label7.Text = "Style";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button1.Location = new System.Drawing.Point(574, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 21);
            this.button1.TabIndex = 12;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.foregroundColorButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(424, 92);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 21);
            this.label8.TabIndex = 13;
            this.label8.Text = "Foreground Color";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 139);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 21);
            this.label9.TabIndex = 15;
            this.label9.Text = "Background Color";
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.button2.Location = new System.Drawing.Point(574, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 21);
            this.button2.TabIndex = 14;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.backgroundColorDarkButton_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(18, 323);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 76);
            this.label10.TabIndex = 17;
            this.label10.Text = "Random characters instead of decrypt error message";
            this.toolTip.SetToolTip(this.label10, "Create random characters that will be displayed instead\r\nof the generic error mes" +
        "sage that occurs when the master\r\npassword is wrong.");
            // 
            // showRandomCharsOnDecryptFailCheckBox
            // 
            this.showRandomCharsOnDecryptFailCheckBox.AutoSize = true;
            this.showRandomCharsOnDecryptFailCheckBox.Location = new System.Drawing.Point(192, 354);
            this.showRandomCharsOnDecryptFailCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.showRandomCharsOnDecryptFailCheckBox.Name = "showRandomCharsOnDecryptFailCheckBox";
            this.showRandomCharsOnDecryptFailCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.showRandomCharsOnDecryptFailCheckBox.Size = new System.Drawing.Size(15, 14);
            this.showRandomCharsOnDecryptFailCheckBox.TabIndex = 16;
            this.showRandomCharsOnDecryptFailCheckBox.UseVisualStyleBackColor = true;
            this.showRandomCharsOnDecryptFailCheckBox.CheckedChanged += new System.EventHandler(this.showRandomCharsOnDecryptFailCheckBox_CheckedChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(169, 246);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "( When shown )";
            // 
            // toolTip
            // 
            this.toolTip.AutoPopDelay = 5000;
            this.toolTip.InitialDelay = 200;
            this.toolTip.ReshowDelay = 100;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(424, 287);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 71);
            this.label12.TabIndex = 20;
            this.label12.Text = "Treat \"copy\" as \"generate and copy\"";
            this.toolTip.SetToolTip(this.label12, "This will first generate and then copy the generated password to clipboard.\r\n\r\n");
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(424, 369);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 51);
            this.label14.TabIndex = 24;
            this.label14.Text = "Clear clipboard after (seconds)\r\n";
            this.toolTip.SetToolTip(this.label14, "Will attempt to clear the keyboard some seconds\r\nafter pressing any \"password cop" +
        "y\" button from within the app\r\n");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(423, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 30);
            this.label5.TabIndex = 19;
            this.label5.Text = "General";
            // 
            // generateAndCopyPasswordCheckBox
            // 
            this.generateAndCopyPasswordCheckBox.AutoSize = true;
            this.generateAndCopyPasswordCheckBox.Location = new System.Drawing.Point(574, 314);
            this.generateAndCopyPasswordCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.generateAndCopyPasswordCheckBox.Name = "generateAndCopyPasswordCheckBox";
            this.generateAndCopyPasswordCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.generateAndCopyPasswordCheckBox.Size = new System.Drawing.Size(15, 14);
            this.generateAndCopyPasswordCheckBox.TabIndex = 21;
            this.generateAndCopyPasswordCheckBox.UseVisualStyleBackColor = true;
            this.generateAndCopyPasswordCheckBox.CheckedChanged += new System.EventHandler(this.generateAndCopyPasswordCheckBox_CheckedChanged);
            // 
            // autoClearClipboardCheckBox
            // 
            this.autoClearClipboardCheckBox.AutoSize = true;
            this.autoClearClipboardCheckBox.Location = new System.Drawing.Point(574, 385);
            this.autoClearClipboardCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.autoClearClipboardCheckBox.Name = "autoClearClipboardCheckBox";
            this.autoClearClipboardCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.autoClearClipboardCheckBox.Size = new System.Drawing.Size(15, 14);
            this.autoClearClipboardCheckBox.TabIndex = 25;
            this.autoClearClipboardCheckBox.UseVisualStyleBackColor = true;
            this.autoClearClipboardCheckBox.CheckedChanged += new System.EventHandler(this.autoClearClipboardCheckBox_CheckedChanged);
            // 
            // applyButton
            // 
            this.applyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.applyButton.Location = new System.Drawing.Point(321, 450);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(94, 33);
            this.applyButton.TabIndex = 26;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // autoClearClipboardSecondsTextBox
            // 
            this.autoClearClipboardSecondsTextBox.Location = new System.Drawing.Point(612, 378);
            this.autoClearClipboardSecondsTextBox.Name = "autoClearClipboardSecondsTextBox";
            this.autoClearClipboardSecondsTextBox.Size = new System.Drawing.Size(100, 29);
            this.autoClearClipboardSecondsTextBox.TabIndex = 27;
            this.autoClearClipboardSecondsTextBox.TextChanged += new System.EventHandler(this.autoClearClipboardSecondsTextBox_TextChanged);
            // 
            // resetColorsButton
            // 
            this.resetColorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetColorsButton.Location = new System.Drawing.Point(649, 178);
            this.resetColorsButton.Name = "resetColorsButton";
            this.resetColorsButton.Size = new System.Drawing.Size(29, 33);
            this.resetColorsButton.TabIndex = 28;
            this.resetColorsButton.Text = "R";
            this.resetColorsButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.resetColorsButton.UseVisualStyleBackColor = true;
            this.resetColorsButton.Click += new System.EventHandler(this.resetColorsButton_Click);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-1, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(738, 2);
            this.label2.TabIndex = 29;
            // 
            // PreferencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(734, 495);
            this.Controls.Add(this.resetColorsButton);
            this.Controls.Add(this.autoClearClipboardSecondsTextBox);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.autoClearClipboardCheckBox);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.generateAndCopyPasswordCheckBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.showRandomCharsOnDecryptFailCheckBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.showOnlyNamesOnShowCheckBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmModalOnOverwriteCheckBox);
            this.Controls.Add(this.confirmModalOnLockLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confirmModalOnLockCheckBox);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(750, 535);
            this.MinimumSize = new System.Drawing.Size(750, 534);
            this.Name = "PreferencesForm";
            this.Text = "PreferencesForm";
            this.Load += new System.EventHandler(this.PreferencesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox confirmModalOnLockCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label confirmModalOnLockLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox confirmModalOnOverwriteCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox showOnlyNamesOnShowCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColorDialog colorPickerDialog;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox showRandomCharsOnDecryptFailCheckBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox generateAndCopyPasswordCheckBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox autoClearClipboardCheckBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox autoClearClipboardSecondsTextBox;
        private System.Windows.Forms.Button resetColorsButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label label2;
    }
}