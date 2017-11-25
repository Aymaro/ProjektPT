using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Klient
{
    public partial class OknoGlowne : Form
    {
        public MySqlEngineKlient msql = new MySqlEngineKlient();
        //zmienne globalne
        List<string> Dane;
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
            label1.Text = monthCalendar1.SelectionStart.ToString();
        }
    }
}
