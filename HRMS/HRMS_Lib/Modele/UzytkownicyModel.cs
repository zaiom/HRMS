using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_Lib.Modele
{
    public class UzytkownicyModel
    {
        public int idPracownika { get; set; }
        public string Login { get; set; }
        public string Haslo { get; set; }

        public UzytkownicyModel()
        {

        }

        public UzytkownicyModel(string login, string haslo)
        {
            Login = login;
            Haslo = haslo;
        }

        public UzytkownicyModel(string id_Pracownika, string login, string haslo)
        {
            int idPracownikaValue = 0;
            int.TryParse(id_Pracownika, out idPracownikaValue);
            idPracownika = idPracownikaValue;

            Login = login;
            Haslo = haslo;
        }
    }
}
