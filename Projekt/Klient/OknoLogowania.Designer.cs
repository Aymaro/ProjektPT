namespace Klient
{
    partial class OknoLogowania
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(243, 69);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Wyjdź";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(12, 69);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Zaloguj";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(9, 9);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasło";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(12, 25);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(150, 20);
            this.LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(168, 25);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(150, 20);
            this.PasswordTextBox.TabIndex = 1;
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Location = new System.Drawing.Point(118, 75);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(101, 17);
            this.rememberMeCheckBox.TabIndex = 6;
            this.rememberMeCheckBox.Text = "zapamiętaj mnie";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // OknoLogowania
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 100);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.ExitButton);
            this.Name = "OknoLogowania";
            this.Text = "OknoLogowania";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
    }
}