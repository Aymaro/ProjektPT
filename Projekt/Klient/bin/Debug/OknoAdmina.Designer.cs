namespace Klient
{
    partial class OknoAdmina
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.RefreshUsers = new System.Windows.Forms.Button();
            this.usersGrid = new System.Windows.Forms.DataGridView();
            this.UID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogGrid = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RDR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RefreshLog = new System.Windows.Forms.Button();
            this.AdminTabPageBox = new System.Windows.Forms.TabControl();
            this.ListaUzytkownikowTabPage = new System.Windows.Forms.TabPage();
            this.EditUser = new System.Windows.Forms.Button();
            this.RemoveUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.LogTabPage = new System.Windows.Forms.TabPage();
            this.ListaPrzedmiotowTabPage = new System.Windows.Forms.TabPage();
            this.RefreshSubjectsList = new System.Windows.Forms.Button();
            this.SubjectsListGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ListaWykladowcowTabPage = new System.Windows.Forms.TabPage();
            this.EditTeacher = new System.Windows.Forms.Button();
            this.RemoveTeacher = new System.Windows.Forms.Button();
            this.AddTeacher = new System.Windows.Forms.Button();
            this.RefreshTeachers = new System.Windows.Forms.Button();
            this.TeachersGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haslo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckTables = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogGrid)).BeginInit();
            this.AdminTabPageBox.SuspendLayout();
            this.ListaUzytkownikowTabPage.SuspendLayout();
            this.LogTabPage.SuspendLayout();
            this.ListaPrzedmiotowTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsListGrid)).BeginInit();
            this.ListaWykladowcowTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshUsers
            // 
            this.RefreshUsers.Location = new System.Drawing.Point(6, 6);
            this.RefreshUsers.Name = "RefreshUsers";
            this.RefreshUsers.Size = new System.Drawing.Size(80, 23);
            this.RefreshUsers.TabIndex = 0;
            this.RefreshUsers.Text = "Odśwież listę";
            this.RefreshUsers.UseVisualStyleBackColor = true;
            this.RefreshUsers.Click += new System.EventHandler(this.RefreshUsers_Click);
            // 
            // usersGrid
            // 
            this.usersGrid.AllowUserToAddRows = false;
            this.usersGrid.AllowUserToDeleteRows = false;
            this.usersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UID,
            this.Imie,
            this.Nazwisko});
            this.usersGrid.Location = new System.Drawing.Point(6, 35);
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.ReadOnly = true;
            this.usersGrid.Size = new System.Drawing.Size(352, 270);
            this.usersGrid.TabIndex = 1;
            this.usersGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersGrid_CellDoubleClick);
            // 
            // UID
            // 
            this.UID.HeaderText = "UID";
            this.UID.Name = "UID";
            this.UID.ReadOnly = true;
            // 
            // Imie
            // 
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            this.Imie.ReadOnly = true;
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            this.Nazwisko.ReadOnly = true;
            // 
            // LogGrid
            // 
            this.LogGrid.AllowUserToAddRows = false;
            this.LogGrid.AllowUserToDeleteRows = false;
            this.LogGrid.AllowUserToResizeRows = false;
            this.LogGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Data,
            this.dataGridViewTextBoxColumn1,
            this.RDR,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.LogGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LogGrid.Location = new System.Drawing.Point(3, 38);
            this.LogGrid.Name = "LogGrid";
            this.LogGrid.ReadOnly = true;
            this.LogGrid.Size = new System.Drawing.Size(686, 270);
            this.LogGrid.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 40;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "UID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // RDR
            // 
            this.RDR.HeaderText = "RDR";
            this.RDR.Name = "RDR";
            this.RDR.ReadOnly = true;
            this.RDR.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Imie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // RefreshLog
            // 
            this.RefreshLog.Location = new System.Drawing.Point(6, 6);
            this.RefreshLog.Name = "RefreshLog";
            this.RefreshLog.Size = new System.Drawing.Size(80, 23);
            this.RefreshLog.TabIndex = 3;
            this.RefreshLog.Text = "Odśwież listę";
            this.RefreshLog.UseVisualStyleBackColor = true;
            this.RefreshLog.Click += new System.EventHandler(this.RefreshLog_Click);
            // 
            // AdminTabPageBox
            // 
            this.AdminTabPageBox.Controls.Add(this.ListaUzytkownikowTabPage);
            this.AdminTabPageBox.Controls.Add(this.LogTabPage);
            this.AdminTabPageBox.Controls.Add(this.ListaPrzedmiotowTabPage);
            this.AdminTabPageBox.Controls.Add(this.ListaWykladowcowTabPage);
            this.AdminTabPageBox.Location = new System.Drawing.Point(12, 27);
            this.AdminTabPageBox.Name = "AdminTabPageBox";
            this.AdminTabPageBox.SelectedIndex = 0;
            this.AdminTabPageBox.Size = new System.Drawing.Size(700, 337);
            this.AdminTabPageBox.TabIndex = 4;
            // 
            // ListaUzytkownikowTabPage
            // 
            this.ListaUzytkownikowTabPage.Controls.Add(this.EditUser);
            this.ListaUzytkownikowTabPage.Controls.Add(this.RemoveUser);
            this.ListaUzytkownikowTabPage.Controls.Add(this.AddUser);
            this.ListaUzytkownikowTabPage.Controls.Add(this.RefreshUsers);
            this.ListaUzytkownikowTabPage.Controls.Add(this.usersGrid);
            this.ListaUzytkownikowTabPage.Location = new System.Drawing.Point(4, 22);
            this.ListaUzytkownikowTabPage.Name = "ListaUzytkownikowTabPage";
            this.ListaUzytkownikowTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ListaUzytkownikowTabPage.Size = new System.Drawing.Size(692, 311);
            this.ListaUzytkownikowTabPage.TabIndex = 0;
            this.ListaUzytkownikowTabPage.Text = "Lista użytkowników/kart";
            this.ListaUzytkownikowTabPage.UseVisualStyleBackColor = true;
            // 
            // EditUser
            // 
            this.EditUser.Location = new System.Drawing.Point(254, 6);
            this.EditUser.Name = "EditUser";
            this.EditUser.Size = new System.Drawing.Size(75, 23);
            this.EditUser.TabIndex = 4;
            this.EditUser.Text = "Edytuj kartę";
            this.EditUser.UseVisualStyleBackColor = true;
            this.EditUser.Click += new System.EventHandler(this.EditUser_Click);
            // 
            // RemoveUser
            // 
            this.RemoveUser.Location = new System.Drawing.Point(173, 6);
            this.RemoveUser.Name = "RemoveUser";
            this.RemoveUser.Size = new System.Drawing.Size(75, 23);
            this.RemoveUser.TabIndex = 3;
            this.RemoveUser.Text = "Usuń kartę";
            this.RemoveUser.UseVisualStyleBackColor = true;
            this.RemoveUser.Click += new System.EventHandler(this.RemoveUser_Click);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(92, 6);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(75, 23);
            this.AddUser.TabIndex = 2;
            this.AddUser.Text = "Dodaj kartę";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // LogTabPage
            // 
            this.LogTabPage.Controls.Add(this.RefreshLog);
            this.LogTabPage.Controls.Add(this.LogGrid);
            this.LogTabPage.Location = new System.Drawing.Point(4, 22);
            this.LogTabPage.Name = "LogTabPage";
            this.LogTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LogTabPage.Size = new System.Drawing.Size(692, 311);
            this.LogTabPage.TabIndex = 1;
            this.LogTabPage.Text = "Log";
            this.LogTabPage.UseVisualStyleBackColor = true;
            // 
            // ListaPrzedmiotowTabPage
            // 
            this.ListaPrzedmiotowTabPage.Controls.Add(this.RefreshSubjectsList);
            this.ListaPrzedmiotowTabPage.Controls.Add(this.SubjectsListGrid);
            this.ListaPrzedmiotowTabPage.Location = new System.Drawing.Point(4, 22);
            this.ListaPrzedmiotowTabPage.Name = "ListaPrzedmiotowTabPage";
            this.ListaPrzedmiotowTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ListaPrzedmiotowTabPage.Size = new System.Drawing.Size(692, 311);
            this.ListaPrzedmiotowTabPage.TabIndex = 2;
            this.ListaPrzedmiotowTabPage.Text = "Lista przedmiotów";
            this.ListaPrzedmiotowTabPage.UseVisualStyleBackColor = true;
            // 
            // RefreshSubjectsList
            // 
            this.RefreshSubjectsList.Location = new System.Drawing.Point(6, 6);
            this.RefreshSubjectsList.Name = "RefreshSubjectsList";
            this.RefreshSubjectsList.Size = new System.Drawing.Size(80, 23);
            this.RefreshSubjectsList.TabIndex = 5;
            this.RefreshSubjectsList.Text = "Odśwież listę";
            this.RefreshSubjectsList.UseVisualStyleBackColor = true;
            this.RefreshSubjectsList.Click += new System.EventHandler(this.RefreshSubjectsList_Click);
            // 
            // SubjectsListGrid
            // 
            this.SubjectsListGrid.AllowUserToAddRows = false;
            this.SubjectsListGrid.AllowUserToDeleteRows = false;
            this.SubjectsListGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectsListGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.SubjectsListGrid.Location = new System.Drawing.Point(6, 35);
            this.SubjectsListGrid.Name = "SubjectsListGrid";
            this.SubjectsListGrid.ReadOnly = true;
            this.SubjectsListGrid.Size = new System.Drawing.Size(346, 256);
            this.SubjectsListGrid.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Id przedmiotu";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Pełna nazwa";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // ListaWykladowcowTabPage
            // 
            this.ListaWykladowcowTabPage.Controls.Add(this.CheckTables);
            this.ListaWykladowcowTabPage.Controls.Add(this.EditTeacher);
            this.ListaWykladowcowTabPage.Controls.Add(this.RemoveTeacher);
            this.ListaWykladowcowTabPage.Controls.Add(this.AddTeacher);
            this.ListaWykladowcowTabPage.Controls.Add(this.RefreshTeachers);
            this.ListaWykladowcowTabPage.Controls.Add(this.TeachersGrid);
            this.ListaWykladowcowTabPage.Location = new System.Drawing.Point(4, 22);
            this.ListaWykladowcowTabPage.Name = "ListaWykladowcowTabPage";
            this.ListaWykladowcowTabPage.Size = new System.Drawing.Size(692, 311);
            this.ListaWykladowcowTabPage.TabIndex = 3;
            this.ListaWykladowcowTabPage.Text = "Lista wykładowców";
            this.ListaWykladowcowTabPage.UseVisualStyleBackColor = true;
            // 
            // EditTeacher
            // 
            this.EditTeacher.Location = new System.Drawing.Point(254, 6);
            this.EditTeacher.Name = "EditTeacher";
            this.EditTeacher.Size = new System.Drawing.Size(75, 23);
            this.EditTeacher.TabIndex = 9;
            this.EditTeacher.Text = "Edytuj dane";
            this.EditTeacher.UseVisualStyleBackColor = true;
            this.EditTeacher.Click += new System.EventHandler(this.EditTeacher_Click);
            // 
            // RemoveTeacher
            // 
            this.RemoveTeacher.Location = new System.Drawing.Point(173, 6);
            this.RemoveTeacher.Name = "RemoveTeacher";
            this.RemoveTeacher.Size = new System.Drawing.Size(75, 23);
            this.RemoveTeacher.TabIndex = 8;
            this.RemoveTeacher.Text = "Usuń z listy";
            this.RemoveTeacher.UseVisualStyleBackColor = true;
            this.RemoveTeacher.Click += new System.EventHandler(this.RemoveTeacher_Click);
            // 
            // AddTeacher
            // 
            this.AddTeacher.Location = new System.Drawing.Point(92, 6);
            this.AddTeacher.Name = "AddTeacher";
            this.AddTeacher.Size = new System.Drawing.Size(75, 23);
            this.AddTeacher.TabIndex = 7;
            this.AddTeacher.Text = "Dodaj";
            this.AddTeacher.UseVisualStyleBackColor = true;
            this.AddTeacher.Click += new System.EventHandler(this.AddTeacher_Click);
            // 
            // RefreshTeachers
            // 
            this.RefreshTeachers.Location = new System.Drawing.Point(6, 6);
            this.RefreshTeachers.Name = "RefreshTeachers";
            this.RefreshTeachers.Size = new System.Drawing.Size(80, 23);
            this.RefreshTeachers.TabIndex = 5;
            this.RefreshTeachers.Text = "Odśwież listę";
            this.RefreshTeachers.UseVisualStyleBackColor = true;
            this.RefreshTeachers.Click += new System.EventHandler(this.RefreshTeachers_Click);
            // 
            // TeachersGrid
            // 
            this.TeachersGrid.AllowUserToAddRows = false;
            this.TeachersGrid.AllowUserToDeleteRows = false;
            this.TeachersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeachersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Login,
            this.haslo});
            this.TeachersGrid.Location = new System.Drawing.Point(6, 35);
            this.TeachersGrid.Name = "TeachersGrid";
            this.TeachersGrid.ReadOnly = true;
            this.TeachersGrid.Size = new System.Drawing.Size(449, 273);
            this.TeachersGrid.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Imie";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Nazwisko";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // haslo
            // 
            this.haslo.HeaderText = "Haslo";
            this.haslo.Name = "haslo";
            this.haslo.ReadOnly = true;
            this.haslo.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomocToolStripMenuItem,
            this.wylogujToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(724, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            this.wylogujToolStripMenuItem.Click += new System.EventHandler(this.wylogujToolStripMenuItem_Click);
            // 
            // CheckTables
            // 
            this.CheckTables.Location = new System.Drawing.Point(335, 6);
            this.CheckTables.Name = "CheckTables";
            this.CheckTables.Size = new System.Drawing.Size(95, 23);
            this.CheckTables.TabIndex = 10;
            this.CheckTables.Text = "Sprawdź tabele";
            this.CheckTables.UseVisualStyleBackColor = true;
            this.CheckTables.Click += new System.EventHandler(this.CheckTables_Click);
            // 
            // OknoAdmina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 376);
            this.Controls.Add(this.AdminTabPageBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OknoAdmina";
            this.Text = "Klient";
            this.Load += new System.EventHandler(this.OknoAdmina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogGrid)).EndInit();
            this.AdminTabPageBox.ResumeLayout(false);
            this.ListaUzytkownikowTabPage.ResumeLayout(false);
            this.LogTabPage.ResumeLayout(false);
            this.ListaPrzedmiotowTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsListGrid)).EndInit();
            this.ListaWykladowcowTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TeachersGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshUsers;
        private System.Windows.Forms.DataGridView usersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn UID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridView LogGrid;
        private System.Windows.Forms.Button RefreshLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RDR;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TabControl AdminTabPageBox;
        private System.Windows.Forms.TabPage ListaUzytkownikowTabPage;
        private System.Windows.Forms.TabPage LogTabPage;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button RemoveUser;
        private System.Windows.Forms.TabPage ListaPrzedmiotowTabPage;
        private System.Windows.Forms.Button RefreshSubjectsList;
        private System.Windows.Forms.DataGridView SubjectsListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.TabPage ListaWykladowcowTabPage;
        private System.Windows.Forms.Button EditTeacher;
        private System.Windows.Forms.Button RemoveTeacher;
        private System.Windows.Forms.Button AddTeacher;
        private System.Windows.Forms.Button RefreshTeachers;
        private System.Windows.Forms.DataGridView TeachersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewTextBoxColumn haslo;
        private System.Windows.Forms.Button CheckTables;
    }
}

