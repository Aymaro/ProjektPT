namespace Klient
{
    partial class OknoGlowne
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.odświeżToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.subjectGridView = new System.Windows.Forms.DataGridView();
            this.subjectSubjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startSubjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apsentSubjects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kSub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsGridView = new System.Windows.Forms.DataGridView();
            this.uidStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateStudent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addLesson = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odświeżToolStripMenuItem,
            this.wylogujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1121, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // odświeżToolStripMenuItem
            // 
            this.odświeżToolStripMenuItem.Name = "odświeżToolStripMenuItem";
            this.odświeżToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.odświeżToolStripMenuItem.Text = "Odśwież";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 2);
            this.monthCalendar1.Location = new System.Drawing.Point(18, 33);
            this.monthCalendar1.MaxDate = new System.DateTime(2099, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TabStop = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // subjectGridView
            // 
            this.subjectGridView.AllowUserToAddRows = false;
            this.subjectGridView.AllowUserToDeleteRows = false;
            this.subjectGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectSubjects,
            this.startSubjects,
            this.endSubject,
            this.presentSubject,
            this.apsentSubjects,
            this.allSubject,
            this.yearSub,
            this.wSub,
            this.kSub});
            this.subjectGridView.Location = new System.Drawing.Point(299, 62);
            this.subjectGridView.Name = "subjectGridView";
            this.subjectGridView.Size = new System.Drawing.Size(347, 282);
            this.subjectGridView.TabIndex = 4;
            // 
            // subjectSubjects
            // 
            this.subjectSubjects.HeaderText = "Przedmiot";
            this.subjectSubjects.Name = "subjectSubjects";
            // 
            // startSubjects
            // 
            this.startSubjects.HeaderText = "Poczatek";
            this.startSubjects.Name = "startSubjects";
            this.startSubjects.Width = 60;
            // 
            // endSubject
            // 
            this.endSubject.HeaderText = "Koniec";
            this.endSubject.Name = "endSubject";
            this.endSubject.Width = 60;
            // 
            // presentSubject
            // 
            this.presentSubject.HeaderText = "O";
            this.presentSubject.Name = "presentSubject";
            this.presentSubject.Width = 25;
            // 
            // apsentSubjects
            // 
            this.apsentSubjects.HeaderText = "N";
            this.apsentSubjects.Name = "apsentSubjects";
            this.apsentSubjects.Width = 25;
            // 
            // allSubject
            // 
            this.allSubject.HeaderText = "W";
            this.allSubject.Name = "allSubject";
            this.allSubject.Width = 25;
            // 
            // yearSub
            // 
            this.yearSub.HeaderText = "Rok";
            this.yearSub.Name = "yearSub";
            this.yearSub.Width = 40;
            // 
            // wSub
            // 
            this.wSub.HeaderText = "Wydział";
            this.wSub.Name = "wSub";
            // 
            // kSub
            // 
            this.kSub.HeaderText = "Kierunek";
            this.kSub.Name = "kSub";
            // 
            // studentsGridView
            // 
            this.studentsGridView.AllowUserToAddRows = false;
            this.studentsGridView.AllowUserToDeleteRows = false;
            this.studentsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uidStudent,
            this.nameStudent,
            this.surnameStudent,
            this.dateStudent});
            this.studentsGridView.Location = new System.Drawing.Point(652, 62);
            this.studentsGridView.Name = "studentsGridView";
            this.studentsGridView.Size = new System.Drawing.Size(457, 282);
            this.studentsGridView.TabIndex = 5;
            // 
            // uidStudent
            // 
            this.uidStudent.HeaderText = "UID";
            this.uidStudent.Name = "uidStudent";
            // 
            // nameStudent
            // 
            this.nameStudent.HeaderText = "Imię";
            this.nameStudent.Name = "nameStudent";
            // 
            // surnameStudent
            // 
            this.surnameStudent.HeaderText = "Nazwisko";
            this.surnameStudent.Name = "surnameStudent";
            // 
            // dateStudent
            // 
            this.dateStudent.HeaderText = "Data";
            this.dateStudent.Name = "dateStudent";
            // 
            // addLesson
            // 
            this.addLesson.Location = new System.Drawing.Point(299, 33);
            this.addLesson.Name = "addLesson";
            this.addLesson.Size = new System.Drawing.Size(83, 23);
            this.addLesson.TabIndex = 6;
            this.addLesson.Text = "Dodaj wykład";
            this.addLesson.UseVisualStyleBackColor = true;
            this.addLesson.Click += new System.EventHandler(this.button1_Click);
            // 
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 358);
            this.Controls.Add(this.addLesson);
            this.Controls.Add(this.studentsGridView);
            this.Controls.Add(this.subjectGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OknoGlowne";
            this.Text = "OknoGlowne";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subjectGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ToolStripMenuItem odświeżToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView subjectGridView;
        private System.Windows.Forms.DataGridView studentsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn uidStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateStudent;
        private System.Windows.Forms.Button addLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn startSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn endSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn presentSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn apsentSubjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn allSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn wSub;
        private System.Windows.Forms.DataGridViewTextBoxColumn kSub;
    }
}