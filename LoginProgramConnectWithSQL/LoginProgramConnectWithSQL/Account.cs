using System;
using System.Collections.Generic;
using System.Text;

namespace LoginProgramConnectWithSQL
{
    public class Account
    {
        public int ID { get; }

        public string Username { get; }
        string password;

        public Account(string username, string password, int id)
        {
            Username = username;
            this.password = password;

            ID = id;
        }

        public void ChangePassword(string newPassword)
            => password = newPassword;

        public bool ValidateAccount(string inputedUsername, string inputedPassword)
            => Username == inputedUsername && password == inputedPassword;
    }
}
