using System;
using System.Windows.Forms;

namespace Klient
{
    public partial class OknoDodawania : Form
    {
        private OknoAdmina OA;
        private string UID = null;
        private string haslo = null;
        private string imie = null;
        private string nazwisko = null;
        string akcja = null;

        //Dodawanie uzytkownika/karty
        public OknoDodawania(OknoAdmina _OA, string _akcja)
        {
            InitializeComponent();
            akcja = _akcja;
            OA = _OA;
            AddButton.Text = "Dodaj";
            if (akcja == "k")//chowamy elementy przydatne przy dodawaniu wykladowcow
            {
                LabelID.Text = "UID";
                LabelHaslo.Hide();
                LabelLogin.Hide();
                LoginTextBox.Hide();
                HasloTextBox.Hide();
            }
            else if ( akcja == "w")
            {
                UIDtextBox.Enabled = false;
                LabelID.Text = "ID";
            }
        }
        //Edycja uzytkownika/karty
        public OknoDodawania(OknoAdmina _OA,string _UID, string Imie, string Nazwisko)
        {
            InitializeComponent();
            akcja = "k";
            AddButton.Text = "Edytuj";
            LabelID.Text = "UID";
            UID = _UID;
            UIDtextBox.Text = UID;
            ImieTextBox.Text = Imie;
            NazwiskoTextBox.Text = Nazwisko;
            EditCheckBox.Checked = true;
            OA = _OA;
            //chowamy elementy przydatne przy dodawaniu wykladowcow
            LabelHaslo.Hide();
            LabelLogin.Hide();
            LoginTextBox.Hide();
            HasloTextBox.Hide();
        }
        //Edycja wykladowcy
        public OknoDodawania(OknoAdmina _OA, string _ID, string Imie, string Nazwisko, string Login, string Haslo)
        {
            InitializeComponent();
            AddButton.Text = "Edytuj";
            akcja = "w";
            LabelID.Text = "ID";
            haslo = Haslo;
            imie = Imie;
            nazwisko = Nazwisko;
            UIDtextBox.Text = _ID;
            //UIDtextBox.Enabled = false;
            UIDtextBox.ReadOnly = true;
            ImieTextBox.Text = Imie;
            LoginTextBox.Text = Login;
            HasloTextBox.Text = Haslo;
            NazwiskoTextBox.Text = Nazwisko;
            EditCheckBox.Checked = true;
            OA = _OA;
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (akcja == "k")
            {//Akcje wykonywane na uzytkownikach (studentach) i kartach
                if (EditCheckBox.Checked)
                {
                    //eddycja wpisu
                    if (    UIDtextBox.Text == "" 
                         || ImieTextBox.Text == "" 
                         || NazwiskoTextBox.Text == "")
                    {
                        MessageBox.Show("Błąd! Żadne z pól nie może być puste!", "Błąd!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        if (UIDtextBox.Text == UID)
                        {
                            OA.msql.UptadeUser(UIDtextBox.Text, ImieTextBox.Text, NazwiskoTextBox.Text);
                        }
                        else
                        {
                            OA.msql.UptadeUserWUID(UID, ImieTextBox.Text, NazwiskoTextBox.Text, UIDtextBox.Text);
                        }
                        Close();
                    }
                }
                else
                {
                    //dodanie nowego
                    if (   UIDtextBox.Text == "" 
                        || ImieTextBox.Text == "" 
                        || NazwiskoTextBox.Text == "")
                    {
                        MessageBox.Show("Błąd! Żadne z pól nie może być puste!", "Błąd!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        OA.msql.InsertUser(UIDtextBox.Text, ImieTextBox.Text, NazwiskoTextBox.Text);
                        Close();
                    }
                }
            }
            else if (akcja == "w")
            {//akcje wykonywane na wykladowcach
                if (EditCheckBox.Checked)
                {
                    //eddycja wpisu
                    if (       ImieTextBox.Text == "" 
                            || NazwiskoTextBox.Text == "" 
                            || LoginTextBox.Text == "" 
                            || HasloTextBox.Text == "") 
                    {
                        MessageBox.Show("Błąd! Żadne z pól nie może być puste!", "Błąd!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //sprawdza czy haslo zostalo zmienione 
                        if (HasloTextBox.Text == haslo)
                        {
                            OA.msql.UptadeTeacher(UIDtextBox.Text, ImieTextBox.Text, NazwiskoTextBox.Text, LoginTextBox.Text, HasloTextBox.Text);
                        }
                        else
                        {
                            OA.msql.UptadeTeacher(UIDtextBox.Text, ImieTextBox.Text, NazwiskoTextBox.Text, LoginTextBox.Text, OA.msql.MD5Hash(HasloTextBox.Text));
                        }

                        //sprawdzamy czy imie lub nazwisko zostalo zmienione
                        if (imie == ImieTextBox.Text && nazwisko == NazwiskoTextBox.Text)
                        {
                            Close();
                        }
                        else
                        {
                            string oldName = String.Format("w_{0}_{1}", imie.ToLower(), nazwisko.ToLower());
                            string newName = String.Format("w_{0}_{1}", ImieTextBox.Text.ToLower(), NazwiskoTextBox.Text.ToLower());
                            OA.msql.RenameTable(oldName, newName);
                        }
                        

                        Close();
                    }
                }
                else
                {
                    //dodanie nowego
                    if ( ImieTextBox.Text == ""
                      || NazwiskoTextBox.Text == ""
                      || LoginTextBox.Text == ""
                      || HasloTextBox.Text == "")
                    {
                        MessageBox.Show("Błąd! Żadne z pól nie może być puste!", "Błąd!", MessageBoxButtons.OK);
                    }
                    else
                    {
                        OA.msql.InsertTeacher(ImieTextBox.Text, NazwiskoTextBox.Text, LoginTextBox.Text, OA.msql.MD5Hash(HasloTextBox.Text));
                        Close();
                    }
                }
            }
        }

        private void HasloTextBox_Click(object sender, EventArgs e)
        {
            HasloTextBox.SelectAll();
        }

        private void OknoDodawania_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (akcja == "w")
            {
                OA.RefreshTeachersTmp();
            }
            else if (akcja == "k")
            {
                OA.RefreshUsersTmp();
            }
        }
    }
}
