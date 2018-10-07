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
    class AccountDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["local"].ConnectionString;
        private static IDbConnection db = new SqlConnection(connectionString);

        public ObservableCollection<Account> GetAccounts()
        {
            string sql = "Select * from Account order by Id";
            return db.Query<Account>(sql).ToObservableCollection();
        }

        public ObservableCollection<Account> GetNonAdminAccounts()
        {
            string sql = "Select * from Account where type = 0 order by Id";
            return db.Query<Account>(sql).ToObservableCollection();
        }

        public Account GetAccount(string ingevuldeGebruikersNaam)
        {
            string sql = "Select * from Account where gebruikersNaam = @ingevuldeGebruikersNaam";
            var result = db.QuerySingleOrDefault<Account>(sql, new { ingevuldeGebruikersNaam });

            if (result == null)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public void InsertAccount(Account account)
        {
            string sql = "INSERT INTO Account (gebruikersNaam, paswoord, type) VALUES (@gebruikersNaam, @paswoord, @type)";

            db.Query(sql, account);
        }

        public void VerwijderAccount(Account account)
        {
            string sql = "Delete from Account where id = " + account.Id;

            db.Execute(sql);
        }

        public void ResetAccount(Account account)
        {
            string sql = "UPDATE Account SET paswoord = 123456 where id = " + account.Id;

            db.Execute(sql);
        }

        public void ChangePassword(Account account, string newPassword)
        {
            string sql = "UPDATE Account SET paswoord='" + newPassword + "' where id = " + account.Id;

            db.Execute(sql);
        }

        public void SetIngelogdAccount(Account account)
        {
            string sql = "UPDATE Account SET isIngelogd = 1 where gebruikersNaam = @gebruikersNaam";

            db.Query(sql, account);
        }

        public Account GetIngelogdAccount()
        {
            string sql = "Select * from Account where isIngelogd = 1";
            var result = db.QuerySingleOrDefault<Account>(sql);

            if (result == null)
            {
                return null;
            }
            else
            {
                return result;
            }
        }

        public void SetAllToFalse()
        {
            string sql = "UPDATE Account SET isIngelogd = 0";

            db.Query(sql);
        }
    }
}
