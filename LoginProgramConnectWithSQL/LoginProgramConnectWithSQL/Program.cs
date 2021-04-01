using System;
using System.Collections.Generic;

namespace LoginProgramConnectWithSQL
{
    class Program
    {
        static void Main(string[] args)
        {
            //Database.Init();

            Console.WriteLine("Enter in a username");
            string inputedUsername = Console.ReadLine();

            Console.WriteLine("Enter in a password");
            string inputedPassword = Console.ReadLine();

            Console.WriteLine(Database.IsValid(inputedUsername, inputedPassword));
            //accounts.Add(new Account(inputedUsername, inputedPassword));
            
            ;
        }
    }
}
