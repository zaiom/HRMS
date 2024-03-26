using HRMS_Lib.Modele;
using System;
using System.Collections.Generic;
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
        void UsunPracownika(string idPracownika, string idUmowy);
        //ModyfikujDanePracownika
        UmowyModel ModyfikujUmowe(UmowyModel model);
        PracownicyModel ModyfikujDanePracownika(PracownicyModel model);
        UzytkownicyModel ModyfikujDaneLogowania(UzytkownicyModel model);
    }
}
