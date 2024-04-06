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
    }
}
