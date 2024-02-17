using HRMS_Lib;
using HRMS_Lib.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS_UI
{
    public partial class DodajPracownikaForm : Form
    {
        public DodajPracownikaForm()
        {
            InitializeComponent();
            PopulateComboBoxes(); // Uzupełnia ComboBoxy w formularzu
        }

        private void PopulateComboBoxes()
        {
            //Wydział:
            wydzialComboBox.Items.AddRange(GlobalConfig.Connection.PobierzNazweWydzialu().ToArray());

            //Przelozony
            przelozonyComboBox.Items.AddRange(GlobalConfig.Connection.PobierzIdPrzelozonego().ToArray());

            //Rola
            rolaComboBox.Items.AddRange(GlobalConfig.Connection.PobierzIdRoli().ToArray());

            //Rodzaj umowy:

            // Dodaj 3 umowy do ComboBoxa
            rodzajUmowyComboBox.Items.Add("Umowa o prace");
            rodzajUmowyComboBox.Items.Add("Umowa o zlecenie");
            rodzajUmowyComboBox.Items.Add("B2B");

            // Domyślnie zaznacz pierwszą umowę
            rodzajUmowyComboBox.SelectedIndex = -1;
        }

        private bool ValidateForm()
        {
            bool output = true;

            //Dane dotyczące umowy:

            //walidacja rodzaj umowy
            if (rodzajUmowyComboBox.SelectedIndex == -1)
            {
                output = false;
            }

            if (rodzajUmowyComboBox.Text != "Umowa o prace" && rodzajUmowyComboBox.Text != "Umowa o zlecenie" && rodzajUmowyComboBox.Text != "B2B")
            {
                MessageBox.Show("Wartość w Rodzaj umowy jest niepoprawna. Proszę wybrać jedną z podanych opcji.");
                output = false;
            }

            //walidacja pensji
            if (pensjaValue.Text.Length == 0)
            {
                output = false;
            }

            decimal pensja = 0;
            bool pensjaValid = decimal.TryParse(pensjaValue.Text, out pensja);

            if (pensjaValid == false)
            {
                output = false;
            }

            if (pensja <= 0)
            {
                output = false;
            }

            //Dane dotyczące pracownika:

            //walidacja 

            return output;
        }

        private void DodajPracownikaForm_Load(object sender, EventArgs e)
        {

        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                UmowyModel model = new UmowyModel(
                    rodzajUmowyComboBox.Text,
                    pensjaValue.Text,
                    dataZatrudnieniaDateTimePicker.Value,
                    dataKoncaUmowyDateTimePicker.Value);

                GlobalConfig.Connection.DodajUmowe(model);

                rodzajUmowyComboBox.SelectedIndex = -1;
                pensjaValue.Text = "";
                dataZatrudnieniaDateTimePicker.Text = "";
                dataKoncaUmowyDateTimePicker.Text = "";

            }
            else
            {
                MessageBox.Show("Formularz posiada niepoprawne dane. Proszę poprawić je i spróbować ponownie.");
            }
        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {

        }
    }
}
