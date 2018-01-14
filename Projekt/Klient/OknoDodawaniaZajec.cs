using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Klient
{
    public partial class OknoDodawaniaZajec : Form
    {
        OknoGlowne OG;
        List<string> Dane = new List<string>();
        List<string>[] roczniki = new List<string>[5];
        List<string> rocznikiLista = new List<string>();
        public OknoDodawaniaZajec(OknoGlowne _OG, List<string> _Dane)
        {
            InitializeComponent();
            OG = _OG;
            Dane = _Dane;
            Text = String.Format("Użytkownik: {0} {1}", Dane[1], Dane[2]);
            roczniki = OG.msql.SelectYearsList();//id, rok, wydzial, kierunek, liczba
            setTextBoxes();
        }
        private void setTextBoxes()
        {
            idTextBox.Text = Dane[0];
            idTextBox.Enabled = false;
            nameTextBox.Text = Dane[1];
            nameTextBox.Enabled = false;
            surnameTextBox.Text = Dane[2];
            surnameTextBox.Enabled = false;
            for (int i = 0; i < roczniki[0].Count; i++)
            {
                rocznikiLista.Add(String.Format("{0}/{1}/{2}/{3}", roczniki[0][i], roczniki[1][i], roczniki[2][i], roczniki[3][i]));
            }
            yearsComboBox.Items.AddRange(rocznikiLista.ToArray());
        }
    }
}
