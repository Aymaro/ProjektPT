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
                repeatHasloTextBox.Hide();
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
            EditCheckBox.Enabled = false;
            OA = _OA;
            //chowamy elementy przydatne przy dodawaniu studentow
            LabelHaslo.Hide();
            LabelLogin.Hide();
            LoginTextBox.Hide();
            HasloTextBox.Hide();
            repeatHasloTextBox.Hide();
        }
        //Edycja wykladowcy
        public OknoDodawania(OknoAdmina _OA, string _ID, string _imie, string _nazwisko, string Login, string _haslo)
        {
            InitializeComponent();
            AddButton.Text = "Edytuj";
            akcja = "w";
            LabelID.Text = "ID";
            haslo = _haslo;
            imie = _imie;
            nazwisko = _nazwisko;
            UIDtextBox.Text = _ID;
            //UIDtextBox.Enabled = false;
            UIDtextBox.ReadOnly = true;
            ImieTextBox.Text = imie;
            LoginTextBox.Text = Login;
            HasloTextBox.Text = haslo;
            repeatHasloTextBox.Text = haslo;
            NazwiskoTextBox.Text = nazwisko;
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
                        return;
                    }
                    else
                    {
                        if (UIDtextBox.Text == UID)
                        {
                            OA.msql.UptadeStudent(UIDtextBox.Text, ImieTextBox.Text, NazwiskoTextBox.Text);
                        }
                        else
                        {
                            OA.msql.UptadeStudentWUID(UID, ImieTextBox.Text, NazwiskoTextBox.Text, UIDtextBox.Text);
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
                        return;
                    }
                    else
                    {
                        OA.msql.InsertStudent(UIDtextBox.Text, ImieTextBox.Text, NazwiskoTextBox.Text);
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
                        return;
                    }
                    else
                    {
                        //sprawdza czy haslo zostalo zmienione 
                        if (HasloTextBox.Text == haslo && repeatHasloTextBox.Text == haslo)
                        {
                            OA.msql.UptadeTeacher(UIDtextBox.Text, ImieTextBox.Text, NazwiskoTextBox.Text, LoginTextBox.Text, HasloTextBox.Text);
                            Close();
                        }
                        else
                        {
                            if (HasloTextBox.Text == repeatHasloTextBox.Text)
                            {
                                OA.msql.UptadeTeacher(UIDtextBox.Text, ImieTextBox.Text, NazwiskoTextBox.Text, LoginTextBox.Text, OA.msql.MD5Hash(HasloTextBox.Text));
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Oba hasła muszą być identyczne!", "Błąd", MessageBoxButtons.OK);
                                return;
                            }
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
                        return;
                    }
                    else
                    {
                        if (HasloTextBox.Text == repeatHasloTextBox.Text)
                        {
                            OA.msql.InsertTeacher(ImieTextBox.Text, NazwiskoTextBox.Text, LoginTextBox.Text, OA.msql.MD5Hash(HasloTextBox.Text));
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Oba hasła muszą być identyczne!", "Błąd", MessageBoxButtons.OK);
                            return;
                        }
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
