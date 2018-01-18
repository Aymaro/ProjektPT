using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace Klient
{
    public partial class OknoGlowne : Form
    {
        public MySqlEngineKlient msql = new MySqlEngineKlient();
        //zmienne globalne
        List<string> Dane;//[0] id [1] imie [2] nazwisko
        List<DateTime> Daty;
        //konstruktory
        public OknoGlowne()
        {
            InitializeComponent();
        }
        public OknoGlowne(List<string> _Dane)
        {
            InitializeComponent();
            Dane = _Dane;
            Text = String.Format("Użytkownik: {0} {1}", Dane[1], Dane[2]);
            boldDates();
            datePicked();
        }
        //menu gorne
        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            OknoLogowania OG = new OknoLogowania();
            OG.Closed += (s, args) => Close();
            OG.Show();
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            datePicked();
        }

        public void datePicked()
        {
            studentsGridView.Rows.Clear();
            //pokazujemy dostepne wyklady dla danego dnia
            DateTime wybranaData = monthCalendar1.SelectionStart;
            string data = String.Format("{0}-{1}-{2}", wybranaData.Year, wybranaData.Month, wybranaData.Day);
            List<string>[] Lista = new List<string>[11];
            Lista = msql.selectLessonForTeacher(Dane[0], data);
            subjectGridView.Rows.Clear();
            for (int i = 0; i < Lista[0].Count; i++)
            {//mysql przedmiot, data, poczatek, koniec, studentowO, studentowN, studentowW, rok, wydzial, kierunek
                //okno przedmiot, poczatek ,koniec, o, n, w, rok, wydzial, kierunek
                subjectGridView.Rows.Add(Lista[0][i], Lista[1][i], Lista[3][i], Lista[4][i], Lista[5][i], Lista[6][i], Lista[7][i], Lista[8][i], Lista[9][i], Lista[10][i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OknoDodawaniaZajec karta = new OknoDodawaniaZajec(this, Dane, monthCalendar1.SelectionStart))
            {
                karta.ShowDialog();
            }
        }

        private void deleteLesson_Click(object sender, EventArgs e)
        {
            if (subjectGridView.SelectedCells.Count == 0 || subjectGridView.CurrentCell.RowIndex > subjectGridView.Rows.Count)
            {
                MessageBox.Show("Musisz zaznaczyć chociaż jeden element z listy!", "Błąd", MessageBoxButtons.OK);
            }
            else if (subjectGridView.SelectedCells.Count > 1 && subjectGridView.SelectedRows.Count != 1)
            {
                MessageBox.Show("Proszę zaznaczyć tylko jedną pozycję.", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                string id = subjectGridView.Rows[subjectGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();

                DialogResult result = MessageBox.Show("Czy aby na pewno chcesz usunąć ten element?", "Potwierdź usunięcie.", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    msql.deleteLesson(id);
                    boldDates();
                    datePicked();
                }
                else
                {
                    return;
                }

            }
        }

        public void boldDates()
        {
            monthCalendar1.RemoveAllBoldedDates();
            Daty = null;
            Daty = msql.selectLessonDates(Dane[0]);

            foreach (DateTime data in Daty)
            {
                monthCalendar1.AddBoldedDate(data);
            }
            monthCalendar1.UpdateBoldedDates();
        }

        private void subjectGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            subjectClickTmp();
        }
        private void subjectClickTmp()
        {
            string id = subjectGridView.Rows[subjectGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            List<string>[] Lista = new List<string>[5];
            Lista = msql.selectStudentsForLesson(id);
            studentsGridView.Rows.Clear();
            for (int i = 0; i < Lista[0].Count; i++)
            {
                studentsGridView.Rows.Add(Lista[0][i], Lista[1][i], Lista[2][i], Lista[3][i], Lista[4][i]);
                if (studentsGridView.Rows[i].Cells[4].Value.ToString() == "")
                {
                    studentsGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    studentsGridView.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
            }
        }
        private void studentsGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = studentsGridView.Rows[studentsGridView.CurrentCell.RowIndex].Cells[0].Value.ToString();
            if (studentsGridView.Rows[studentsGridView.CurrentCell.RowIndex].Cells[4].Value.ToString() == "")
            {
                msql.checkInStudent(id);
            }
            else
            {
                msql.checkOutStudent(id);
            }
            subjectClickTmp();
        }

        private void odświeżToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msql.checkStudentsForLesson();
        }
    }
}
