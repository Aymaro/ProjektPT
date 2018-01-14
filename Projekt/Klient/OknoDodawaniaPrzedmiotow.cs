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
    public partial class OknoDodawaniaPrzedmiotow : Form
    {
        OknoAdmina OA;
        string[] dane = new string[3];
        List<string>[] roczniki = new List<string>[5];
        List<string> rocznikiLista = new List<string>();
        public OknoDodawaniaPrzedmiotow(OknoAdmina _OA, string[] _dane)
        {
            InitializeComponent();
            OA = _OA;
            dane = _dane;
            Text = String.Format("Użytkownik: {0} {1}", dane[1], dane[2]);
            roczniki = OA.msql.SelectYearsList();//id, rok, wydzial, kierunek, liczba
            setTextBoxes();
            getSubjectsList();
        }
        private void setTextBoxes()
        {
            idTextBox.Text = dane[0];
            idTextBox.Enabled = false;
            nameTextBox.Text = dane[1];
            nameTextBox.Enabled = false;
            surnameTextBox.Text = dane[2];
            surnameTextBox.Enabled = false;
            for (int i = 0; i < roczniki[0].Count; i++)
            {
                rocznikiLista.Add(String.Format("{0}/{1}/{2}/{3}", roczniki[0][i], roczniki[1][i], roczniki[2][i], roczniki[3][i]));
            }
            yearsComboBox.Items.AddRange(rocznikiLista.ToArray());
        }
        private void getSubjectsList()
        {
            List<string>[] Lista = new List<string>[2];
            Lista = OA.msql.SelectSubjectList();
            subjectsComboBox.Items.AddRange(Lista[1].ToArray());
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
