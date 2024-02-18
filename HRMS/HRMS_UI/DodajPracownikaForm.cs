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
            //ZmianaNazwComboBox(); //Zamienia nazwy działów, stanowisk itp do numerów id poszczególnych dziedzin
        }

        private void PopulateComboBoxes()
        {
            //Wydział:
            wydzialComboBox.Items.AddRange(GlobalConfig.Connection.PobierzNazweWydzialu().ToArray());

            //Stanowisko
            stanowiskoComboBox.Items.AddRange(GlobalConfig.Connection.PobierzIdStanowiska().ToArray());

            //Przelozony
            przelozonyComboBox.Items.AddRange(GlobalConfig.Connection.PobierzIdPrzelozonego().ToArray());

            //Rola
            rolaComboBox.Items.AddRange(GlobalConfig.Connection.PobierzIdRoli().ToArray());

            //Rodzaj umowy:
            // Dodaj 3 umowy do ComboBoxa
            rodzajUmowyComboBox.Items.Add("Umowa o prace");
            rodzajUmowyComboBox.Items.Add("Umowa o zlecenie");
            rodzajUmowyComboBox.Items.Add("B2B");
            rodzajUmowyComboBox.Items.Add("Umowa o dzielo");

            // Domyślnie zaznacz pierwszą umowę
            rodzajUmowyComboBox.SelectedIndex = -1;
        }

        //private void ZmianaNazwComboBox()
        //{
        //    // wydzial

        //    if (wydzialComboBox.Text == "Wydział Rozwoju Oprogramowania")
        //    {
        //        wydzialComboBox.Text = "1";
        //    }
        //    else if (wydzialComboBox.Text == "Wydział Marketingu Cyfrowego")
        //    {
        //        wydzialComboBox.Text = "2";
        //    }
        //    else if (wydzialComboBox.Text == "Dział Finansowo-Księgowy")
        //    {
        //        wydzialComboBox.Text = "3";
        //    }
        //}

        private bool ValidateForm()
        {
            bool output = true;

            //Dane dotyczące umowy:

            //walidacja rodzaj umowy
            if (rodzajUmowyComboBox.SelectedIndex == -1)
            {
                output = false;
            }

            if (rodzajUmowyComboBox.Text != "Umowa o prace" && rodzajUmowyComboBox.Text != "Umowa o zlecenie" && rodzajUmowyComboBox.Text != "B2B" && rodzajUmowyComboBox.Text != "Umowa o dzielo")
            {
                //MessageBox.Show("Wartość w polu Rodzaj umowy jest niepoprawna. Proszę wybrać jedną z podanych opcji.");
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

            //walidacja imie i nazwisko
            if (imieValue.Text.Length == 0 || nazwiskoValue.Text.Length == 0)
            {
                output = false;
            }

            // sprawdzenie czy w imieniu lub nazwisku wystepuja znaki specjalne
            bool zawieraCyfryLubZnakiSpecjalne1 = false;

            foreach (char ch in imieValue.Text)
            {
                if (!char.IsLetter(ch))
                {
                    zawieraCyfryLubZnakiSpecjalne1 = true;
                }
            }

            bool zawieraCyfryLubZnakiSpecjalne2 = false;

            foreach (char ch in nazwiskoValue.Text)
            {
                if (!char.IsLetter(ch))
                {
                    zawieraCyfryLubZnakiSpecjalne2 = true;
                }
            }

            if (zawieraCyfryLubZnakiSpecjalne1 || zawieraCyfryLubZnakiSpecjalne2)
            {
                output = false;
            }

            // walidacja wydzial

            if (wydzialComboBox.SelectedIndex == -1)
            {
                output = false;
            }

            if (wydzialComboBox.Text != "1" && wydzialComboBox.Text != "2" && wydzialComboBox.Text != "3")
            {
                //MessageBox.Show("Wartość w polu Wydział jest niepoprawna. Proszę wybrać jedną z podanych opcji.");
                output = false;
            }

            //walidacja stanowisko

            if (stanowiskoComboBox.SelectedIndex == -1)
            {
                output = false;
            }

            if (stanowiskoComboBox.Text != "1" && stanowiskoComboBox.Text != "2" && stanowiskoComboBox.Text != "3")
            {
                //MessageBox.Show("Wartość w polu Stanowisko jest niepoprawna. Proszę wybrać jedną z podanych opcji.");
                output = false;
            }

            //walidacja przelozony 

            if (przelozonyComboBox.SelectedIndex == -1)
            {
                output = false;
            }

            //walidacja numer kontaktowy

            if (numerKontaktowyValue.Text.Length != 9)
            {
                output = false;
            }

            int numerKontaktowy = 0;
            bool numerKontaktowyValid = int.TryParse(numerKontaktowyValue.Text, out numerKontaktowy);

            if (numerKontaktowyValid == false)
            {
                output = false;
            }

            // walidacja email

            if (emailValue.Text.Length == 0)
            {
                output = false;
            }

            //sprawdzenie, czy podany email posiada znak @
            int at = 0;
            foreach (char ch in emailValue.Text) 
            {
                if (ch == '@')
                {
                    at +=1;
                }
            }

            if (at <= 0)
            {
                output = false;
            }

            //walidacja rola

            if (rolaComboBox.SelectedIndex == -1)
            {
                output = false;
            }

            if (rolaComboBox.Text != "1" && rolaComboBox.Text != "2" && rolaComboBox.Text != "3")
            {
                //MessageBox.Show("Wartość w polu Stanowisko jest niepoprawna. Proszę wybrać jedną z podanych opcji.");
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


                // sprawdzic czy wszystko sie zgadza
                PracownicyModel model2 = new PracownicyModel(
                    imieValue.Text,
                    nazwiskoValue.Text,
                    dataUrodzeniaDateTimePicker.Value,
                    wydzialComboBox.Text,
                    stanowiskoComboBox.Text,
                    przelozonyComboBox.Text,
                    //model.idUmowy,
                    numerKontaktowyValue.Text,
                    emailValue.Text,
                    rolaComboBox.Text);

                GlobalConfig.Connection.DodajPracownika(model2);

                imieValue.Text = "";
                nazwiskoValue.Text = "";
                dataUrodzeniaDateTimePicker.Text = "";
                wydzialComboBox.SelectedIndex = -1;
                stanowiskoComboBox.SelectedIndex = -1;
                przelozonyComboBox.SelectedIndex = -1;
                numerKontaktowyValue.Text = "";
                emailValue.Text = "";
                rolaComboBox.SelectedIndex = -1;
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
