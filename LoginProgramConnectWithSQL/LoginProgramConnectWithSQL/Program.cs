using System;
using System.Collections.Generic;

namespace LoginProgramConnectWithSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.Init();
            /*
            Console.WriteLine("Enter in a username");
            string inputedUsername = Console.ReadLine();

            Console.WriteLine("Enter in a password");
            string inputedPassword = Console.ReadLine();

            Console.WriteLine(Database.IsValid(inputedUsername, inputedPassword));
            //accounts.Add(new Account(inputedUsername, inputedPassword));
            */

            Console.WriteLine("Enter in a first name");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter in a last name");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter in a username");
            string username = Console.ReadLine();

            Console.WriteLine("Enter in a password");
            string password = Console.ReadLine();

            Database.AddUser(firstName, lastName, username, password);

            ;
        }
    }
}
