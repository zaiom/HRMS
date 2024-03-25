using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_Lib.Modele
{
    public class PracownicyModel
    {
        public int idPracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTime dataUrodzenia { get; set; }
        public int Wydzial { get; set; }
        public int Stanowisko { get; set; }
        public int Przelozony { get; set; }
        public int umowaPracownika { get; set; }
        public string numerKontaktowy { get; set; }
        public string email { get; set; }
        public int Rola { get; set; }

        public PracownicyModel()
        {

        }

        public PracownicyModel(string imie, string nazwisko, DateTime data_urodzenia, string wydzial, string stanowisko, string przelozony, /*string umowa_pracownika,*/ string numer_kontaktowy, 
            string e_mail, string rola)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            dataUrodzenia = data_urodzenia;

            int wydzialValue = 0;
            int.TryParse(wydzial, out wydzialValue);
            Wydzial = wydzialValue;

            int stanowiskoValue = 0;
            int.TryParse(stanowisko, out stanowiskoValue);
            Stanowisko = stanowiskoValue;

            int przelozonyValue = 0;
            int.TryParse(przelozony, out przelozonyValue);
            Przelozony = przelozonyValue;

            //int umowaPracownikaValue = 0;
            //int.TryParse(umowa_pracownika, out umowaPracownikaValue);
            //umowaPracownika = umowaPracownikaValue;

            numerKontaktowy = numer_kontaktowy;
            email = e_mail;

            int rolaValue = 0;
            int.TryParse(rola, out rolaValue);
            Rola = rolaValue;

        }

        public PracownicyModel(string id_Pracownika, string imie, string nazwisko, DateTime data_urodzenia, string wydzial, string stanowisko, string przelozony, string umowa_pracownika, string numer_kontaktowy,
            string e_mail, string rola)
        {
            int idPracownikaValue = 0;
            int.TryParse(id_Pracownika, out idPracownikaValue);
            idPracownika = idPracownikaValue;

            Imie = imie;
            Nazwisko = nazwisko;
            dataUrodzenia = data_urodzenia;

            int wydzialValue = 0;
            int.TryParse(wydzial, out wydzialValue);
            Wydzial = wydzialValue;

            int stanowiskoValue = 0;
            int.TryParse(stanowisko, out stanowiskoValue);
            Stanowisko = stanowiskoValue;

            int przelozonyValue = 0;
            int.TryParse(przelozony, out przelozonyValue);
            Przelozony = przelozonyValue;

            int umowaPracownikaValue = 0;
            int.TryParse(umowa_pracownika, out umowaPracownikaValue);
            umowaPracownika = umowaPracownikaValue;

            numerKontaktowy = numer_kontaktowy;
            email = e_mail;

            int rolaValue = 0;
            int.TryParse(rola, out rolaValue);
            Rola = rolaValue;

        }

    }
}
