using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Medisch_dossier_programma.Extensions;

namespace Medisch_dossier_programma.Model
{
    class VaccinatieLijstDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        private static IDbConnection db = new SqlConnection(connectionString);

        public ObservableCollection<Vaccinatie> GetVaccinatieLijst()
        {
            string sql = "Select * from VaccinatieLijst order by id";
            return db.Query<Vaccinatie>(sql).ToObservableCollection();
        }

        public void InsertVaccinatieLijst(Vaccinatie vaccinatie)
        {
            string sql = "INSERT INTO VaccinatieLijst (Naam) VALUES (@Naam)";

            db.Query(sql, vaccinatie);
        }

        public void VerwijderVaccinatie(Vaccinatie vaccinatie)
        {
            string sql = "Delete from VaccinatieLijst where id = " + vaccinatie.Id;
            db.Execute(sql);
        }
    }
}
