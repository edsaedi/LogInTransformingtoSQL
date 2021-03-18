using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace LoginProgramConnectWithSQL
{
    public static class Database
    {
        private static List<Account> accounts;
        private static int count = 1;
        

        public static void Init()
        {
            string connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = "GMRMLTV",
                InitialCatalog = "EdanDB",
                UserID = "sa",
                Password = "GreatMinds110"
            }
            .ConnectionString;

            using var sqlConnection = new SqlConnection(connectionString);
            using var sqlCommand = new SqlCommand("SELECT * FROM Accounts", sqlConnection)
            {
                CommandType = System.Data.CommandType.Text
            };
            using var sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            var dataTable = new DataTable();

            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            ;

            accounts = new List<Account>()
            {
                new Account(1, "Bob", "Smith", "Bob", "1234"),
                new Account(2, "Fred", "Johns", "Fred", "password"),
                new Account(3, "Douglas", "Muir", "Douglas", "pass"),
                new Account(4, "Alex", "Leo", "Alex", "pass22"),
                new Account(5, "Joe", "White", "Joe", "updown"),
                new Account(6, "Theo", "Kayak", "Theo", "j35"),
                new Account(7, "Daniel", "Kim", "Daniel", "2253")
            };
        }

        public static void AddUser(string firstName, string lastName, string username, string password)
        {
            accounts.Add(new Account(count, firstName, lastName, username, password));
            count++;
        }

        public static bool ChangePassword(int id, string newPassword)
        {
            var desiredAccount = accounts.FirstOrDefault(account => account.ID == id);
            if (desiredAccount == null)
            {
                return false;
            }

            desiredAccount.ChangePassword(newPassword);
            return true;
        }


        public static bool ValidateAccount(string username, string password)
        {
            //var desiredAccount = accounts.FirstOrDefault(account => account.Username == username);
            //if (desiredAccount == null)
            //{
            //    return false;
            //}

            //if(!desiredAccount.ValidateAccount(username, password))
            //{
            //    return false;
            //}

            //desiredAccount.WelcomeMessage();
            //return true;

            string connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = "GMRMLTV",
                InitialCatalog = "EdanDB",
                UserID = "sa",
                Password = "GreatMinds110"
            }
           .ConnectionString;

            using var sqlConnection = new SqlConnection(connectionString);
            using var sqlCommand = new SqlCommand($"SELECT * FROM Accounts WHERE Username = '{username}' AND Password = '{password}'", sqlConnection)
            {
                CommandType = System.Data.CommandType.Text
            };
            using var sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            var dataTable = new DataTable();

            sqlConnection.Open();
            int rows = sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            if(rows == 0)
            {
                return false;
            }

            return true;
        }
    }
}
