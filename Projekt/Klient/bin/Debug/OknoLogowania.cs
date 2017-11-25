using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Klient
{
    public partial class OknoLogowania : Form
    {
        MySqlEngineKlient msql = new MySqlEngineKlient();
        public OknoLogowania()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (LoginTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Pola danych logowania nie mogą być puste!", "Błąd logowania!", MessageBoxButtons.OK);
            }
            else
            {
                List<string> lista = new List<string>();
                lista = msql.LoginUser(LoginTextBox.Text, msql.MD5Hash(PasswordTextBox.Text));
                if (lista.Count == 0)
                {
                    MessageBox.Show("Podano błędne dane logowania!", "Błąd logowania!", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (lista[0] == "1")
                    {
                        //Zalogowal sie administrator
                        Hide();
                        OknoAdmina OA = new OknoAdmina(lista);
                        OA.Closed += (s, args) => Close();
                        OA.Show();
                    }
                    else
                    {
                        //Uzytkownik poprawnie sie zalogowal.
                        Hide();
                        OknoGlowne OG = new OknoGlowne(lista);
                        OG.Closed += (s, args) => Close();
                        OG.Show();
                    }
                }
            }
        }
    }
}
