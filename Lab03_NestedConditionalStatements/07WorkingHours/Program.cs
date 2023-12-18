using System;
using System.Collections.Generic;
using System.Text;

namespace _07WorkingHours
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int hour=int.Parse(Console.ReadLine());
            string day=Console.ReadLine();

            if (day=="Sunday"||hour<10 || hour>18)
            {
                Console.WriteLine("closed");
            }
            else 
            {
                Console.WriteLine("open");
            }
        }
    }
}
