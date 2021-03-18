using System;
using System.Collections.Generic;
using System.Text;

namespace LoginProgramConnectWithSQL
{
    public class Account
    {
        public int ID { get; }

        string firstName;
        string lastName;

        public string Username { get; }
        string password;

        public Account(int id, string firstName, string lastName, string username, string password)
        {
            ID = id;

            this.firstName = firstName;
            this.lastName = lastName;

            Username = username;
            this.password = password;
        }

        public void ChangePassword(string newPassword)
            => password = newPassword;

        public bool ValidateAccount(string inputedUsername, string inputedPassword)
            => Username == inputedUsername && password == inputedPassword;

        public void WelcomeMessage()
            => Console.WriteLine($"Thank you for logging in. Welcome {firstName} {lastName}.");
    }
}
