using HRMS_Lib;
using Microsoft.VisualBasic.Logging;

namespace HRMS_UI
{
    public partial class LogowanieForm : Form
    {
        // tutaj dodac zmienna o typie danych np. PracownicyModel / UzytkownicyModel i po zalogowaniu sie uzupelnialo by jej dane??

        public LogowanieForm()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool output = true;

            //login


            //haslo

            return output;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                List<string> logins = new List<string>();
                logins = GlobalConfig.Connection.PobierzLoginy();                                           // loginy z bazy  danych

                string givenPassword = "";                                                                  // haslo, ktore wpisuje uzytkownik
                givenPassword = GlobalConfig.Connection.HashPassword(hasloValue.Text);                      // hashuj podane haslo

                string matchingDB = "";

                foreach (string login in logins)
                {
                    if (loginValue.Text == login)
                    {
                        matchingDB = GlobalConfig.Connection.PobierzHaslo(login);                           // selectuje z bazy has³o, o loginie podanym w textboxie
                        if (givenPassword == matchingDB)
                        {
                            // przejdz na nastepne okno, zamknij okno logowania i zapamietaj uzytkownika
                            MenuForm menuForm = new MenuForm();
                            menuForm.Show();
                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Podany login lub has³o jest niepoprawny. Spróbuj ponownie.");
            }
        }
    }
}