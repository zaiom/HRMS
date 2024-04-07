using HRMS_Lib.Modele;
using HRMS_Lib;
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
    public partial class DodajZagadnienieForm : Form
    {
        public DodajZagadnienieForm()
        {
            InitializeComponent();

            KeyPreview = true;
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (nazwaZagadnieniaValue.Text.Length == 0 || opisValue.Text.Length == 0)
            {
                output = false;
            }

            return output;
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ZagadnieniaModel model = new ZagadnieniaModel(
                    nazwaZagadnieniaValue.Text,
                    opisValue.Text,
                    deadlineDateTimePicker.Value);

                GlobalConfig.Connection.DodajZagadnienie(model);

                nazwaZagadnieniaValue.Text = "";
                opisValue.Text = "";
                deadlineDateTimePicker.Text = "";

                MessageBox.Show("Poprawnie zapisano zagadnienie. Nie zapomnij o przydzieleniu zagadnienia pracownikowi w oknie 'Przydziel'.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Formularz posiada niepoprawne dane. Proszę poprawić je i spróbować ponownie.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DodajZagadnienieForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dodajButton.PerformClick();
            }

            if (e.KeyCode == Keys.Escape)
            {
                zamknijButton.PerformClick();
            }
        }
    }
}
