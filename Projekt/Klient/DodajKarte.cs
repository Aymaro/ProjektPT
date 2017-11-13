using System;
using System.Windows.Forms;

namespace Klient
{
    public partial class DodajKarte : Form
    {
        private OknoGlowne OG;
        private string UID = null;
        public DodajKarte(OknoGlowne OG_)
        {
            InitializeComponent();
            OG = OG_;
        }
        public DodajKarte(OknoGlowne OG_,string _UID, string Imie, string Nazwisko)
        {
            UID = _UID;
            InitializeComponent();
            UIDtextBox.Text = UID;
            ImieTextBox.Text = Imie;
            NazwiskoTextBox.Text = Nazwisko;
            EditCheckBox.Checked = true;
            OG = OG_;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (EditCheckBox.Checked)
            {
                //eddycja wpisu
                if (UIDtextBox.Text == "" || ImieTextBox.Text == "" || NazwiskoTextBox.Text == "")
                {
                    MessageBox.Show("Błąd! Żadne z pól nie może być puste!", "Błąd!", MessageBoxButtons.OK);
                }
                else
                {
                    if (UIDtextBox.Text == UID)
                    {
                        OG.msql.UptadeUser(UIDtextBox.Text, ImieTextBox.Text, NazwiskoTextBox.Text);
                    }
                    else
                    {
                        OG.msql.UptadeUserWUID(UID, ImieTextBox.Text, NazwiskoTextBox.Text, UIDtextBox.Text);
                    }
                    Close();
                }
            }
            else
            {
                //dodanie nowego
                if (UIDtextBox.Text == "" || ImieTextBox.Text == "" || NazwiskoTextBox.Text == "")
                {
                    MessageBox.Show("Błąd! Żadne z pól nie może być puste!", "Błąd!", MessageBoxButtons.OK);
                }
                else
                {
                    OG.msql.InsertUser(UIDtextBox.Text, ImieTextBox.Text, NazwiskoTextBox.Text);
                    Close();
                }
            }
        }
    }
}
