using HRMS_Lib.Modele;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_Lib
{
    public interface IDataConnection
    {
        //Metody do DodajPracownikaForm
        List<string> PobierzNazweWydzialu();
        List<string> PobierzNazweStanowiska();
        List<string> PobierzIdPrzelozonego();
        List<string> PobierzNazweRoli();
        UmowyModel DodajUmowe(UmowyModel model);
        PracownicyModel DodajPracownika(PracownicyModel model);
        UzytkownicyModel DodajDaneLogowania(UzytkownicyModel model);
        //Logowanie
        List<string> PobierzLoginy();
        int PobierzId(string login);
        string PobierzHaslo(string login);
        string HashPassword(string password);
        int PobierzIdRoli(int idPracownika);
        //ZarzadzajForm -> ListBox
        List<int> PobierzIdPracownikowZNizszaRola(string idRoli);
        List<string> PobierzDanePracownika(string idPracownika);
        List<string> PobierzDaneUmowy(string idUmowy);
        List<string> PobierzDaneLogowania(string idPracownika);
        //ZarzadzajForm -> Buttony
        void UstawNULLidPracownika(string idPracownika);
        void UsunPracownika(string idPracownika, string idUmowy);
        //ModyfikujDanePracownika
        UmowyModel ModyfikujUmowe(UmowyModel model);
        PracownicyModel ModyfikujDanePracownika(PracownicyModel model);
        UzytkownicyModel ModyfikujDaneLogowania(UzytkownicyModel model);
        //ZadaniaForm -> ListBox
        List<int> PobierzIdZagadnien(string idPracownika);
        string PobierzNazweZagadnienia(string idZagadnienia);
        string PobierzOpisZagadnienia(string idZagadnienia);
        //ZadaniaForm -> Dodaj Zagadnienie
        ZagadnieniaModel DodajZagadnienie(ZagadnieniaModel model);
        //ZadaniaForm -> Przydziel zagadnienie
        List<string> PobierzWszystkieZagadnienia();
        List<string> PobierzIdWszystkichPracownikow();
        //ZadaniaForm -> Dodaj zadanie
        ZadaniaModel DodajZadanie(ZadaniaModel model);
        //ZadaniaForm -> Wyświetl zadania zalogowanego pracownika wybranego zagadnienia
        //List<string> PobierzDaneZagadnienia(string idPracownika, string idZagadnienia);
        List<ZadaniaModel> PobierzDaneZagadnienia(string idPracownika, string idZagadnienia);
        //Raporty
        string PobierzZagadnieniaThisMonth(string idPracownika);
        string PobierzZagadnieniaOverall(string idPracownika);
        string PobierzCzasThisMonth(string idPracownika);
        string PobierzCzasOverall(string idPracownika);
        string PobierzZadaniaThisMonth(string idPracownika);
        string PobierzZadaniaOverall(string idPracownika);
        string SprawdzCzyPrzypisanoZagadnienie(string idPracownika, string idZagadnienia);
    }
}
