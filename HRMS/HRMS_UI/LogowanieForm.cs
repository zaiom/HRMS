using HRMS_Lib;
using HRMS_Lib.Modele;
using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;

namespace HRMS_UI
{
    public partial class LogowanieForm : Form
    {
        public LogowanieForm()
        {
            InitializeComponent();
            KeyPreview = true;          // do keybindow, pozwala formularzowi na przechwytywanie wszystkich klawiszy przez uzytkownika, niezaleznie gdzie znajduje sie focus
        }

        private bool ValidateForm()
        {
            bool output = true;

            // walidacja w logowaniu sprawdza czy istnieje podany login w bazie. Jesli jest, to sprawdza haslo przy samym logowaniu, jesli nie, to hasla nie musi sprawdzac prawda?
            // Porownanie czy podane haslo zgadza sie z tym z bazy danych jest w metodzie loginButton_Click
            //login

            //haslo

            return output;
        }


        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                List<string> logins = GlobalConfig.Connection.PobierzLoginy();                                     // loginy z bazy  danych
                                                              
                string givenPassword = GlobalConfig.Connection.HashPassword(hasloValue.Text);                     // haslo, ktore wpisuje uzytkownik, nastepnie je hashuj

                bool foundMatchingLogin = false;

                foreach (string login in logins)
                {
                    if (loginValue.Text == login)
                    {
                        string matchingDB = GlobalConfig.Connection.PobierzHaslo(login);                               // selectuje z bazy has�o, o loginie podanym w textboxie
                        if (givenPassword == matchingDB)
                        {
                            GlobalData.LoggedUserId = GlobalConfig.Connection.PobierzId(login);                                     // Przypisanie ID zalogowanego u�ytkownika do zmiennej globalnej
                            GlobalData.LoggedUserRole = GlobalConfig.Connection.PobierzIdRoli(GlobalData.LoggedUserId);             // przypisanie roli zalogowanego uzytkownika do zmiennej globalnej
                                                                                                                                    // po jego id

                            // przejdz na nastepne okno, zamknij okno logowania
                            MenuForm existingMenuForm = Application.OpenForms.OfType<MenuForm>().FirstOrDefault();

                            if (existingMenuForm != null)
                            {
                                existingMenuForm.Activate();
                            }
                            else
                            {
                                MenuForm menuForm = new MenuForm();
                                menuForm.Show();
                            }
                            foundMatchingLogin = true;
                            this.Close();
                            break;
                        }
                    }
                }
                if (!foundMatchingLogin)
                {
                    MessageBox.Show("Nieprawid�owy login lub has�o. Spr�buj ponownie.", "B��d!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void LogowanieForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }
    }
}