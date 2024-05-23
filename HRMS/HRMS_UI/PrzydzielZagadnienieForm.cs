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
    public partial class PrzydzielZagadnienieForm : Form
    {
        public PrzydzielZagadnienieForm()
        {
            InitializeComponent();

            PopulateComboBoxes(); // Uzupełnia ComboBoxy w formularzu

            KeyPreview = true;
        }

        private void PopulateComboBoxes()
        {
            //Zagadnienia:
            numerZagadnieniaComboBox.Items.AddRange(GlobalConfig.Connection.PobierzWszystkieZagadnienia().ToArray());

            //id Pracowników
            idPracownikaComboBox.Items.AddRange(GlobalConfig.Connection.PobierzIdWszystkichPracownikow().ToArray());

            numerZagadnieniaComboBox.SelectedIndex = -1;
            idPracownikaComboBox.SelectedIndex = -1;
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (numerZagadnieniaComboBox.SelectedIndex == -1 || idPracownikaComboBox.SelectedIndex == -1)
            {
                output = false;
            }

            return output;
        }

        private void PrzydzielZagadnienieForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                przydzielButton.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                zamknijButton.PerformClick();
            }
        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void przydzielButton_Click(object sender, EventArgs e)
        {
            DateTime todayDate = DateTime.Now;

            if (numerZagadnieniaComboBox.SelectedIndex != -1 && idPracownikaComboBox.SelectedIndex != -1)
            {
                string selectedIdZagadnienia = numerZagadnieniaComboBox.SelectedItem.ToString();
                string selectedIdPracownika = idPracownikaComboBox.SelectedItem.ToString();

                string idZadania = GlobalConfig.Connection.SprawdzCzyPrzypisanoZagadnienie(selectedIdPracownika, selectedIdZagadnienia);

                if (!string.IsNullOrEmpty(idZadania))
                {
                    MessageBox.Show("Ten pracownik jest już przydzielony do tego zagadnienia.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    if (ValidateForm())
                    {
                        ZadaniaModel model = new ZadaniaModel(
                            $"Przydzielenie zagadnienia numer {numerZagadnieniaComboBox.Text}",
                            numerZagadnieniaComboBox.Text,
                            idPracownikaComboBox.Text,
                            todayDate,
                            0);

                        GlobalConfig.Connection.DodajZadanie(model);
                        numerZagadnieniaComboBox.SelectedIndex = -1;
                        idPracownikaComboBox.SelectedIndex = -1;

                        MessageBox.Show("Poprawnie przydzielono zagadnienie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego pracownika lub zagadnienia.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void numerZagadnieniaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numerZagadnieniaComboBox.SelectedIndex != -1)
            {
                string selectedTask = numerZagadnieniaComboBox.SelectedItem.ToString();
                string nazwaZagadnienia = GlobalConfig.Connection.PobierzNazweZagadnienia(selectedTask);

                nazwaZagadnieniaTextBox.Visible = true;
                nazwaZagadnieniaTextBox.Text = nazwaZagadnienia;
            }
        }
    }
}
