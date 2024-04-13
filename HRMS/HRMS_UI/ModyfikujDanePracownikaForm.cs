using HRMS_Lib;
using HRMS_Lib.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS_UI
{
    public partial class ModyfikujDanePracownikaForm : Form
    {
        public ModyfikujDanePracownikaForm()
        {
            InitializeComponent();
            PopulateComboBoxes(); // Uzupełnia ComboBoxy w formularzu
            KeyPreview = true;      // do keybindow, pozwala formularzowi na przechwytywanie wszystkich klawiszy przez uzytkownika, niezaleznie gdzie znajduje sie focus
        }

        private void PopulateComboBoxes()
        {
            //Wydział:
            wydzialComboBox.Items.AddRange(GlobalConfig.Connection.PobierzNazweWydzialu().ToArray());

            //Stanowisko
            stanowiskoComboBox.Items.AddRange(GlobalConfig.Connection.PobierzNazweStanowiska().ToArray());

            //Przelozony
            przelozonyComboBox.Items.AddRange(GlobalConfig.Connection.PobierzIdPrzelozonego().ToArray());

            //Rola
            rolaComboBox.Items.AddRange(GlobalConfig.Connection.PobierzNazweRoli().ToArray());

            //Rodzaj umowy:
            // Dodaj 3 umowy do ComboBoxa
            rodzajUmowyComboBox.Items.Add("Umowa o prace");
            rodzajUmowyComboBox.Items.Add("Umowa o zlecenie");
            rodzajUmowyComboBox.Items.Add("B2B");
            rodzajUmowyComboBox.Items.Add("Umowa o dzielo");

            // Domyślnie zaznacz pierwszą umowę
            rodzajUmowyComboBox.SelectedIndex = -1;

            //Zapełnienie formularza aktualnymi danymi
            //DanePracownika

            imieValue.Text = GlobalData.daneUzytkownika[0];
            nazwiskoValue.Text = GlobalData.daneUzytkownika[1];
            dataUrodzeniaDateTimePicker.Value = DateTime.Parse(GlobalData.daneUzytkownika[2]);

            switch (GlobalData.daneUzytkownika[3])
            {
                case "1":
                    wydzialComboBox.Text = "Wydzial Rozwoju Oprogramowania";
                    break;
                case "2":
                    wydzialComboBox.Text = "Wydzial Marketingu Cyfrowego";
                    break;
                case "3":
                    wydzialComboBox.Text = "Dzial Finansowo-Ksiegowy";
                    break;
                default:
                    wydzialComboBox.Text = "Brak danych";
                    break;
            }

            switch (GlobalData.daneUzytkownika[4])
            {
                case "1":
                    stanowiskoComboBox.Text = "Prezes";
                    break;
                case "2":
                    stanowiskoComboBox.Text = "Programista";
                    break;
                case "3":
                    stanowiskoComboBox.Text = "Manager";
                    break;
                default:
                    stanowiskoComboBox.Text = "Brak danych";
                    break;
            }

            przelozonyComboBox.Text = GlobalData.daneUzytkownika[5];

            switch (GlobalData.daneUzytkownika[6])
            {
                case "1":
                    rolaComboBox.Text = "Administrator";
                    break;
                case "2":
                    rolaComboBox.Text = "Moderator";
                    break;
                case "3":
                    rolaComboBox.Text = "Użytkownik";
                    break;
                default:
                    rolaComboBox.Text = "Brak danych";
                    break;
            }

            numerKontaktowyValue.Text = GlobalData.daneUzytkownika[8];
            emailValue.Text = GlobalData.daneUzytkownika[9];

            //Dane umowy
            rodzajUmowyComboBox.Text = GlobalData.daneUmowy[0];
            pensjaValue.Text = GlobalData.daneUmowy[1];
            dataZatrudnieniaDateTimePicker.Value = DateTime.Parse(GlobalData.daneUmowy[2]);
            dataKoncaUmowyDateTimePicker.Value = DateTime.Parse(GlobalData.daneUmowy[3]);

            //Dane logowania
            loginValue.Text = GlobalData.daneLogowania[0];
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

            //login
            if (loginValue.Text.Length <= 3)
            {
                MessageBox.Show("Login powinien zawierać minimum 3 znaki.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                output = false;
            }

            // sprawdz, czy istnieje już podany w formularzu login w bazie
            //bool loginExists = false;
            List<string> logins = new List<string>();
            logins = GlobalConfig.Connection.PobierzLoginy();

            foreach (string login in logins)
            {
                if (login == loginValue.Text)
                {
                    MessageBox.Show("Podany login już istnieje.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    output = false;
                    break;
                }
            }

            //haslo
            if (hasloValue.Text.Length < 8)
            {
                output = false;
            }
            else if (!Regex.IsMatch(hasloValue.Text, @"\d"))
            {
                MessageBox.Show("Hasło powinno zawierać od 8 do 16 znaków, posiadać liczbę, znak specjalny, małą i dużą literę.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                output = false;
            }
            else if (!Regex.IsMatch(hasloValue.Text, @"[!@#$%^&*(),.?:{ }|<>]"))
            {
                MessageBox.Show("Hasło powinno zawierać od 8 do 16 znaków, posiadać liczbę, znak specjalny, małą i dużą literę.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                output = false;
            }
            else if (!Regex.IsMatch(hasloValue.Text, @"[a-z]"))
            {
                MessageBox.Show("Hasło powinno zawierać od 8 do 16 znaków, posiadać liczbę, znak specjalny, małą i dużą literę.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                output = false;
            }
            else if (!Regex.IsMatch(hasloValue.Text, @"[A-Z]"))
            {
                MessageBox.Show("Hasło powinno zawierać od 8 do 16 znaków, posiadać liczbę, znak specjalny, małą i dużą literę.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                output = false;
            }


            return output;
        }


        // keybindowanie przyciskow
        private void ModyfikujDanePracownika_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                modyfikujButton.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                zamknijButton.PerformClick();
            }
        }

        private void modyfikujButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                DialogResult dialogResult = MessageBox.Show("Jeśli to zrobisz, nastąpi zmiana danych pracownika w bazie danych. Na pewnno chcesz to zrobić?", "Modyfikacja danych pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    UmowyModel model = new UmowyModel(
                    GlobalData.daneUzytkownika[7],
                    rodzajUmowyComboBox.Text,
                    pensjaValue.Text,
                    dataZatrudnieniaDateTimePicker.Value,
                    dataKoncaUmowyDateTimePicker.Value);

                    GlobalConfig.Connection.ModyfikujUmowe(model);

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
                        GlobalData.idUzytkownika,
                        imieValue.Text,
                        nazwiskoValue.Text,
                        dataUrodzeniaDateTimePicker.Value,
                        //wydzialComboBox.Text,
                        wydzialId.ToString(),
                        //stanowiskoComboBox.Text,
                        stanowiskoId.ToString(),
                        przelozonyComboBox.Text,
                        GlobalData.daneUzytkownika[7],
                        numerKontaktowyValue.Text,
                        emailValue.Text,
                        //rolaComboBox.Text);
                        rolaId.ToString());

                    GlobalConfig.Connection.ModyfikujDanePracownika(model2);

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
                        GlobalData.idUzytkownika,
                        loginValue.Text,
                        hasloValue.Text);

                    GlobalConfig.Connection.ModyfikujDaneLogowania(model3);

                    loginValue.Text = "";
                    hasloValue.Text = "";

                    MessageBox.Show("Zapisano dane poprawnie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Formularz posiada niepoprawne dane. Proszę poprawić je i spróbować ponownie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
            ZarzadzajForm existingZarzadzajForm = Application.OpenForms.OfType<ZarzadzajForm>().FirstOrDefault();

            if (existingZarzadzajForm != null)
            {
                existingZarzadzajForm.Activate();
            }
            else
            {
                ZarzadzajForm zarzadzajForm = new ZarzadzajForm();
                zarzadzajForm.Show();
            }
            this.Close();
        }
    }
}
