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
    public partial class MenuForm : Form
    {
        //private int loggedUserRole = GlobalData.LoggedUserRole;
        public MenuForm()
        {
            InitializeComponent();
            idPracownikaToolStripMenuItem.Text = $"Jesteś zalogowany jako: {GlobalData.LoggedUserId.ToString()}";               // powoduje, ze w menuform w lewym gornym
                                                                                                                                // rogu wyswietla sie id aktualnie
                                                                                                                                // zalogowanego pracownika
            KeyPreview = true;
        }

        private void raportButton_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy formularz UprawnieniaForm jest już otwarty
            RaportForm existingRaportForm = Application.OpenForms.OfType<RaportForm>().FirstOrDefault();

            if (existingRaportForm != null)
            {
                // Jeśli formularz już istnieje, aktywuj go
                existingRaportForm.Activate();
            }
            else
            {
                // Jeśli formularz nie istnieje, utwórz nowy
                RaportForm RaportForm = new RaportForm();
                RaportForm.Show();
            }
        }

        private void zadaniaButton_Click(object sender, EventArgs e)
        {
            ZadaniaForm existingZadaniaForm = Application.OpenForms.OfType<ZadaniaForm>().FirstOrDefault();

            if (existingZadaniaForm != null)
            {
                existingZadaniaForm.Activate();
            }
            else
            {
                ZadaniaForm zadaniaForm = new ZadaniaForm();
                zadaniaForm.Show();
            }
        }

        private void zarzadzajButton_Click(object sender, EventArgs e)
        {
            ZarzadzajForm existingZarzadzajForm = Application.OpenForms.OfType<ZarzadzajForm>().FirstOrDefault();
            DodajPracownikaForm existingDodajPracownikaForm = Application.OpenForms.OfType<DodajPracownikaForm>().FirstOrDefault();

            if (existingDodajPracownikaForm != null)
            {
                MessageBox.Show("Zamknij okno Dodaj Pracownika, żeby przejść do Zarządzaj.", "Błąd!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (GlobalData.LoggedUserRole == 1 || GlobalData.LoggedUserRole == 2)
            {
                if (existingZarzadzajForm != null)
                {
                    existingZarzadzajForm.Activate();
                }
                else
                {
                    ZarzadzajForm zarzadzajForm = new ZarzadzajForm();
                    zarzadzajForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Nie posiadasz odpowiednich uprawnień, żeby skorzystać z tej usługi. Skontaktuj się z Administratorem, żeby nadał Ci wyższą rolę w systemie.",
                                "Błąd uprawnień", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void wylogujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GlobalData.LoggedUserId = 0;
            GlobalData.LoggedUserRole = 0;
            GlobalData.daneUzytkownika = new List<string>();
            GlobalData.idUzytkownika = "";
            GlobalData.daneUmowy = new List<string>();
            GlobalData.daneLogowania = new List<string>();

            LogowanieForm logowanieForm = new LogowanieForm();
            logowanieForm.Show();
            this.Close();
        }
    }
}
