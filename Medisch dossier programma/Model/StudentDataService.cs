using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Collections.ObjectModel;
using System.Windows;
using Medisch_dossier_programma.Extensions;

namespace Medisch_dossier_programma.Model
{
    class StudentDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        private static IDbConnection db = new SqlConnection(connectionString);

        public ObservableCollection<Student> GetStudenten()
        {
            string sql = "Select * from Student order by Achternaam";
            return db.Query<Student>(sql).ToObservableCollection();
        }

        public Student GetStudent(string voornaam, string achternaam)
        {
            string sql = "Select TOP 1 * from Student where voornaam = @voornaam AND achternaam = @achternaam";
            return db.QuerySingleOrDefault<Student>(sql, new { voornaam, achternaam });
        }

        public void UpdateStudent(Student student)
        {
            string sql = "Update Student set voornaam = @voornaam, achternaam = @achternaam, klas = @klas, emailAdres = @emailAdres, telefoonNummer = @telefoonNummer, geslacht = @geslacht where id = @id";

            db.Execute(sql, new
            {
                voornaam = student.Voornaam,
                achternaam = student.Achternaam,
                klas = student.Klas,
                emailAdres = student.EmailAdres,
                telefoonNummer = student.TelefoonNummer,
                geslacht = student.Geslacht,
                id = student.Id
            });
            MessageBox.Show(student.Achternaam, student.Voornaam, MessageBoxButton.OK);
        }

        public void VerwijderStudent(Student student)
        {
            string sql = "Delete from Student where id = " + student.Id;
            db.Execute(sql);
        }

        public void InsertStudent(Student student)
        {
            string sql = "INSERT INTO Student (Achternaam, Voornaam, Geboortedatum, Geslacht, Klas, TelefoonNummer, emailAdres) VALUES (@Achternaam, @Voornaam, @GeboorteDatum, @Geslacht, @Klas, @TelefoonNummer, @emailAdres)";

            db.Query(sql, student);
        }
    }
}
