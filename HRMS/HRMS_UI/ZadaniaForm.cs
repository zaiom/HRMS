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

        private void zagadnieniaListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (zagadnieniaListBox.SelectedIndex != -1)
            {
                string selectedTask = zagadnieniaListBox.SelectedItem.ToString();
                string nazwaZagadnienia = GlobalConfig.Connection.PobierzNazweZagadnienia(selectedTask);
                string opisZagadnienia = GlobalConfig.Connection.PobierzOpisZagadnienia(selectedTask);

                nazwaZagadnieniaTextBox.Visible = true;
                opisZagadnieniaTextBox.Visible = true;

                nazwaZagadnieniaTextBox.Text = nazwaZagadnienia;
                opisZagadnieniaTextBox.Text = opisZagadnienia;
            }
        }

        private void ListBoxWireUp()
        {
            List<int> idZagadnien = GlobalConfig.Connection.PobierzIdZagadnien(GlobalData.LoggedUserId.ToString());

            zagadnieniaListBox.Items.Clear();
            zagadnieniaListBox.Items.AddRange(idZagadnien.Select(id => id.ToString()).ToArray());
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
    }
}
