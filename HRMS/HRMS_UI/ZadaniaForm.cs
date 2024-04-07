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
    public partial class ZadaniaForm : Form
    {
        public ZadaniaForm()
        {
            InitializeComponent();

            WidocznoscElementow();

            ListBoxWireUp();                                                                                                //"oczyszcza" zawartość listBoxa a następnie dodaje
                                                                                                                            //idPracownikow o nizszej roli od zalogowanego uzytkownika
            zagadnieniaListBox.SelectedIndexChanged += zagadnieniaListBox_SelectedIndexChanged;

            WyswietlOstatnieZadania();

            KeyPreview = true;
        }

        private void WidocznoscElementow()
        {
            if (GlobalData.LoggedUserRole == 1 || GlobalData.LoggedUserRole == 2)
            {
                dodajLinkLabel.Visible = true;
                przydzielLinkLabel.Visible = true;
            }
            else
            {
                dodajLinkLabel.Visible = false;
                przydzielLinkLabel.Visible = false;
            }
        }

        private void WyswietlOstatnieZadania()
        {
            ostatnieZadaniaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void zagadnieniaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zagadnieniaListBox.SelectedIndex != -1)
            {
                string selectedTask = zagadnieniaListBox.SelectedItem.ToString();
                string nazwaZagadnienia = GlobalConfig.Connection.PobierzNazweZagadnienia(selectedTask);
                string opisZagadnienia = GlobalConfig.Connection.PobierzOpisZagadnienia(selectedTask);

                //włączenie widoczności napisów
                nazwaZagadnieniaTextBox.Visible = true;
                opisZagadnieniaTextBox.Visible = true;

                // zmiana tekstów napisów
                nazwaZagadnieniaTextBox.Text = nazwaZagadnienia;
                opisZagadnieniaTextBox.Text = opisZagadnienia;

                //pobranie z bazy danych odnośnie zadań wpisanych do zaznaczonego zagadnienia
                //List<string> daneZagadnienia = GlobalConfig.Connection.PobierzDaneZagadnienia(GlobalData.LoggedUserId.ToString(), selectedTask);
                //ostatnieZadaniaDataGridView.DataSource = daneZagadnienia;
                List<ZadaniaModel> daneZagadnienia = GlobalConfig.Connection.PobierzDaneZagadnienia(GlobalData.LoggedUserId.ToString(), selectedTask);
                ostatnieZadaniaDataGridView.DataSource = daneZagadnienia;
                ostatnieZadaniaDataGridView.Columns["idZadania"].Visible = false;
                ostatnieZadaniaDataGridView.Columns["idPracownika"].Visible = false;
            }
        }

        private void ListBoxWireUp()
        {
            List<int> idZagadnien = GlobalConfig.Connection.PobierzIdZagadnien(GlobalData.LoggedUserId.ToString());

            zagadnieniaListBox.Items.Clear();
            zagadnieniaListBox.Items.AddRange(idZagadnien.Select(id => id.ToString()).ToArray());
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (opisValue.Text.Length < 4)
            {
                output = false;
            }

            if (czasValue.Text.Length == 0)
            {
                output = false;
            }

            float czas = 0;
            bool czasValid = float.TryParse(czasValue.Text, out czas);

            if (czasValid == false)
            {
                output = false;
            }

            if (czas <= 0 || czas >= 16)
            {
                output = false;
            }

            return output;
        }

        private void dodajLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DodajZagadnienieForm existingDodajZagadnienieForm = Application.OpenForms.OfType<DodajZagadnienieForm>().FirstOrDefault();

            if (existingDodajZagadnienieForm != null)
            {
                existingDodajZagadnienieForm.Activate();
            }
            else
            {
                DodajZagadnienieForm dodajZagadnienieForm = new DodajZagadnienieForm();
                dodajZagadnienieForm.Show();
            }
        }

        private void przydzielLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PrzydzielZagadnienieForm existingPrzydzielZagadnienieForm = Application.OpenForms.OfType<PrzydzielZagadnienieForm>().FirstOrDefault();

            if (existingPrzydzielZagadnienieForm != null)
            {
                existingPrzydzielZagadnienieForm.Activate();
            }
            else
            {
                PrzydzielZagadnienieForm przydzielZagadnienieForm = new PrzydzielZagadnienieForm();
                przydzielZagadnienieForm.Show();
            }
        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZadaniaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                zamknijButton.PerformClick();
            }
        }

        private void przyjmijButton_Click(object sender, EventArgs e)
        {
            if (zagadnieniaListBox.SelectedIndex != -1)
            {
                string selectedId = zagadnieniaListBox.SelectedItem.ToString();
                DateTime todayDate = DateTime.Now;

                if (ValidateForm())
                {
                    DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz dodać zadanie?", "Dodawanie zadania", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (dialogResult == DialogResult.Yes)
                    {
                        float czas;
                        if (!float.TryParse(czasValue.Text, out czas))                                              // Sprawdzenie poprawności konwersji czasu na float
                        {
                            MessageBox.Show("Niepoprawny format czasu.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;                                                                                 // Wychodzimy z metody, jeśli konwersja nie powiodła się
                        }

                        ZadaniaModel model = new ZadaniaModel(
                            opisValue.Text,
                            selectedId,
                            GlobalData.LoggedUserId.ToString(),
                            todayDate,
                            czas);

                        GlobalConfig.Connection.DodajZadanie(model);

                        opisValue.Text = "";
                        czasValue.Text = "";

                        MessageBox.Show("Poprawnie wpisano zadanie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Formularz posiada niepoprawne dane. Proszę poprawić je i spróbować ponownie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego zadania.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
