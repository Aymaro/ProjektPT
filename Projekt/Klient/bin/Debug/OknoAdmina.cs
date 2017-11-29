﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Klient
{
    public partial class OknoAdmina : Form
    {
        //zmienne globalne
        List<string> Dane;
        public MySqlEngineKlient msql = new MySqlEngineKlient();
        //wątki do odswiezania list
        Thread RefreshUsersListThread;
        Thread RefreshYearsListThread;
        Thread RefreshLogThread;
        Thread RefreshSubjectsListThread;
        Thread RefreshTeachersListThread;


        //Konstruktory
        public OknoAdmina()
        {
            InitializeComponent();
        }
        public OknoAdmina(List<string> _Dane)
        {
            InitializeComponent();
            Dane = _Dane;
            Text = String.Format("Użytkownik: {0} {1}", Dane[1], Dane[2]);
        }
        //ładowanie formularza
        private void OknoAdmina_Load(object sender, EventArgs e)
        {
            //RefreshUsersTmp();
            //RefreshYearsTmp();
        }
        //karta studentow i kart 
        private void RefreshUsers_Click(object sender, EventArgs e)
        {
            RefreshUsersTmp();
        }
        public void RefreshUsersTmp()
        {
            RefreshUsersListThread = new Thread(RefreshUsersThreadDoWork);
            RefreshUsersListThread.Start();
            RefreshUsers.Enabled = false;
        }
        private void RefreshUsersThreadDoWork()

        {
            List<string>[] Lista = new List<string>[3];
            Lista = msql.SelectStudentList();
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
        private void AddUser_Click(object sender, EventArgs e)
        {
            using (OknoDodawania karta = new OknoDodawania(this, "k"))
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
                    RefreshUsersTmp();
                }
                else
                {
                    return;
                }

            }
        }
        private void EditUser_Click(object sender, EventArgs e)
        {
            EditUserTmp();
        }
        private void usersGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditUserTmp();
        }
        private void EditUserTmp()
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

                using (OknoDodawania karta = new OknoDodawania(this, dane[0], dane[1], dane[2]))
                {
                    karta.ShowDialog();
                }
            }
        }
        //roczniki
        private void yearsRefreshButton_Click(object sender, EventArgs e)
        {
            RefreshYearsTmp();
        }
        public void RefreshYearsTmp()
        {
            RefreshYearsListThread = new Thread(RefreshYearsThreadDoWork);
            RefreshYearsListThread.Start();
            yearsRefreshButton.Enabled = false;
        }
        private void RefreshYearsThreadDoWork()

        {
            List<string>[] Lista = new List<string>[5];
            Lista = msql.SelectYearsList();
            yearsGridView.Invoke(new Action(delegate ()
            {
                yearsGridView.Rows.Clear();
                for (int i = 0; i < Lista[0].Count; i++)
                {
                    yearsGridView.Rows.Add(Lista[0][i], Lista[1][i], Lista[2][i], Lista[3][i], Lista[4][i]);
                }
            }));

            yearsRefreshButton.Invoke(new Action(delegate ()
            {
                yearsRefreshButton.Enabled = true;
            }));

        }
        private void addYearButton_Click(object sender, EventArgs e)
        {
            using (OknoDodwaniaRocznika karta = new OknoDodwaniaRocznika(this))
            {
                karta.ShowDialog();
            }
        }
        private void removeYearButton_Click(object sender, EventArgs e)
        {
            if (yearsGridView.SelectedCells.Count == 0 || yearsGridView.CurrentCell.RowIndex > yearsGridView.Rows.Count)
            {
                MessageBox.Show("Musisz zaznaczyć chociaż jeden element z listy!", "Błąd", MessageBoxButtons.OK);
            }
            else if (yearsGridView.SelectedCells.Count > 1 && yearsGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jedną pozycję.", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                string id = yearsGridView.Rows[yearsGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Czy aby na pewno chcesz usunąć ten element?", "Potwierdź usunięcie.", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    msql.DeleteYear(id);
                    RefreshYearsTmp();
                }
                else
                {
                    return;
                }

            }
        }
        private void editYearButton_Click(object sender, EventArgs e)
        {
            if (yearsGridView.SelectedCells.Count == 0 || yearsGridView.CurrentCell.RowIndex > yearsGridView.Rows.Count)
            {
                MessageBox.Show("Musisz zaznaczyć chociaż jeden element z listy!", "Błąd", MessageBoxButtons.OK);
            }
            else if (yearsGridView.SelectedCells.Count > 1 && yearsGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jedną pozycję.", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                string[] dane = new string[yearsGridView.ColumnCount];
                for (int i = 0; i < yearsGridView.ColumnCount; i++)
                {
                    dane[i] = yearsGridView.Rows[yearsGridView.CurrentCell.RowIndex].Cells[i].Value.ToString();
                }

                using (OknoDodwaniaRocznika karta = new OknoDodwaniaRocznika(this, dane[0], dane[1], dane[2], dane[3]))
                {
                    karta.ShowDialog();
                }
            }
        }
        public List<string>[] getListFromYears()
            {
            List <string>[] lista = new List<string>[2];

            lista[0] = new List<string>();
            lista[1] = new List<string>();
            if (yearsGridView.RowCount > 0)
            {
                for (int i = 0; i < yearsGridView.RowCount; i++)
                {
                    if (lista[0].Contains(yearsGridView.Rows[i].Cells[2].Value.ToString()) == false)
                    {
                        lista[0].Add(yearsGridView.Rows[i].Cells[2].Value.ToString());
                    }
                    if (lista[1].Contains(yearsGridView.Rows[i].Cells[3].Value.ToString()) == false)
                    {
                        lista[1].Add(yearsGridView.Rows[i].Cells[3].Value.ToString());
                    }
                }
            }
            
            return lista;
            }
        //karta logu
        private void RefreshLog_Click(object sender, EventArgs e)
        {
            RefreshLogTmp();
        }
        private void RefreshLogTmp()
        {
            RefreshLogThread = new Thread(RefreshLogThreadDoWork);
            RefreshLogThread.Start();
            RefreshLog.Enabled = false;
        }
        private void RefreshLogThreadDoWork()
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
        //karta listy przedmiotow
        private void RefreshSubjectsList_Click(object sender, EventArgs e)
        {
            RefreshSubjectsListTmp();
        }
        private void RefreshSubjectsListTmp()
        {
            RefreshSubjectsListThread = new Thread(RefreshSubjectsListThreadDoWork);
            RefreshSubjectsListThread.Start();
            RefreshSubjectsList.Enabled = false;
        }
        private void RefreshSubjectsListThreadDoWork()
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
        //karta wykladowcow
        private void RefreshTeachers_Click(object sender, EventArgs e)
        {
            RefreshTeachersTmp();
        }
        public void RefreshTeachersTmp()
        {
            RefreshTeachersListThread = new Thread(RefreshTeachersListThreadDoWork);
            RefreshTeachersListThread.Start();
            RefreshTeachers.Enabled = false;
        }
        private void RefreshTeachersListThreadDoWork()
        {
            List<string>[] Lista = new List<string>[5];
            Lista = msql.SelectTeachersList();

            LogGrid.Invoke(new Action(delegate ()
            {
                TeachersGrid.Rows.Clear();
                for (int i = 0; i < Lista[0].Count; i++)
                {
                    TeachersGrid.Rows.Add(Lista[0][i], Lista[1][i], Lista[2][i], Lista[3][i], Lista[4][i]);
                }
            }));

            RefreshSubjectsList.Invoke(new Action(delegate ()
            {
                RefreshTeachers.Enabled = true;
            }));

        }
        private void AddTeacher_Click(object sender, EventArgs e)
        {
            using (OknoDodawania karta = new OknoDodawania(this,"w"))
            {
                karta.ShowDialog();
            }

        }
        private void RemoveTeacher_Click(object sender, EventArgs e)
        {
            if (TeachersGrid.SelectedCells.Count == 0 || TeachersGrid.CurrentCell.RowIndex > TeachersGrid.Rows.Count)
            {
                MessageBox.Show("Musisz zaznaczyć chociaż jeden element z listy!", "Błąd", MessageBoxButtons.OK);
            }
            else if (TeachersGrid.SelectedCells.Count > 1 && TeachersGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jedną pozycję.", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                string ID = TeachersGrid.Rows[TeachersGrid.CurrentCell.RowIndex].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Czy aby na pewno chcesz usunąć ten element?", "Potwierdź usunięcie.", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    msql.DeleteTeacher(ID);
                    RefreshTeachersTmp();
                }
                else
                {
                    return;
                }

            }
        }
        private void EditTeacher_Click(object sender, EventArgs e)
        {
            if (TeachersGrid.SelectedCells.Count == 0 || TeachersGrid.CurrentCell.RowIndex > TeachersGrid.Rows.Count)
            {
                MessageBox.Show("Musisz zaznaczyć chociaż jeden element z listy!", "Błąd", MessageBoxButtons.OK);
            }
            else if (TeachersGrid.SelectedCells.Count > 1 && TeachersGrid.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jedną pozycję.", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                string[] dane = new string[TeachersGrid.ColumnCount];
                for (int i = 0; i < TeachersGrid.ColumnCount; i++)
                {
                    dane[i] = TeachersGrid.Rows[TeachersGrid.CurrentCell.RowIndex].Cells[i].Value.ToString();
                }

                using (OknoDodawania karta = new OknoDodawania(this, dane[0], dane[1], dane[2], dane[3],dane[4]))
                {
                    karta.ShowDialog();
                }
            }
        }
        private void CheckTables_Click(object sender, EventArgs e)
        {
            List<string>[] Lista = new List<string>[5];
            Lista = msql.SelectTeachersList();
            int TeachersCount = Lista[0].Count;
            int added = 0;
            int exist = 0;
            for (int i = 0; i < Lista[0].Count; i++)
            {
                string name = "w_" + Lista[1][i].ToLower() + "_" + Lista[2][i].ToLower();
                if (msql.CheckIfExist(name) == false)
                {//nie ma takiej tabeli i ja tworzymy
                    added++;
                    msql.CreateTeacherTable(name);
                }
                else
                {
                    exist++;
                    continue;
                }
            }
            MessageBox.Show(String.Format(  "Liczba wykładowców: {0}\n" +
                                            "Liczba utworzonych nowych tabel: {1}\n" +
                                            "Liczba istniejących tabel: {2}",
                                            TeachersCount, added, exist),
                                            "Rezultat", MessageBoxButtons.OK);
        }
        //gorna listwa menu
        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Czy aby na pewno chcesz się wylogować?", "Potwierdź wyjście", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Hide();
                OknoLogowania OL = new OknoLogowania();
                OL.Closed += (s, args) => Close();
                OL.Show();
            }
        }
        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wszelkie pytania lub pomysły dotyczące\n" +
                            "aplikacji prosze słać na maila:\n" +
                            "michal.parus@gmail.com");
        }
        private void AdminTabPageBox_Selected(object sender, TabControlEventArgs e)
        {
            switch (AdminTabPageBox.SelectedIndex)
            {
                //tylko kiedy jest pusta
                case 0:
                    if (usersGrid.RowCount == 0)
                    {
                        RefreshUsersTmp();
                        RefreshYearsTmp();
                    }
                    break;
                case 1:
                    if (LogGrid.RowCount == 0)
                    {
                        RefreshLogTmp();
                    }
                    break;
                case 2:
                    if (SubjectsListGrid.RowCount == 0)
                    {
                        RefreshSubjectsListTmp();
                    }
                    break;
                case 3:
                    if (TeachersGrid.RowCount == 0)
                    {
                        RefreshTeachersTmp();
                    }
                    break;
                default:
                    break;
            }
        }

        
    }
}
