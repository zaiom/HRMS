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
    public partial class ZarzadzajForm : Form
    {
        public ZarzadzajForm()
        {
            InitializeComponent();

            ListBoxWireUp();
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
    }
}
