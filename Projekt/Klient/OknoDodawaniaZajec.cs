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
        public OknoDodawaniaZajec(OknoGlowne _OG, List<string> _Dane, DateTime data)
        {
            InitializeComponent();
            OG = _OG;
            Dane = _Dane;
            Text = String.Format("Użytkownik: {0} {1}", Dane[1], Dane[2]);
            roczniki = OG.msql.SelectTeachersSubjects(Dane[0]);//id, rok, wydzial, kierunek, liczba
            setTextBoxes();
            monthCalendar1.SelectionStart = data;
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
                rocznikiLista.Add(String.Format("{0}/{1}/{2}/{3}/{4}", roczniki[0][i], roczniki[1][i], roczniki[2][i], roczniki[3][i],roczniki[4][i]));
            }
            subjectComboBox.Items.AddRange(rocznikiLista.ToArray());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (subjectComboBox.Text == "")
            {
                MessageBox.Show("Pole wyboru przedmiotu nie może być puste!", "Błąd", MessageBoxButtons.OK);
            }
            else
            {
                DateTime tmp = monthCalendar1.SelectionStart;
                string data = null;
                data += String.Format("{0}-{1}-{2}", tmp.Year, tmp.Month, tmp.Day);
                string poczatek, koniec;
                poczatek = String.Format("{0}:{1}:00", startHour.Value, startMinutes.Value);
                koniec = String.Format("{0}:{1}:00", endHour.Value, endMinutes.Value);
                OG.msql.InsertLesson(Dane[0], data, poczatek, koniec, stringChecker(subjectComboBox.Text));
                OG.boldDates();
                OG.datePicked();
                Close();
            }
        }
        private string stringChecker(string input)
        {
            string result = null;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] != '/')
                {
                    result += input[i];
                }
                else
                {
                    return result;
                }
            }

            return result;
        }

        private void startHour_ValueChanged(object sender, EventArgs e)
        {
            if (endHour.Value <= startHour.Value)
            {
                endHour.Value = startHour.Value;
            }
        }

        private void endHour_ValueChanged(object sender, EventArgs e)
        {
            if (endHour.Value < startHour.Value)
            {
                endHour.Value = startHour.Value;
            }
        }
    }
}
