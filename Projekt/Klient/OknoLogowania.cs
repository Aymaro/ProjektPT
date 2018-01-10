using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Klient
{
    public partial class OknoLogowania : Form
    {
        MySqlEngineKlient msql = new MySqlEngineKlient();
        
        
        public OknoLogowania()
        {
            InitializeComponent();
            addRegister();
            readLoginFromRegister();
            
        }
        private void saveLoginToRegister(string check)
        {
            addRegister();
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\PT", true);
            if (check == "yes")
            {
                regkey.SetValue("login", LoginTextBox.Text, RegistryValueKind.String);
                regkey.SetValue("haslo", PasswordTextBox.Text, RegistryValueKind.String);
                regkey.SetValue("remember", "yes", RegistryValueKind.String);
            }
            else
            {
                regkey.SetValue("remember", "no", RegistryValueKind.String);
            }
        }
        private void addRegister()
        {
            RegistryKey rgkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE", true);
            rgkey.CreateSubKey("PT"); //tworzenie podklucza\
            addRegisterDefaultValues();
        }
        private void addRegisterDefaultValues()
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\PT", true);
            if (regkey.GetValue("login") == null 
                && regkey.GetValue("haslo") == null 
                && regkey.GetValue("remember") == null)
            {
                regkey.SetValue("login", "", RegistryValueKind.String);
                regkey.SetValue("haslo", "", RegistryValueKind.String);
                regkey.SetValue("remember", "", RegistryValueKind.String);
            }
        }
        private void readLoginFromRegister()
        {
            RegistryKey regkey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\PT");
            if (regkey.GetValue("remember").ToString() == "yes")
            {
                LoginTextBox.Text = regkey.GetValue("login").ToString();
                PasswordTextBox.Text = regkey.GetValue("haslo").ToString();
                rememberMeCheckBox.Checked = true;
            }
            else
            {
                rememberMeCheckBox.Checked = false;
            }
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
                    //zapisanie do rejestru
                    if (rememberMeCheckBox.Checked)
                    {
                        saveLoginToRegister("yes");
                    }
                    else
                    {
                        saveLoginToRegister("no");
                    }
                    if (lista[0] == "1" || lista[0] == "4")
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
