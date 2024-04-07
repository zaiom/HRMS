using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_Lib.Modele
{
    public class ZadaniaModel
    {
        public int idZadania { get; set; }
        public string Opis { get; set; }
        public int idZagadnienia { get; set; }
        public int idPracownika { get; set; }
        public DateTime Dzien { get; set; }
        public float Czas { get; set; }

        public ZadaniaModel()
        {

        }

        public ZadaniaModel(string opis, string idzagadnienia, string idpracownika, DateTime dzien, float czas)
        {
            Opis = opis;

            int idZagadnieniaValue = 0;
            int.TryParse(idzagadnienia, out idZagadnieniaValue);
            idZagadnienia = idZagadnieniaValue;

            int idPracownikaValue = 0;
            int.TryParse(idpracownika, out idPracownikaValue);
            idPracownika = idPracownikaValue;

            Dzien = dzien;

            // w konstruktorze string czas
            //float czasValue = 0;
            //float.TryParse(czas, out czasValue);
            //Czas = czasValue;

            Czas = czas;
        }
    }
}
