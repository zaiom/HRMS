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
        PracownicyModel DodajPracownika(PracownicyModel model);
    }
}
