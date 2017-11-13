using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Klient
{
    public partial class OknoGlowne : Form
    {
        Thread RefreshUsersThread;
        Thread RefreshLogThread;
        Thread RefreshSubjectsListThread;

        public MySqlEngineKlient msql = new MySqlEngineKlient();
        public OknoGlowne()
        {
            InitializeComponent();
            new OknoLogowania(this).Show();
            Visible = false;
        }


        private void RefreshUsers_Click(object sender, EventArgs e)
        {
            RefreshUsersThread = new Thread(RefreshUsersThreadDoWork);
            RefreshUsersThread.Start();
            RefreshUsers.Enabled = false;
        }
        void RefreshUsersThreadDoWork()

        {
            List<string>[] Lista = new List<string>[3];
            Lista = msql.SelectUsers();
            usersGrid.Invoke(new Action(delegate ()
            {
                usersGrid.Rows.Clear();
                for (int i = 0; i < Lista[0].Count; i++)
                {
                    usersGrid.Rows.Add(Lista[0][i], Lista[1][i], Lista[2][i]);
                }
            }));

            RefreshUsers.Invoke(new Action(delegate ()
            {
                RefreshUsers.Enabled = true;
            }));
            
        }
        private void RefreshLog_Click(object sender, EventArgs e)
        {
            RefreshLogThread = new Thread(RefreshLogThreadDoWork);
            RefreshLogThread.Start();
            RefreshLog.Enabled = false;
        }
        void RefreshLogThreadDoWork()
        {
            List<string>[] Lista = new List<string>[6];
            Lista = msql.SelectLog();
            
            LogGrid.Invoke(new Action(delegate ()
            {
                LogGrid.Rows.Clear();
                for (int i = 0; i < Lista[0].Count; i++)
                {
                    LogGrid.Rows.Add(Lista[0][i], Lista[1][i], Lista[2][i], Lista[3][i], Lista[4][i], Lista[5][i]);
                }
            }));

            RefreshUsers.Invoke(new Action(delegate ()
            {
                RefreshLog.Enabled = true;
            }));

        }
        private void RefreshSubjectsList_Click(object sender, EventArgs e)
        {
            RefreshSubjectsListThread = new Thread(RefreshSubjectsListThreadDoWork);
            RefreshSubjectsListThread.Start();
            RefreshSubjectsList.Enabled = false;
        }
        void RefreshSubjectsListThreadDoWork()
        {
            List<string>[] Lista = new List<string>[2];
            Lista = msql.SelectSubjectList();

            LogGrid.Invoke(new Action(delegate ()
            {
                SubjectsListGrid.Rows.Clear();
                for (int i = 0; i < Lista[0].Count; i++)
                {
                    SubjectsListGrid.Rows.Add(Lista[0][i], Lista[1][i]);
                }
            }));

            RefreshSubjectsList.Invoke(new Action(delegate ()
            {
                RefreshSubjectsList.Enabled = true;
            }));

        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            using (DodajKarte karta = new DodajKarte(this))
            {
                karta.ShowDialog();
            }
        }

        private void RemoveUser_Click(object sender, EventArgs e)
        {
            if (usersGrid.SelectedCells.Count == 0 || usersGrid.CurrentCell.RowIndex > usersGrid.Rows.Count)
            {
                MessageBox.Show("Musisz zaznaczyć chociaż jeden element z listy!", "Błąd", MessageBoxButtons.OK);
            }
            else if (usersGrid.SelectedCells.Count > 1 && usersGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jedną pozycję.", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                string UID = usersGrid.Rows[usersGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Czy aby na pewno chcesz usunąć ten element?", "Potwierdź usunięcie.", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    msql.DeleteUser(UID);
                }
                else
                {
                    return;
                }
                
            }
        }

        private void EditUser_Click(object sender, EventArgs e)
        {
            if (usersGrid.SelectedCells.Count == 0 || usersGrid.CurrentCell.RowIndex > usersGrid.Rows.Count)
            {
                MessageBox.Show("Musisz zaznaczyć chociaż jeden element z listy!", "Błąd", MessageBoxButtons.OK);
            }
            else if (usersGrid.SelectedCells.Count > 1 && usersGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jedną pozycję.", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                string[] dane = new string[usersGrid.ColumnCount];
                for (int i = 0; i < usersGrid.ColumnCount; i++)
                {
                    dane[i] = usersGrid.Rows[usersGrid.CurrentCell.RowIndex].Cells[i].Value.ToString();
                }

                using (DodajKarte karta = new DodajKarte(this, dane[0], dane[1], dane[2]))
                {
                    karta.ShowDialog();
                }
            }

        }

        
    }
}
