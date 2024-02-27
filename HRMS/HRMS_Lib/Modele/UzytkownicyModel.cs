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
    }
}
