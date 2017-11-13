using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Klient
{
    public partial class OknoLogowania : Form
    {
        MySqlEngineKlient msql = new MySqlEngineKlient();
        OknoGlowne OG;
        public OknoLogowania(OknoGlowne _OG)
        {
            InitializeComponent();
            OG = _OG;
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
                lista = msql.LoginUser(LoginTextBox.Text, PasswordTextBox.Text);
                if (lista.Count == 0)
                {
                    MessageBox.Show("Podano błędne dane logowania!", "Błąd logowania!", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    OG.Visible = true;
                    Close();
                }
            }
        }
    }
}
