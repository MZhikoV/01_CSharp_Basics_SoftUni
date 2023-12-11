using System;
using System.Collections.Generic;
using System.Text;

namespace _05SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens=int.Parse(Console.ReadLine());
            int marker=int.Parse(Console.ReadLine());
            int detergentLiters=int.Parse(Console.ReadLine());
            int discount=int.Parse(Console.ReadLine());

            double price = pens * 5.8 + marker * 7.2 + detergentLiters * 1.2;
            double totalPrice = price * (1 -1.0* discount / 100);

            Console.WriteLine(totalPrice);
        }
    }
}
