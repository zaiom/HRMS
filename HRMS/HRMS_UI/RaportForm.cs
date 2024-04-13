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
    public partial class RaportForm : Form
    {
        public RaportForm()
        {
            InitializeComponent();

            UzupelnijNapisy();

            KeyPreview = true;
        }

        private void UzupelnijNapisy()
        {
            //id pracownika
            idPracownikaLabel.Text = $"ID pracownika: {GlobalData.LoggedUserId.ToString()}";

            //imie i nazwisko
            List<string> danePracownika = GlobalConfig.Connection.PobierzDanePracownika(GlobalData.LoggedUserId.ToString());
            imieNazwiskoLabel.Text = $"{danePracownika[0]} {danePracownika[1]}";

            thisMonthZagadnieniaValue.Text = GlobalConfig.Connection.PobierzZagadnieniaThisMonth(GlobalData.LoggedUserId.ToString());
            overallZagadnieniaValue.Text = GlobalConfig.Connection.PobierzZagadnieniaOverall(GlobalData.LoggedUserId.ToString());

            thisMonthTimeValue.Text = GlobalConfig.Connection.PobierzCzasThisMonth(GlobalData.LoggedUserId.ToString());
            overallTimeValue.Text = GlobalConfig.Connection.PobierzCzasOverall(GlobalData.LoggedUserId.ToString());

            thisMonthZadaniaValue.Text = GlobalConfig.Connection.PobierzZadaniaThisMonth(GlobalData.LoggedUserId.ToString());
            overallZadaniaValue.Text = GlobalConfig.Connection.PobierzZadaniaOverall(GlobalData.LoggedUserId.ToString());


            DateTime todayDate = DateTime.Now;
        }

        private void RaportForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                zamknijButton.PerformClick();
            }
        }

        private void generujRaportBurron_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz wygenerować raport PDF?", "Generuj raport", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {


                MessageBox.Show($"Wygenerowano raport w sciezka", "Wygenerowano raport", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
