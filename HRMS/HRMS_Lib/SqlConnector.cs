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

        public PracownicyModel DodajPracownika(PracownicyModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                // Pobierz ostatnie idUmowy z tabeli Umowy
                string query = "SELECT TOP 1 idUmowy FROM Umowy ORDER BY idUmowy DESC;";
                int umowaPracownikaId = connection.QueryFirstOrDefault<int>(query);

                model.umowaPracownika = umowaPracownikaId;

                var p = new DynamicParameters();
                p.Add("@Imie", model.Imie);
                p.Add("@Nazwisko", model.Nazwisko);
                p.Add("dataUrodzenia", model.dataUrodzenia);
                p.Add("Wydzial", model.Wydzial);
                p.Add("Stanowisko", model.Stanowisko);
                p.Add("Przelozony", model.Przelozony);
                p.Add("umowaPracownika", model.umowaPracownika);
                p.Add("numerKontaktowy", model.numerKontaktowy);
                p.Add("email", model.email);
                p.Add("Rola", model.Rola);
                p.Add("idPracownika", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPracownik_Dodaj", p, commandType: CommandType.StoredProcedure);

                model.idPracownika = p.Get<int>("@idPracownika");

                return model;
            }
        }


        public List<string> PobierzNazweWydzialu()
        {
            List<string> wydzialNames = new List<string>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                string query = "SELECT DISTINCT idWydzialu from Wydzial;"; // Zapytanie SQL pobierające unikalne id wydziałów
                //string query = "SELECT DISTINCT Nazwa FROM Wydzial;"; // Zapytanie SQL pobierające unikalne nazwy wydziałów

                wydzialNames = connection.Query<string>(query).AsList();

                return wydzialNames;
            }
        }

        public List<string> PobierzIdStanowiska()
        {
            List<string> stanowiskaIds = new List<string>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                string query = "SELECT DISTINCT idStanowiska from Stanowisko;";

                stanowiskaIds = connection.Query<string>(query).AsList();

                return stanowiskaIds;
            }
        }


        public List<string> PobierzIdPrzelozonego()
        {
            List<string> przelozonyIds = new List<string>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                string query = "SELECT idPracownika FROM Pracownicy WHERE Stanowisko=1 OR Stanowisko=3;";

                przelozonyIds = connection.Query<string>(query).AsList();

                return przelozonyIds;
            }
        }

        public List<string> PobierzIdRoli()
        {
            List<string> rolaIds = new List<string>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                string query = "SELECT DISTINCT idRoli from Rola;";

                rolaIds = connection.Query<string>(query).AsList();

                return rolaIds;
            }
        }
    }
}
