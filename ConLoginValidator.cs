using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibLoginValidator;

namespace ConLoginValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginValidator login = new LoginValidator();
            string check;
            int success = 0;

            while (success == 0)
            {
                Console.Write("Enter username: ");
                check = Console.ReadLine();

                if (check.Length != 0) { login.username = check; }
                else { login.username = null; }

                Console.Write("Enter password: ");
                check = Console.ReadLine();
                if (check.Length != 0) { login.password = check; }
                else { login.password = null; }

                bool? isAuthorized = login.Authorize();
                if (isAuthorized == null) { Console.Write("Please enter a username and password\n"); }
                else if (isAuthorized == false) { Console.Write("Authorization has failed\n"); }
                else 
                {
                    Console.Write("Authorization has been successful\n");
                    success = 1; 
                }
            }
            Console.ReadKey();
        }
    }
}