namespace Klient
{
    partial class OknoGlowne
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
            this.RefreshLessons = new System.Windows.Forms.TabControl();
            this.ListaUzytkownikow = new System.Windows.Forms.TabPage();
            this.EditUser = new System.Windows.Forms.Button();
            this.RemoveUser = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RefreshSubjectsList = new System.Windows.Forms.Button();
            this.SubjectsListGrid = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogGrid)).BeginInit();
            this.RefreshLessons.SuspendLayout();
            this.ListaUzytkownikow.SuspendLayout();
            this.Log.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsListGrid)).BeginInit();
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
            this.usersGrid.Size = new System.Drawing.Size(352, 285);
            this.usersGrid.TabIndex = 1;
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
            this.LogGrid.Location = new System.Drawing.Point(6, 35);
            this.LogGrid.Name = "LogGrid";
            this.LogGrid.ReadOnly = true;
            this.LogGrid.Size = new System.Drawing.Size(680, 285);
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
            // RefreshLessons
            // 
            this.RefreshLessons.Controls.Add(this.ListaUzytkownikow);
            this.RefreshLessons.Controls.Add(this.Log);
            this.RefreshLessons.Controls.Add(this.tabPage1);
            this.RefreshLessons.Location = new System.Drawing.Point(12, 12);
            this.RefreshLessons.Name = "RefreshLessons";
            this.RefreshLessons.SelectedIndex = 0;
            this.RefreshLessons.Size = new System.Drawing.Size(700, 352);
            this.RefreshLessons.TabIndex = 4;
            // 
            // ListaUzytkownikow
            // 
            this.ListaUzytkownikow.Controls.Add(this.EditUser);
            this.ListaUzytkownikow.Controls.Add(this.RemoveUser);
            this.ListaUzytkownikow.Controls.Add(this.AddUser);
            this.ListaUzytkownikow.Controls.Add(this.RefreshUsers);
            this.ListaUzytkownikow.Controls.Add(this.usersGrid);
            this.ListaUzytkownikow.Location = new System.Drawing.Point(4, 22);
            this.ListaUzytkownikow.Name = "ListaUzytkownikow";
            this.ListaUzytkownikow.Padding = new System.Windows.Forms.Padding(3);
            this.ListaUzytkownikow.Size = new System.Drawing.Size(692, 326);
            this.ListaUzytkownikow.TabIndex = 0;
            this.ListaUzytkownikow.Text = "Lista użytkowników";
            this.ListaUzytkownikow.UseVisualStyleBackColor = true;
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
            // Log
            // 
            this.Log.Controls.Add(this.RefreshLog);
            this.Log.Controls.Add(this.LogGrid);
            this.Log.Location = new System.Drawing.Point(4, 22);
            this.Log.Name = "Log";
            this.Log.Padding = new System.Windows.Forms.Padding(3);
            this.Log.Size = new System.Drawing.Size(692, 326);
            this.Log.TabIndex = 1;
            this.Log.Text = "Log";
            this.Log.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RefreshSubjectsList);
            this.tabPage1.Controls.Add(this.SubjectsListGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(692, 326);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Lista przedmiotów";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // OknoGlowne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 376);
            this.Controls.Add(this.RefreshLessons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "OknoGlowne";
            this.Text = "Klient";
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogGrid)).EndInit();
            this.RefreshLessons.ResumeLayout(false);
            this.ListaUzytkownikow.ResumeLayout(false);
            this.Log.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SubjectsListGrid)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TabControl RefreshLessons;
        private System.Windows.Forms.TabPage ListaUzytkownikow;
        private System.Windows.Forms.TabPage Log;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.Button EditUser;
        private System.Windows.Forms.Button RemoveUser;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button RefreshSubjectsList;
        private System.Windows.Forms.DataGridView SubjectsListGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

