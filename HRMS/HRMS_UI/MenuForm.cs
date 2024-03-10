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
            idPracownikaToolStripMenuItem.Text = GlobalData.LoggedUserId.ToString();                            // powoduje, ze w menuform w lewym gornym rogu wyswietla sie id aktualnie zalogowanego
                                                                                                                // pracownika
        }

        private void uprawnieniaButton_Click(object sender, EventArgs e)
        {
            // Sprawdź, czy formularz UprawnieniaForm jest już otwarty
            UprawnieniaForm existingUprawnieniaForm = Application.OpenForms.OfType<UprawnieniaForm>().FirstOrDefault();

            if (existingUprawnieniaForm != null)
            {
                // Jeśli formularz już istnieje, aktywuj go
                existingUprawnieniaForm.Activate();
            }
            else
            {
                // Jeśli formularz nie istnieje, utwórz nowy
                UprawnieniaForm uprawnieniaForm = new UprawnieniaForm();
                uprawnieniaForm.Show();
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
            LogowanieForm logowanieForm = new LogowanieForm();
            logowanieForm.Show();
            this.Close();
        }
    }
}
