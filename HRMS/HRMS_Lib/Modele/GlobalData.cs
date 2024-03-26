using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS_Lib.Modele
{
    public class GlobalData
    {
        //dane zalogowanego uzytkownika
        public static int LoggedUserId { get; set; }
        public static int LoggedUserRole { get; set; }
        //dane uzytkownika, ktorego dane chce zmienic admin/moderator
        public static List<string> daneUzytkownikow { get; set; }
        public static string idUzytkownika { get; set; }
        public static List<string> daneUmowy { get; set; }
        public static List<string> daneLogowania { get; set; }

    }
}
