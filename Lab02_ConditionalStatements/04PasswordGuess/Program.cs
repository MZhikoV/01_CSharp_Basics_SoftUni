using System;
using System.Collections.Generic;
using System.Text;

namespace _04PasswordGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string passW=Console.ReadLine();

            if (passW == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
