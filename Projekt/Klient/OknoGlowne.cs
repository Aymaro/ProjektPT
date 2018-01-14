using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Klient
{
    public partial class OknoGlowne : Form
    {
        public MySqlEngineKlient msql = new MySqlEngineKlient();
        //zmienne globalne
        List<string> Dane;//[0] id [1] imie [2] nazwisko
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
            //pokazujemy dostepne wyklady dla danego dnia
            DateTime wybranaData = monthCalendar1.SelectionStart;
            string data = String.Format("{0}-{1}-{2}", wybranaData.Year, wybranaData.Month, wybranaData.Day);
            List<string>[] Lista = new List<string>[10];
            Lista = msql.selectLessonForTeacher(Dane[0], data);
            subjectGridView.Rows.Clear();
            for (int i = 0; i < Lista[0].Count; i++)
            {//mysql przedmiot, data, poczatek, koniec, studentowO, studentowN, studentowW, rok, wydzial, kierunek
                //okno przedmiot, poczatek ,koniec, o, n, w, rok, wydzial, kierunek
                subjectGridView.Rows.Add(Lista[0][i], Lista[2][i], Lista[3][i], Lista[4][i], Lista[5][i], Lista[6][i], Lista[7][i], Lista[8][i], Lista[9][i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OknoDodawaniaZajec karta = new OknoDodawaniaZajec(this, Dane))
            {
                karta.ShowDialog();
            }
        }
    }
}
