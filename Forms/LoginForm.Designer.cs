namespace PasswordManager.Forms
{
    partial class LoginForm
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
            this.masterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.masterPasswordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // masterPasswordTextBox
            // 
            this.masterPasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.masterPasswordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.masterPasswordTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterPasswordTextBox.ForeColor = System.Drawing.Color.White;
            this.masterPasswordTextBox.Location = new System.Drawing.Point(42, 104);
            this.masterPasswordTextBox.Multiline = true;
            this.masterPasswordTextBox.Name = "masterPasswordTextBox";
            this.masterPasswordTextBox.PasswordChar = '*';
            this.masterPasswordTextBox.Size = new System.Drawing.Size(170, 30);
            this.masterPasswordTextBox.TabIndex = 0;
            this.masterPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.masterPasswordTextBox_KeyDown);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(44, 192);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(170, 50);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // masterPasswordLabel
            // 
            this.masterPasswordLabel.AutoSize = true;
            this.masterPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masterPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.masterPasswordLabel.Location = new System.Drawing.Point(39, 79);
            this.masterPasswordLabel.Name = "masterPasswordLabel";
            this.masterPasswordLabel.Size = new System.Drawing.Size(112, 17);
            this.masterPasswordLabel.TabIndex = 2;
            this.masterPasswordLabel.Text = "Master Password";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(254, 286);
            this.Controls.Add(this.masterPasswordLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.masterPasswordTextBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(270, 325);
            this.MinimumSize = new System.Drawing.Size(270, 325);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox masterPasswordTextBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label masterPasswordLabel;
    }
}