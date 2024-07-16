namespace PasswordManager.Forms
{
    partial class UtilitiesForm
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
            this.copyGeneratePasswordButton = new System.Windows.Forms.Button();
            this.generatePasswordButton = new System.Windows.Forms.Button();
            this.generatePasswordTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.upperCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.lowerCaseCheckBox = new System.Windows.Forms.CheckBox();
            this.digitsCheckBox = new System.Windows.Forms.CheckBox();
            this.symbolsCheckBox = new System.Windows.Forms.CheckBox();
            this.passLengthTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passwordLengthLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passLengthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // copyGeneratePasswordButton
            // 
            this.copyGeneratePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyGeneratePasswordButton.Location = new System.Drawing.Point(392, 356);
            this.copyGeneratePasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.copyGeneratePasswordButton.Name = "copyGeneratePasswordButton";
            this.copyGeneratePasswordButton.Size = new System.Drawing.Size(30, 25);
            this.copyGeneratePasswordButton.TabIndex = 15;
            this.copyGeneratePasswordButton.Text = "Copy";
            this.copyGeneratePasswordButton.UseVisualStyleBackColor = true;
            this.copyGeneratePasswordButton.Click += new System.EventHandler(this.copyGeneratePasswordButton_Click);
            // 
            // generatePasswordButton
            // 
            this.generatePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatePasswordButton.Location = new System.Drawing.Point(98, 438);
            this.generatePasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.generatePasswordButton.Name = "generatePasswordButton";
            this.generatePasswordButton.Size = new System.Drawing.Size(241, 48);
            this.generatePasswordButton.TabIndex = 12;
            this.generatePasswordButton.Text = "Generate Password";
            this.generatePasswordButton.UseVisualStyleBackColor = true;
            this.generatePasswordButton.Click += new System.EventHandler(this.generatePasswordButton_Click);
            // 
            // generatePasswordTextBox
            // 
            this.generatePasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.generatePasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generatePasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.generatePasswordTextBox.Location = new System.Drawing.Point(41, 356);
            this.generatePasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.generatePasswordTextBox.Name = "generatePasswordTextBox";
            this.generatePasswordTextBox.Size = new System.Drawing.Size(350, 25);
            this.generatePasswordTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Generate Password";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.allCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.upperCaseCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.lowerCaseCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.digitsCheckBox);
            this.flowLayoutPanel1.Controls.Add(this.symbolsCheckBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 81);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(404, 62);
            this.flowLayoutPanel1.TabIndex = 17;
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Checked = true;
            this.allCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCheckBox.Location = new System.Drawing.Point(4, 4);
            this.allCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(44, 21);
            this.allCheckBox.TabIndex = 0;
            this.allCheckBox.Text = "All";
            this.allCheckBox.UseVisualStyleBackColor = true;
            // 
            // upperCaseCheckBox
            // 
            this.upperCaseCheckBox.AutoSize = true;
            this.upperCaseCheckBox.Checked = true;
            this.upperCaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.upperCaseCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upperCaseCheckBox.Location = new System.Drawing.Point(56, 4);
            this.upperCaseCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.upperCaseCheckBox.Name = "upperCaseCheckBox";
            this.upperCaseCheckBox.Size = new System.Drawing.Size(136, 21);
            this.upperCaseCheckBox.TabIndex = 1;
            this.upperCaseCheckBox.Text = "Uppercase Letters";
            this.upperCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // lowerCaseCheckBox
            // 
            this.lowerCaseCheckBox.AutoSize = true;
            this.lowerCaseCheckBox.Checked = true;
            this.lowerCaseCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lowerCaseCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowerCaseCheckBox.Location = new System.Drawing.Point(200, 4);
            this.lowerCaseCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.lowerCaseCheckBox.Name = "lowerCaseCheckBox";
            this.lowerCaseCheckBox.Size = new System.Drawing.Size(136, 21);
            this.lowerCaseCheckBox.TabIndex = 2;
            this.lowerCaseCheckBox.Text = "Lowercase Letters";
            this.lowerCaseCheckBox.UseVisualStyleBackColor = true;
            // 
            // digitsCheckBox
            // 
            this.digitsCheckBox.AutoSize = true;
            this.digitsCheckBox.Checked = true;
            this.digitsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.digitsCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitsCheckBox.Location = new System.Drawing.Point(4, 33);
            this.digitsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.digitsCheckBox.Name = "digitsCheckBox";
            this.digitsCheckBox.Size = new System.Drawing.Size(64, 21);
            this.digitsCheckBox.TabIndex = 3;
            this.digitsCheckBox.Text = "Digits";
            this.digitsCheckBox.UseVisualStyleBackColor = true;
            // 
            // symbolsCheckBox
            // 
            this.symbolsCheckBox.AutoSize = true;
            this.symbolsCheckBox.Checked = true;
            this.symbolsCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.symbolsCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symbolsCheckBox.Location = new System.Drawing.Point(76, 33);
            this.symbolsCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.symbolsCheckBox.Name = "symbolsCheckBox";
            this.symbolsCheckBox.Size = new System.Drawing.Size(79, 21);
            this.symbolsCheckBox.TabIndex = 4;
            this.symbolsCheckBox.Text = "Symbols";
            this.symbolsCheckBox.UseVisualStyleBackColor = true;
            // 
            // passLengthTrackBar
            // 
            this.passLengthTrackBar.Location = new System.Drawing.Point(41, 243);
            this.passLengthTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.passLengthTrackBar.Name = "passLengthTrackBar";
            this.passLengthTrackBar.Size = new System.Drawing.Size(345, 45);
            this.passLengthTrackBar.TabIndex = 18;
            this.passLengthTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.passLengthTrackBar.Scroll += new System.EventHandler(this.passLengthTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(393, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "128";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Password Size:";
            // 
            // passwordLengthLabel
            // 
            this.passwordLengthLabel.AutoSize = true;
            this.passwordLengthLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLengthLabel.Location = new System.Drawing.Point(137, 187);
            this.passwordLengthLabel.Name = "passwordLengthLabel";
            this.passwordLengthLabel.Size = new System.Drawing.Size(40, 23);
            this.passwordLengthLabel.TabIndex = 22;
            this.passwordLengthLabel.Text = "000";
            // 
            // UtilitiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(445, 556);
            this.Controls.Add(this.passwordLengthLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.passLengthTrackBar);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copyGeneratePasswordButton);
            this.Controls.Add(this.generatePasswordButton);
            this.Controls.Add(this.generatePasswordTextBox);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UtilitiesForm";
            this.Text = "UtilitiesForm";
            this.Load += new System.EventHandler(this.UtilitiesForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passLengthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button copyGeneratePasswordButton;
        private System.Windows.Forms.Button generatePasswordButton;
        private System.Windows.Forms.TextBox generatePasswordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox allCheckBox;
        private System.Windows.Forms.CheckBox upperCaseCheckBox;
        private System.Windows.Forms.CheckBox lowerCaseCheckBox;
        private System.Windows.Forms.CheckBox digitsCheckBox;
        private System.Windows.Forms.CheckBox symbolsCheckBox;
        private System.Windows.Forms.TrackBar passLengthTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label passwordLengthLabel;
    }
}