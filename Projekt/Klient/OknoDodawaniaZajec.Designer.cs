namespace Klient
{
    partial class OknoDodawaniaZajec
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.startHour = new System.Windows.Forms.NumericUpDown();
            this.startMinutes = new System.Windows.Forms.NumericUpDown();
            this.endMinutes = new System.Windows.Forms.NumericUpDown();
            this.endHour = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).BeginInit();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(293, 25);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(399, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Imię";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(399, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(505, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nazwisko";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(505, 25);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.surnameTextBox.TabIndex = 4;
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(293, 64);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(312, 21);
            this.subjectComboBox.TabIndex = 6;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 9);
            this.monthCalendar1.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Początek zajęć:";
            // 
            // startHour
            // 
            this.startHour.Location = new System.Drawing.Point(293, 104);
            this.startHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.startHour.Name = "startHour";
            this.startHour.Size = new System.Drawing.Size(49, 20);
            this.startHour.TabIndex = 10;
            this.startHour.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.startHour.ValueChanged += new System.EventHandler(this.startHour_ValueChanged);
            // 
            // startMinutes
            // 
            this.startMinutes.Location = new System.Drawing.Point(348, 104);
            this.startMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.startMinutes.Name = "startMinutes";
            this.startMinutes.Size = new System.Drawing.Size(49, 20);
            this.startMinutes.TabIndex = 11;
            // 
            // endMinutes
            // 
            this.endMinutes.Location = new System.Drawing.Point(471, 104);
            this.endMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.endMinutes.Name = "endMinutes";
            this.endMinutes.Size = new System.Drawing.Size(49, 20);
            this.endMinutes.TabIndex = 14;
            // 
            // endHour
            // 
            this.endHour.Location = new System.Drawing.Point(416, 104);
            this.endHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.endHour.Name = "endHour";
            this.endHour.Size = new System.Drawing.Size(49, 20);
            this.endHour.TabIndex = 13;
            this.endHour.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.endHour.ValueChanged += new System.EventHandler(this.endHour_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(416, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Koniec zajęć:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Przedmiot:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(530, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Anuluj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OknoDodawaniaZajec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 178);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.endMinutes);
            this.Controls.Add(this.endHour);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.startMinutes);
            this.Controls.Add(this.startHour);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OknoDodawaniaZajec";
            this.Text = "OknoDodawaniaZajec";
            ((System.ComponentModel.ISupportInitialize)(this.startHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown startHour;
        private System.Windows.Forms.NumericUpDown startMinutes;
        private System.Windows.Forms.NumericUpDown endMinutes;
        private System.Windows.Forms.NumericUpDown endHour;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}