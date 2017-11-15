using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Klient
{
    public partial class OknoGlowne : Form
    {
        public MySqlEngineKlient msql = new MySqlEngineKlient();
        List<string> Dane;
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

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            OknoLogowania OG = new OknoLogowania();
            OG.Closed += (s, args) => Close();
            OG.Show();
        }
    }
}
