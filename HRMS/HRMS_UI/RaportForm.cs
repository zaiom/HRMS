using HRMS_Lib;
using HRMS_Lib.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;

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

            //zagadnienia z tego miesiąca i łącznie
            thisMonthZagadnieniaValue.Text = GlobalConfig.Connection.PobierzZagadnieniaThisMonth(GlobalData.LoggedUserId.ToString());
            overallZagadnieniaValue.Text = GlobalConfig.Connection.PobierzZagadnieniaOverall(GlobalData.LoggedUserId.ToString());

            //czas z tego miesiąca i łącznie
            thisMonthTimeValue.Text = GlobalConfig.Connection.PobierzCzasThisMonth(GlobalData.LoggedUserId.ToString());
            overallTimeValue.Text = GlobalConfig.Connection.PobierzCzasOverall(GlobalData.LoggedUserId.ToString());

            //zadania z tego miesiąca i łącznie
            thisMonthZadaniaValue.Text = GlobalConfig.Connection.PobierzZadaniaThisMonth(GlobalData.LoggedUserId.ToString());
            overallZadaniaValue.Text = GlobalConfig.Connection.PobierzZadaniaOverall(GlobalData.LoggedUserId.ToString());
        }

        private void RaportForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                zamknijButton.PerformClick();
            }
        }
        public void GenerujRaportPDF(string sciezkaPliku, List<string> danePracownika)
        {
            // Utwórz nowy dokument PDF
            iTextSharp.text.Document document = new iTextSharp.text.Document();

            // Inicjalizacja obiektu PdfWriter
            PdfWriter.GetInstance(document, new FileStream(sciezkaPliku, FileMode.Create));
            //PdfWriter.GetInstance(document, new FileStream(sciezkaPliku, FileMode.Create, FileAccess.Write), PdfWriter.VERSION_1_7).SetFullCompression();

            // Otwórz dokument do edycji
            document.Open();

            //Czcionka
            BaseFont rodzajCzcionki = BaseFont.CreateFont(@"c:\windows\fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
           // BaseFont rodzajCzcionki = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);

            //Czciionka tekstu
            //iTextSharp.text.Font czcionkaTekstu = new iTextSharp.text.Font(FontFactory.GetFont("Calibri", BaseFont.CP1250, BaseFont.NOT_EMBEDDED, 12));
            iTextSharp.text.Font czcionkaTekstu = new iTextSharp.text.Font(rodzajCzcionki, 12);

            //Pogrubienie nagłówka
            //iTextSharp.text.Font czcionkaNaglowka = new iTextSharp.text.Font(FontFactory.GetFont("Calibri", BaseFont.CP1250, BaseFont.NOT_EMBEDDED, 12, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Font czcionkaNaglowka = new iTextSharp.text.Font(rodzajCzcionki, 12, iTextSharp.text.Font.BOLD);

            // Dodaj nagłówek do dokumentu
            Paragraph naglowek = new Paragraph($"Raport pracowniczy");
            naglowek.Alignment = Element.ALIGN_CENTER;
            document.Add(naglowek);

            Paragraph naglowekID = new Paragraph($"\nID pracownika: {GlobalData.LoggedUserId.ToString()}", czcionkaNaglowka);
            document.Add(naglowekID);

            Paragraph naglowekImieNazwisko = new Paragraph($"{danePracownika[0]} {danePracownika[1]}", czcionkaNaglowka);
            naglowekImieNazwisko.Alignment = Element.ALIGN_CENTER;
            document.Add(naglowekImieNazwisko);

            // Dodaj dane do dokumentu
            Paragraph tekst = new Paragraph($"Ilość zagadnień z bieżącego miesiąca: {GlobalConfig.Connection.PobierzZagadnieniaThisMonth(GlobalData.LoggedUserId.ToString())}\n" +
                                            $"Łączna ilość zagadnień: {GlobalConfig.Connection.PobierzZagadnieniaOverall(GlobalData.LoggedUserId.ToString())}\n\n" +
                                            $"Przepracowany czas w bieżącym miesiącu: {GlobalConfig.Connection.PobierzCzasThisMonth(GlobalData.LoggedUserId.ToString())}\n" +
                                            $"Łączny przepracowany czas: {GlobalConfig.Connection.PobierzCzasOverall(GlobalData.LoggedUserId.ToString())}\n\n" +
                                            $"Ilość zadań z bieżącego miesiąca: {GlobalConfig.Connection.PobierzZadaniaThisMonth(GlobalData.LoggedUserId.ToString())}\n" +
                                            $"Łączna ilość zadań: {GlobalConfig.Connection.PobierzZadaniaOverall(GlobalData.LoggedUserId.ToString())}", czcionkaTekstu);
            document.Add(tekst);


            // Zamknij dokument
            document.Close();
        }

        private void generujRaportBurron_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz wygenerować raport PDF?", "Generuj raport", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                //id pracownika
                idPracownikaLabel.Text = $"ID pracownika: {GlobalData.LoggedUserId.ToString()}";

                //imie i nazwisko
                List<string> danePracownika = GlobalConfig.Connection.PobierzDanePracownika(GlobalData.LoggedUserId.ToString());
                imieNazwiskoLabel.Text = $"{danePracownika[0]} {danePracownika[1]}";

                //zagadnienia z tego miesiąca i łącznie
                thisMonthZagadnieniaValue.Text = GlobalConfig.Connection.PobierzZagadnieniaThisMonth(GlobalData.LoggedUserId.ToString());
                overallZagadnieniaValue.Text = GlobalConfig.Connection.PobierzZagadnieniaOverall(GlobalData.LoggedUserId.ToString());

                //czas z tego miesiąca i łącznie
                thisMonthTimeValue.Text = GlobalConfig.Connection.PobierzCzasThisMonth(GlobalData.LoggedUserId.ToString());
                overallTimeValue.Text = GlobalConfig.Connection.PobierzCzasOverall(GlobalData.LoggedUserId.ToString());

                //zadania z tego miesiąca i łącznie
                thisMonthZadaniaValue.Text = GlobalConfig.Connection.PobierzZadaniaThisMonth(GlobalData.LoggedUserId.ToString());
                overallZadaniaValue.Text = GlobalConfig.Connection.PobierzZadaniaOverall(GlobalData.LoggedUserId.ToString());


                //Utworz nieistniejąca ściezke
                var sciezkaFolderu = "C:\\HRMS\\Raporty\\";
                var nazwaPliku = $"Raport{danePracownika[0]}{danePracownika[1]}.pdf";
                var sciezkaPliku = Path.Combine(sciezkaFolderu, nazwaPliku);

                if (!Directory.Exists(sciezkaFolderu))
                {
                    Directory.CreateDirectory(sciezkaFolderu);
                }

                // Utwórz nowy dokument PDF
                GenerujRaportPDF(sciezkaPliku, danePracownika);

                MessageBox.Show($"Wygenerowano raport w folderze {sciezkaFolderu}", "Wygenerowano raport", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
