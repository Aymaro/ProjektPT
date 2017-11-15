namespace Klient
{
    partial class OknoDodawania
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
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.UIDtextBox = new System.Windows.Forms.TextBox();
            this.LabelID = new System.Windows.Forms.Label();
            this.LabelImie = new System.Windows.Forms.Label();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.LabelNazwisko = new System.Windows.Forms.Label();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.EditCheckBox = new System.Windows.Forms.CheckBox();
            this.HasloTextBox = new System.Windows.Forms.TextBox();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.LabelHaslo = new System.Windows.Forms.Label();
            this.LabelLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(294, 97);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 97);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Anuluj";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // UIDtextBox
            // 
            this.UIDtextBox.Location = new System.Drawing.Point(12, 25);
            this.UIDtextBox.Name = "UIDtextBox";
            this.UIDtextBox.Size = new System.Drawing.Size(115, 20);
            this.UIDtextBox.TabIndex = 2;
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Location = new System.Drawing.Point(12, 9);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(0, 13);
            this.LabelID.TabIndex = 5;
            // 
            // LabelImie
            // 
            this.LabelImie.AutoSize = true;
            this.LabelImie.Location = new System.Drawing.Point(133, 9);
            this.LabelImie.Name = "LabelImie";
            this.LabelImie.Size = new System.Drawing.Size(26, 13);
            this.LabelImie.TabIndex = 7;
            this.LabelImie.Text = "Imię";
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Location = new System.Drawing.Point(133, 25);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(115, 20);
            this.ImieTextBox.TabIndex = 6;
            // 
            // LabelNazwisko
            // 
            this.LabelNazwisko.AutoSize = true;
            this.LabelNazwisko.Location = new System.Drawing.Point(254, 9);
            this.LabelNazwisko.Name = "LabelNazwisko";
            this.LabelNazwisko.Size = new System.Drawing.Size(53, 13);
            this.LabelNazwisko.TabIndex = 9;
            this.LabelNazwisko.Text = "Nazwisko";
            // 
            // NazwiskoTextBox
            // 
            this.NazwiskoTextBox.Location = new System.Drawing.Point(254, 25);
            this.NazwiskoTextBox.Name = "NazwiskoTextBox";
            this.NazwiskoTextBox.Size = new System.Drawing.Size(115, 20);
            this.NazwiskoTextBox.TabIndex = 8;
            // 
            // EditCheckBox
            // 
            this.EditCheckBox.AutoSize = true;
            this.EditCheckBox.Location = new System.Drawing.Point(15, 73);
            this.EditCheckBox.Name = "EditCheckBox";
            this.EditCheckBox.Size = new System.Drawing.Size(78, 17);
            this.EditCheckBox.TabIndex = 10;
            this.EditCheckBox.Text = "edytuj wpis";
            this.EditCheckBox.UseVisualStyleBackColor = true;
            // 
            // HasloTextBox
            // 
            this.HasloTextBox.Location = new System.Drawing.Point(254, 71);
            this.HasloTextBox.Name = "HasloTextBox";
            this.HasloTextBox.PasswordChar = '*';
            this.HasloTextBox.Size = new System.Drawing.Size(115, 20);
            this.HasloTextBox.TabIndex = 12;
            this.HasloTextBox.Click += new System.EventHandler(this.HasloTextBox_Click);
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(133, 71);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(115, 20);
            this.LoginTextBox.TabIndex = 11;
            // 
            // LabelHaslo
            // 
            this.LabelHaslo.AutoSize = true;
            this.LabelHaslo.Location = new System.Drawing.Point(254, 55);
            this.LabelHaslo.Name = "LabelHaslo";
            this.LabelHaslo.Size = new System.Drawing.Size(34, 13);
            this.LabelHaslo.TabIndex = 14;
            this.LabelHaslo.Text = "Haslo";
            // 
            // LabelLogin
            // 
            this.LabelLogin.AutoSize = true;
            this.LabelLogin.Location = new System.Drawing.Point(133, 55);
            this.LabelLogin.Name = "LabelLogin";
            this.LabelLogin.Size = new System.Drawing.Size(33, 13);
            this.LabelLogin.TabIndex = 13;
            this.LabelLogin.Text = "Login";
            // 
            // OknoDodawania
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 130);
            this.Controls.Add(this.LabelHaslo);
            this.Controls.Add(this.LabelLogin);
            this.Controls.Add(this.HasloTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.EditCheckBox);
            this.Controls.Add(this.LabelNazwisko);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.LabelImie);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.UIDtextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "OknoDodawania";
            this.Text = "Dodaj kartę";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox UIDtextBox;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label LabelImie;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.Label LabelNazwisko;
        private System.Windows.Forms.TextBox NazwiskoTextBox;
        private System.Windows.Forms.CheckBox EditCheckBox;
        private System.Windows.Forms.TextBox HasloTextBox;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.Label LabelHaslo;
        private System.Windows.Forms.Label LabelLogin;
    }
}