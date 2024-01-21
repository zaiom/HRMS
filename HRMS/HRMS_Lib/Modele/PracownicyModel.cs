using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_Lib.Modele
{
    public class PracownicyModel
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string dataUrodzenia { get; set; }
        public int Wydzial { get; set; }
        public int Stanowisko { get; set; }
        public int Przelozony { get; set; }
        public int umowaPracownika { get; set; }
        public string numerKontaktowy { get; set; }
        public string email { get; set; }
        public int Rola { get; set; }

    }
}
