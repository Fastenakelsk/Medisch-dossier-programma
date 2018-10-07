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
    class VaccinatieDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        private static IDbConnection db = new SqlConnection(connectionString);

        public Vaccinatie getVaccinatieByNameAndStudentID(string naam, int studentID)
        {
            string sql = "Select TOP 1 * from Vaccinatie where studentID = @studentID AND naam = @naam";
            return db.QuerySingleOrDefault<Vaccinatie>(sql, new {naam, studentID });
        }

        public ObservableCollection<Vaccinatie> GetVaccinatiesByStudentID(int studentID)
        {
            string sql = "Select * from Vaccinatie where studentID = @studentID order by naam";
            return db.Query<Vaccinatie>(sql, new { studentID }).ToObservableCollection();
        }

        public void VerwijderVaccinatie(Vaccinatie vaccinatie)
        {
            string sql = "Delete from Vaccinatie where id = " + vaccinatie.Id;
            db.Execute(sql);
        }

        public void UpdateVaccinatie(Vaccinatie vaccinatie)
        {
            string sql = "Update Vaccinatie set naam = @naam, isVerplicht = @isVerplicht, gekregenDatum = @gekregenDatum where id = @id";

            db.Execute(sql, new
            {
                naam = vaccinatie.Naam,
                isVerplicht = vaccinatie.IsVerplicht,
                gekregenDatum = vaccinatie.GekregenDatum,
                id = vaccinatie.Id
            });
        }

        public void InsertVaccinatie(Vaccinatie vaccinatie)
        {
            string sql = "INSERT INTO Vaccinatie (Naam, IsVerplicht, GekregenDatum, studentID) VALUES (@Naam, @IsVerplicht, @GekregenDatum, @StudentID)";

            db.Query(sql, vaccinatie);
        }
    }
}
