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
        List<string> PobierzLoginy();
        string PobierzHaslo(string login);
        string HashPassword(string password);
        UzytkownicyModel DodajDaneLogowania(UzytkownicyModel model);

        
    }
}
