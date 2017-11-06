namespace Projekt
{
    partial class DodajKarte
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImieTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.EditCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(294, 77);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Dodaj";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(12, 77);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "UID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Imię";
            // 
            // ImieTextBox
            // 
            this.ImieTextBox.Location = new System.Drawing.Point(133, 25);
            this.ImieTextBox.Name = "ImieTextBox";
            this.ImieTextBox.Size = new System.Drawing.Size(115, 20);
            this.ImieTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nazwisko";
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
            this.EditCheckBox.Location = new System.Drawing.Point(12, 54);
            this.EditCheckBox.Name = "EditCheckBox";
            this.EditCheckBox.Size = new System.Drawing.Size(78, 17);
            this.EditCheckBox.TabIndex = 10;
            this.EditCheckBox.Text = "edytuj wpis";
            this.EditCheckBox.UseVisualStyleBackColor = true;
            // 
            // DodajKarte
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 112);
            this.Controls.Add(this.EditCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NazwiskoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImieTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UIDtextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.AddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "DodajKarte";
            this.Text = "Dodaj kartę";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox UIDtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ImieTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NazwiskoTextBox;
        private System.Windows.Forms.CheckBox EditCheckBox;
    }
}