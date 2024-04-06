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
        }

        private void WidocznoscElementow()
        {
            if (GlobalData.LoggedUserRole == 1 || GlobalData.LoggedUserRole == 2)
            {
                dodajButton.Visible = true;
            }
            else
            {
                dodajButton.Visible = false;
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
    }
}
