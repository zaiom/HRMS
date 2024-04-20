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
        private string sciezkaPliku; //  zmienna przechowującą ścieżkę pliku

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
            dataLabel.Text = $"Data: {DateTime.Now.ToString("yyyy.MM.dd")}";

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
            //PdfWriter.GetInstance(document, new FileStream(sciezkaPliku, FileMode.Create));
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(sciezkaPliku, FileMode.Create));


            // Otwórz dokument do edycji
            document.Open();

            //Czcionka
            BaseFont rodzajCzcionki = BaseFont.CreateFont(@"c:\windows\fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
            // BaseFont rodzajCzcionki = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.NOT_EMBEDDED);

            //Czcionka tekstu
            //iTextSharp.text.Font czcionkaTekstu = new iTextSharp.text.Font(FontFactory.GetFont("Calibri", BaseFont.CP1250, BaseFont.NOT_EMBEDDED, 12));
            iTextSharp.text.Font czcionkaTekstu = new iTextSharp.text.Font(rodzajCzcionki, 12);

            //Pogrubienie nagłówka
            //iTextSharp.text.Font czcionkaNaglowka = new iTextSharp.text.Font(FontFactory.GetFont("Calibri", BaseFont.CP1250, BaseFont.NOT_EMBEDDED, 12, iTextSharp.text.Font.BOLD));
            iTextSharp.text.Font czcionkaNaglowka = new iTextSharp.text.Font(rodzajCzcionki, 12, iTextSharp.text.Font.BOLD);

            //Stopka
            iTextSharp.text.Font czcionkaStopka = new iTextSharp.text.Font(rodzajCzcionki, 10, iTextSharp.text.Font.ITALIC);

            // Dodaj nagłówek do dokumentu
            Paragraph naglowek = new Paragraph($"Raport pracowniczy z dnia {DateTime.Now.ToString("yyyy.MM.dd")}");
            naglowek.Alignment = Element.ALIGN_CENTER;
            document.Add(naglowek);

            Paragraph naglowekID = new Paragraph($"\nID pracownika: {GlobalData.LoggedUserId.ToString()}", czcionkaNaglowka);
            document.Add(naglowekID);

            Paragraph naglowekImieNazwisko = new Paragraph($"{danePracownika[0]} {danePracownika[1]}", czcionkaNaglowka);
            naglowekImieNazwisko.Alignment = Element.ALIGN_CENTER;
            document.Add(naglowekImieNazwisko);

            // Dodaj dane do dokumentu
            Paragraph tekst = new Paragraph($"Ilość zagadnień z bieżącego miesiąca: {GlobalConfig.Connection.PobierzZagadnieniaThisMonth(GlobalData.LoggedUserId.ToString())}\n" +
                                            $"Łączna ilość zagadnień*: {GlobalConfig.Connection.PobierzZagadnieniaOverall(GlobalData.LoggedUserId.ToString())}\n\n" +
                                            $"Przepracowany czas w bieżącym miesiącu: {GlobalConfig.Connection.PobierzCzasThisMonth(GlobalData.LoggedUserId.ToString())}h\n" +
                                            $"Łączny przepracowany czas*: {GlobalConfig.Connection.PobierzCzasOverall(GlobalData.LoggedUserId.ToString())}h\n\n" +
                                            $"Ilość zadań z bieżącego miesiąca: {GlobalConfig.Connection.PobierzZadaniaThisMonth(GlobalData.LoggedUserId.ToString())}\n" +
                                            $"Łączna ilość zadań*: {GlobalConfig.Connection.PobierzZadaniaOverall(GlobalData.LoggedUserId.ToString())}", czcionkaTekstu);
            document.Add(tekst);

            Paragraph stopka = new Paragraph($"\n\n*od momentu zatrudnienia", czcionkaStopka);
            //stopka.Alignment = Element.ALIGN_BOTTOM;

            document.Add(stopka);


            // Zamknij dokument
            document.Close();
        }

        private void generujRaportButton_Click(object sender, EventArgs e)
        {
            List<string> danePracownika = GlobalConfig.Connection.PobierzDanePracownika(GlobalData.LoggedUserId.ToString());

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Wybierz miejsce zapisu raportu PDF";
            saveFileDialog.FileName = $"Raport{danePracownika[0]}{danePracownika[1]}{DateTime.Now.ToString("yyyy-MM-dd")}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sciezkaPliku = saveFileDialog.FileName;
                //id pracownika
                idPracownikaLabel.Text = $"ID pracownika: {GlobalData.LoggedUserId.ToString()}";

                //imie i nazwisko
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
                var sciezkaFolderu = Path.GetDirectoryName(sciezkaPliku);

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
