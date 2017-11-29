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
    public partial class OknoDodwaniaRocznika : Form
    {
        private OknoAdmina OA;
        public OknoDodwaniaRocznika(OknoAdmina _OA)
        {
            InitializeComponent();
            OA = _OA;
            comboBoxAddElements();
        }
        public OknoDodwaniaRocznika(OknoAdmina _OA, string id, string rok, string wydzial, string kierunek)
        {
            InitializeComponent();
            comboBoxAddElements();
            OA = _OA;
            editCheckBox.Checked = true;
            editCheckBox.Enabled = false;
            idTextBox.Text = id;
            rokTextBox.Text = rok;
            wydzialComboBox.Text = wydzial;
            kierunekComboBox.Text = kierunek;
            addButton.Text = "Edytuj";
        }
        private void comboBoxAddElements()
        {
            List<string>[] lista = OA.getListFromYears();
            wydzialComboBox.Items.AddRange(lista[0].ToArray());
            kierunekComboBox.Items.AddRange(lista[1].ToArray());
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (rokTextBox.Text == "" || wydzialComboBox.Text == "" || kierunekComboBox.Text == "")
            {
                MessageBox.Show("Błąd! Żadne z pól nie może być puste!", "Błąd!", MessageBoxButtons.OK);
            }
            else
            {
                if (editCheckBox.Checked == true)
                {//edytujemy wpis
                    if (idTextBox.Text == "")
                    {
                        MessageBox.Show("Proszę wyjść i wybrać z listy element do edycji.", "Błąd", MessageBoxButtons.OK);
                    }
                    else
                    {
                        OA.msql.UptadeYear(idTextBox.Text, rokTextBox.Text, wydzialComboBox.Text, kierunekComboBox.Text);
                        Close();
                    }
                }
                else
                {//dodajemy nowy
                    OA.msql.InsertYear(rokTextBox.Text, wydzialComboBox.Text, kierunekComboBox.Text);
                    Close();
                }
            }
        }
        private void OknoDodwaniaRocznika_FormClosing(object sender, FormClosingEventArgs e)
        {
            OA.RefreshYearsTmp();
        }
    }
}
