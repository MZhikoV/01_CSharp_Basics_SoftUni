using System;
using System.Collections.Generic;
using System.Text;

namespace _06Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonReq=int.Parse(Console.ReadLine());
            int paint=int.Parse(Console.ReadLine());
            int razreditel=int.Parse(Console.ReadLine()); 
            int hours=int.Parse(Console.ReadLine());

            double price = (nylonReq + 2) * 1.5 + paint * 1.1 * 14.5 + razreditel * 5.0 + 0.4;
            price += price * 0.3 * hours;

            Console.WriteLine(price);
        }
    }
}
