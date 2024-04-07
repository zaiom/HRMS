using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_Lib.Modele
{
    public class ZagadnieniaModel
    {
        public int idZagadnienia { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public DateTime Deadline { get; set; }

        public ZagadnieniaModel()
        {

        }

        public ZagadnieniaModel(string nazwa, string opis, DateTime deadline)
        {
            Nazwa = nazwa;
            Opis = opis;
            Deadline = deadline;
        }
    }
}
