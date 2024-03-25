using HRMS_Lib.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Dapper;
using System.Security.Cryptography;

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
                p.Add("@DataZatrudnienia", model.DataZatrudnienia);
                p.Add("@DataKoncaUmowy", model.DataKoncaUmowy);
                p.Add("@idUmowy", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

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
                p.Add("@dataUrodzenia", model.dataUrodzenia);
                p.Add("@Wydzial", model.Wydzial);
                p.Add("@Stanowisko", model.Stanowisko);
                p.Add("@Przelozony", model.Przelozony);
                p.Add("@umowaPracownika", model.umowaPracownika);
                p.Add("@numerKontaktowy", model.numerKontaktowy);
                p.Add("@email", model.email);
                p.Add("@Rola", model.Rola);
                p.Add("@idPracownika", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPracownik_Dodaj", p, commandType: CommandType.StoredProcedure);

                model.idPracownika = p.Get<int>("@idPracownika");

                return model;
            }
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public List<string> PobierzLoginy()
        {
            List<string> loginy = new List<string>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                string query = "SELECT DISTINCT Login from Uzytkownicy;"; // Zapytanie SQL pobierające unikalne loginy

                loginy = connection.Query<string>(query).AsList();

                return loginy;
            }
        }

        public int PobierzId(string login)
        {
            int id = 0;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                string query = $"select idPracownika from Uzytkownicy where login='{login}';"; // Zapytanie SQL pobierające idPracownika o podanym loginie

                id = connection.QueryFirstOrDefault<int>(query);

                return id;
            }
        }

        public string PobierzHaslo(string login)
        {
            string haslo = "";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                string query = $"select haslo from Uzytkownicy where login='{login}';"; // Zapytanie SQL pobierające haslo o podanym loginie

                var result = connection.Query<string>(query).AsList();

                haslo = string.Join(",", result);

                return haslo;
            }
        }
        public UzytkownicyModel DodajDaneLogowania(UzytkownicyModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                // Pobierz ostatnie idPracownika z tabeli Pracownicy
                string query = "SELECT TOP 1 idPracownika FROM Pracownicy ORDER BY idPracownika DESC;";
                int pracownikId = connection.QueryFirstOrDefault<int>(query);

                model.idPracownika = pracownikId;
                //model.Haslo = "HASHBYTES('SHA2_256', '" + model.Haslo + "')";

                var p = new DynamicParameters();
                p.Add("@idPracownika", model.idPracownika);
                p.Add("@Login", model.Login);
                p.Add("@Haslo", HashPassword(model.Haslo));

                connection.Execute("dbo.spDaneLogowania_Dodaj", p, commandType: CommandType.StoredProcedure);

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

                //string query = "SELECT DISTINCT idWydzialu from Wydzial;"; // Zapytanie SQL pobierające unikalne id wydziałów
                //string query = "SELECT DISTINCT Nazwa FROM Wydzial;"; // Zapytanie SQL pobierające unikalne nazwy wydziałów
                string query = "SELECT Nazwa FROM Wydzial ORDER BY idWydzialu;";

                wydzialNames = connection.Query<string>(query).AsList();

                return wydzialNames;
            }
        }

        public List<string> PobierzNazweStanowiska()
        {
            List<string> stanowiskaIds = new List<string>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                //string query = "SELECT DISTINCT idStanowiska from Stanowisko;";
                //string query = "SELECT DISTINCT Nazwa FROM Stanowisko;";
                string query = "SELECT Nazwa FROM Stanowisko ORDER BY idStanowiska;";

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

        public List<string> PobierzNazweRoli()
        {
            List<string> rolaIds = new List<string>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                //string query = "SELECT DISTINCT idRoli from Rola;";
                //string query = "SELECT DISTINCT Nazwa FROM Rola;";
                string query = "SELECT Nazwa FROM Rola ORDER BY idRoli;";

                rolaIds = connection.Query<string>(query).AsList();

                return rolaIds;
            }
        }

        public int PobierzIdRoli(int idPracownika)
        {
            int id = 0;

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                string query = $"SELECT Rola.idRoli FROM Rola JOIN Pracownicy ON Rola.idRoli = Pracownicy.Rola JOIN Uzytkownicy ON Pracownicy.idPracownika = " +
                               $"Uzytkownicy.idPracownika WHERE Uzytkownicy.idPracownika = {idPracownika};";

                id = connection.QueryFirstOrDefault<int>(query);

                return id;
            }
        }

        public List<int> PobierzIdPracownikowZNizszaRola(string idRoli)
        {
            List<int> ids = new List<int>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                string query = $"SELECT idPracownika FROM Pracownicy where Rola > {idRoli}";

                ids = connection.Query<int>(query).AsList();

                return ids;
            }
        }

        public List<string> PobierzDanePracownika(string idPracownika)
        {
            List<string> danePracownika = new List<string>();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                //string query = $"SELECT Imie, Nazwisko, dataUrodzenia, Wydzial, Stanowisko, Przelozony, Rola, umowaPracownika, numerKontaktowy, email FROM Pracownicy WHERE idPracownika = {idPracownika};";
                string query = $"SELECT Imie, Nazwisko, CONVERT(varchar, dataUrodzenia, 104) as dataUrodzenia, Wydzial, Stanowisko, Przelozony, Rola, umowaPracownika, numerKontaktowy, email FROM Pracownicy WHERE idPracownika = {idPracownika};";

                var result = connection.QueryFirstOrDefault<dynamic>(query);

                if (result != null)
                {
                    danePracownika.Add(result.Imie);
                    danePracownika.Add(result.Nazwisko);
                    danePracownika.Add(result.dataUrodzenia);
                    danePracownika.Add(result.Wydzial.ToString());
                    danePracownika.Add(result.Stanowisko.ToString());
                    danePracownika.Add(result.Przelozony.ToString());
                    danePracownika.Add(result.Rola.ToString());
                    danePracownika.Add(result.umowaPracownika.ToString());
                    danePracownika.Add(result.numerKontaktowy);
                    danePracownika.Add(result.email);
                }

                return danePracownika;
            }
        }

        public void UsunPracownika(string idPracownika, string idUmowy)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                connection.Open();

                var p = new DynamicParameters();
                p.Add("@idPracownika", idPracownika);
                p.Add("@idUmowy", idUmowy);

                connection.Execute("dbo.spUsunPracownika", p, commandType: CommandType.StoredProcedure);
            }
        }

        public UmowyModel ModyfikujUmowe(UmowyModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                var p = new DynamicParameters();
                p.Add("@idUmowy", model.idUmowy);
                p.Add("@Rodzaj", model.Rodzaj);
                p.Add("@Pensja", model.Pensja);
                p.Add("@DataZatrudnienia", model.DataZatrudnienia);
                p.Add("@DataKoncaUmowy", model.DataKoncaUmowy);

                connection.Execute("dbo.spModyfikujUmowe", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }

        public PracownicyModel ModyfikujDanePracownika(PracownicyModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                var p = new DynamicParameters();
                p.Add("@idPracownika", model.idPracownika);
                p.Add("@Imie", model.Imie);
                p.Add("@Nazwisko", model.Nazwisko);
                p.Add("@dataUrodzenia", model.dataUrodzenia);
                p.Add("@Wydzial", model.Wydzial);
                p.Add("@Stanowisko", model.Stanowisko);
                p.Add("@Przelozony", model.Przelozony);
                p.Add("@umowaPracownika", model.umowaPracownika);
                p.Add("@numerKontaktowy", model.numerKontaktowy);
                p.Add("@email", model.email);
                p.Add("@Rola", model.Rola);

                connection.Execute("dbo.spModyfikujDanePracownika", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }

        public UzytkownicyModel ModyfikujDaneLogowania(UzytkownicyModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("HRMS_DB")))
            {
                var p = new DynamicParameters();
                p.Add("@idPracownika", model.idPracownika);
                p.Add("@Login", model.Login);
                p.Add("@Haslo", HashPassword(model.Haslo));

                connection.Execute("dbo.spModyfikujDaneLogowania", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }
    }
}
