using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_Lib.Modele
{
    public class UmowyModel
    {
        public int idUmowy { get; set; }
        public string Rodzaj { get; set; }
        public decimal Pensja { get; set; }
        public DateTime DataZatrudnienia { get; set; }
        public DateTime DataKoncaUmowy { get; set; }

        public UmowyModel()
        {

        }

        // do dodawania umowy do bazy
        public UmowyModel(string rodzaj, string pensja, DateTime dataZatrudnienia, DateTime dataKoncaUmowy)
        {
            Rodzaj = rodzaj;

            decimal pensjaValue = 0;
            decimal.TryParse(pensja, out pensjaValue);
            Pensja = pensjaValue;

            DataZatrudnienia = dataZatrudnienia;
            DataKoncaUmowy = dataKoncaUmowy;
        }

        //do modyfikacji umowy w bazie
        public UmowyModel(string id_Umowy, string rodzaj, string pensja, DateTime dataZatrudnienia, DateTime dataKoncaUmowy)
        {
            int idUmowyValue = 0;
            int.TryParse(id_Umowy, out idUmowyValue);
            idUmowy = idUmowyValue;

            Rodzaj = rodzaj;

            decimal pensjaValue = 0;
            decimal.TryParse(pensja, out pensjaValue);
            Pensja = pensjaValue;

            DataZatrudnienia = dataZatrudnienia;
            DataKoncaUmowy = dataKoncaUmowy;
        }
    }
}
