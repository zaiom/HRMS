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

        //    if (wydzialComboBox.Text == "Wydzial Rozwoju Oprogramowania")
        //    {
        //        wydzialComboBox.Text = "1";
        //    }
        //    else if (wydzialComboBox.Text == "Wydzial Marketingu Cyfrowego")
        //    {
        //        wydzialComboBox.Text = "2";
        //    }
        //    else if (wydzialComboBox.Text == "Dzial Finansowo-Ksiegowy")
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

            if (wydzialComboBox.Text != "Wydzial Rozwoju Oprogramowania" && wydzialComboBox.Text != "Dzial Finansowo-Ksiegowy" && wydzialComboBox.Text != "Wydzial Marketingu Cyfrowego")
            {
                //MessageBox.Show("Wartość w polu Wydział jest niepoprawna. Proszę wybrać jedną z podanych opcji.");
                output = false;
            }

            //walidacja stanowisko

            if (stanowiskoComboBox.SelectedIndex == -1)
            {
                output = false;
            }

            if (stanowiskoComboBox.Text != "Prezes" && stanowiskoComboBox.Text != "Programista" && stanowiskoComboBox.Text != "Manager")
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
                    at += 1;
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

            if (rolaComboBox.Text != "Administrator" && rolaComboBox.Text != "Moderator" && rolaComboBox.Text != "Użytkownik")
            {
                //MessageBox.Show("Wartość w polu Stanowisko jest niepoprawna. Proszę wybrać jedną z podanych opcji.");
                output = false;
            }

            // Dane dotyczące logowania



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


                //zamiana nazwy wydzialu, stanowiska i roli, na odpowiedniki ich identyfikatorow z bazy
                int wydzialId = 0;
                switch (wydzialComboBox.Text)
                {
                    case "Wydzial Rozwoju Oprogramowania":
                        wydzialId = 1;
                        break;
                    case "Wydzial Marketingu Cyfrowego":
                        wydzialId = 2;
                        break;
                    case "Dzial Finansowo-Ksiegowy":
                        wydzialId = 3;
                        break;
                    default:
                        wydzialId = 0;
                        break;
                }

                int stanowiskoId = 0;
                switch (stanowiskoComboBox.Text)
                {
                    case "Prezes":
                        stanowiskoId = 1;
                        break;
                    case "Programista":
                        stanowiskoId = 2;
                        break;
                    case "Manager":
                        stanowiskoId = 3;
                        break;
                    default:
                        stanowiskoId = 0;
                        break;
                }

                int rolaId = 0;
                switch (rolaComboBox.Text)
                {
                    case "Administrator":
                        rolaId = 1;
                        break;
                    case "Moderator":
                        rolaId = 2;
                        break;
                    case "Użytkownik":
                        rolaId = 3;
                        break;
                    default:
                        rolaId = 0;
                        break;
                }

                PracownicyModel model2 = new PracownicyModel(
                    imieValue.Text,
                    nazwiskoValue.Text,
                    dataUrodzeniaDateTimePicker.Value,
                    //wydzialComboBox.Text,
                    wydzialId.ToString(),
                    //stanowiskoComboBox.Text,
                    stanowiskoId.ToString(),
                    przelozonyComboBox.Text,
                    //model.idUmowy,
                    numerKontaktowyValue.Text,
                    emailValue.Text,
                    //rolaComboBox.Text);
                    rolaId.ToString());

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


                UzytkownicyModel model3 = new UzytkownicyModel(
                    //model.idPracownika
                    loginValue.Text,
                    hasloValue.Text);

                GlobalConfig.Connection.DodajDaneLogowania(model3);

                loginValue.Text = "";
                hasloValue.Text = "";

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
