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
            PopulateRodzajUmowyComboBox(); // Wywołanie metody do uzupełniania ComboBoxa
        }

        private void PopulateRodzajUmowyComboBox()
        {
            // Dodaj 3 umowy do ComboBoxa
            rodzajUmowyComboBox.Items.Add("Umowa o pracę");
            rodzajUmowyComboBox.Items.Add("Umowa o zlecenie");
            rodzajUmowyComboBox.Items.Add("B2B");

            // Domyślnie zaznacz pierwszą umowę
            rodzajUmowyComboBox.SelectedIndex = 0;
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
    }
}
