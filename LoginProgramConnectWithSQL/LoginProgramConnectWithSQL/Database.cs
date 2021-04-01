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


        private static DataTable CallProc(string storedPorcedure, List<SqlParameter> parameters)
        {
            string connectionString = new SqlConnectionStringBuilder()
            {
                DataSource = "GMRMLTV",
                InitialCatalog = "EdanDB",
                UserID = "EdanAppUser",
                Password = "5?2-4%n!y5Mr/`JG"
            }
           .ConnectionString;

            using var sqlConnection = new SqlConnection(connectionString);

            using var sqlCommand = new SqlCommand($"usp_LoginAccount", sqlConnection)
            {
                CommandType = System.Data.CommandType.StoredProcedure
            };
            using var sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            for (int i = 0; i < parameters.Count; i++)
            {
                sqlCommand.Parameters.Insert(i, parameters[i]);
            }

            var dataTable = new DataTable();

            sqlConnection.Open();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();

            return dataTable;
        }

        public static bool IsValid(string username, string password)
            => CallProc("usp_LoginUser",
                        new List<SqlParameter>{
                        new SqlParameter("@Username", username),
                        new SqlParameter("@Password", password)})
               .Rows.Count == 1;

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

        
        //public static bool ValidateAccount(string username, string password)
        //{
        //    //var desiredAccount = accounts.FirstOrDefault(account => account.Username == username);
        //    //if (desiredAccount == null)
        //    //{
        //    //    return false;
        //    //}

        //    //if(!desiredAccount.ValidateAccount(username, password))
        //    //{
        //    //    return false;
        //    //}

        //    //desiredAccount.WelcomeMessage();
        //    //return true;
        //    string connectionString = new SqlConnectionStringBuilder()
        //    {
        //        DataSource = "GMRMLTV",
        //        InitialCatalog = "EdanDB",
        //        UserID = "EdanAppUser",
        //        Password = "5?2-4%n!y5Mr/`JG"
        //    }
        //   .ConnectionString;

        //    using var sqlConnection = new SqlConnection(connectionString);

        //    using var sqlCommand = new SqlCommand($"usp_LoginAccount", sqlConnection)
        //    {
        //        CommandType = System.Data.CommandType.StoredProcedure
        //    };
        //    using var sqlDataAdapter = new SqlDataAdapter(sqlCommand);

        //    sqlCommand.Parameters.AddWithValue("@Username", username);
        //    sqlCommand.Parameters.AddWithValue("@Password", password);

        //    var dataTable = new DataTable();

        //    sqlConnection.Open();
        //    int rows = sqlDataAdapter.Fill(dataTable);
        //    sqlConnection.Close();

        //    if (rows == 0)
        //    {
        //        return false;
        //    }

        //    return true;
        //}
    }
}
