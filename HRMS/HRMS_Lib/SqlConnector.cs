using HRMS_Lib.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;


namespace HRMS_Lib
{
    public class SqlConnector : IDataConnection
    {
        public UmowyModel DodajUmowe(UmowyModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                var p = new DynamicParameters();
                p.Add("@Rodzaj", model.Rodzaj);
                p.Add("@Pensja", model.Pensja);
                p.Add("DataZatrudnienia", model.DataZatrudnienia);
                p.Add("DataKoncaUmowy", model.DataKoncaUmowy);
                p.Add("idUmowy", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUmowy_Dodaj", p, commandType: CommandType.StoredProcedure);

                model.idUmowy = p.Get<int>("@idUmowy");

                return model;


            }
        }
    }
}
