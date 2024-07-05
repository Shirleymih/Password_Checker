using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Console.Write("Enter password again: ");
            string pass = Console.ReadLine();

            if (!password.Equals(string.Empty))
            {
                if (!pass.Equals(string.Empty))
                {
                    if (password.Length <= 30 && password.Length >= 6)
                    {

                        if (password.Equals(pass))
                        {
                            Console.WriteLine("Passwords match");
                        }
                        else
                        {
                            Console.WriteLine("Passwords do not match");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please, enter a password shorter than 31 characters and/or longer than 5");
                    }
                }
                else
                {
                    Console.WriteLine("Please, enter a matching password.");
                }
            }
            else
            {
                Console.WriteLine("Please, enter a password.");
            }
            Console.ReadLine();

        }
    }
}
