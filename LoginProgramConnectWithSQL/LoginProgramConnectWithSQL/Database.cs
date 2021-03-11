using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LoginProgramConnectWithSQL
{
    public static class Database
    {
        private static List<Account> accounts;
        private static int count = 1;

        public static void Init()
        {
            accounts = new List<Account>()
            {
                new Account("Bob", "1234", 1),
                new Account("Fred", "password", 2),
                new Account("Douglas", "pass", 3),
                new Account("Alex", "pass22", 4),
                new Account("Joe", "updown", 5),
                new Account("Theo", "j35", 6),
                new Account("Daniel", "2253", 7)
            };
        }

        public static void AddUser(string username, string password)
        {
            accounts.Add(new Account(username, password, count));
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
            var desiredAccount = accounts.FirstOrDefault(account => account.Username == username);
            if (desiredAccount == null)
            {
                return false;
            }

            return desiredAccount.ValidateAccount(username, password);
        }
    }
}
