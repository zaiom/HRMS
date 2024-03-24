using HRMS_Lib;
using HRMS_Lib.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HRMS_UI
{
    public partial class ZarzadzajForm : Form
    {
        public ZarzadzajForm()
        {
            InitializeComponent();

            ListBoxWireUp();                                                                                        //"oczyszcza" zawartość listBoxa a następnie dodaje
                                                                                                                    //idPracownikow o nizszej roli od zalogowanego uzytkownika
            listaPracownikowListBox.SelectedIndexChanged += listaPracownikowListBox_SelectedIndexChanged;
        }

        private void modyfikujButton_Click(object sender, EventArgs e)
        {

        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DodajPracownikaForm existingDodajPracownikaForm = Application.OpenForms.OfType<DodajPracownikaForm>().FirstOrDefault();

            if (existingDodajPracownikaForm != null)
            {
                existingDodajPracownikaForm.Activate();
            }
            else
            {
                DodajPracownikaForm dodajPracownikaForm = new DodajPracownikaForm();
                dodajPracownikaForm.Show();
            }
            this.Close();
        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
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
            this.Close();
        }

        private void ZarzadzajForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                zamknijButton.PerformClick();
            }
        }

        private void ListBoxWireUp()
        {
            List<int> idPracownikow = GlobalConfig.Connection.PobierzIdPracownikowZNizszaRola(GlobalData.LoggedUserRole.ToString());

            listaPracownikowListBox.Items.Clear();
            listaPracownikowListBox.Items.AddRange(idPracownikow.Select(id => id.ToString()).ToArray());
        }

        private void listaPracownikowListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listaPracownikowListBox.SelectedIndex != -1)
            {
                string selectedId = listaPracownikowListBox.SelectedItem.ToString();
                List<string> danePracownika = GlobalConfig.Connection.PobierzDanePracownika(selectedId);

                switch (danePracownika[3])
                {
                    case "1":
                        danePracownika[3] = "Wydzial Rozwoju Oprogramowania";
                        break;
                    case "2":
                        danePracownika[3] = "Wydzial Marketingu Cyfrowego";
                        break;
                    case "3":
                        danePracownika[3] = "Dzial Finansowo-Ksiegowy";
                        break;
                    default:
                        danePracownika[3] = "Brak danych";
                        break;
                }

                switch (danePracownika[4])
                {
                    case "1":
                        danePracownika[4] = "Prezes";
                        break;
                    case "2":
                        danePracownika[4] = "Programista";
                        break;
                    case "3":
                        danePracownika[4] = "Manager";
                        break;
                    default:
                        danePracownika[4] = "Brak danych";
                        break;
                }

                switch (danePracownika[6])
                {
                    case "1":
                        danePracownika[6] = "Administrator";
                        break;
                    case "2":
                        danePracownika[6] = "Moderator";
                        break;
                    case "3":
                        danePracownika[6] = "Użytkownik";
                        break;
                    default:
                        danePracownika[6] = "Brak danych";
                        break;
                }

                // Ustawienie informacji o pracowniku w labelu
                if (danePracownika.Count == 10)
                {
                    string info = $"Imię: {danePracownika[0]}\n" +
                                  $"Nazwisko: {danePracownika[1]}\n" +
                                  $"Data urodzenia: {danePracownika[2]}\n" +
                                  $"Wydział: {danePracownika[3]}\n" +
                                  $"Stanowisko: {danePracownika[4]}\n" +
                                  $"Przełożony: {danePracownika[5]}\n" +
                                  $"Rola: {danePracownika[6]}\n" +
                                  $"Umowa pracownika: {danePracownika[7]}\n" +
                                  $"Numer kontaktowy: {danePracownika[8]}\n" +
                                  $"Email: {danePracownika[9]}";
                    pracownikInfoLabel.Text = info;
                }
                else
                {
                    pracownikInfoLabel.Text = "Błąd pobierania danych pracownika.";
                }
            }
        }

        private void usunButton_Click(object sender, EventArgs e)
        {
            if (listaPracownikowListBox.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Jeśli to zrobisz, usuniesz pracownika z bazy danych. Na pewnno chcesz to zrobić?", "Usuwanie pracownika", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string selectedId = listaPracownikowListBox.SelectedItem.ToString();
                    List<string> danePracownika = GlobalConfig.Connection.PobierzDanePracownika(selectedId);

                    GlobalConfig.Connection.UsunPracownika(selectedId, danePracownika[7]);                                                   //usuwanie pracownika
                    ListBoxWireUp();                                                                                                         //aktualizacja zawartosci ListBoxa
                                                                                                                                                            
                    MessageBox.Show("Pracownik został pomyślnie usunięty.", "Usuwanie pracownika", MessageBoxButtons.OK, MessageBoxIcon.Information);       
                }

            }
        }
    }
}
