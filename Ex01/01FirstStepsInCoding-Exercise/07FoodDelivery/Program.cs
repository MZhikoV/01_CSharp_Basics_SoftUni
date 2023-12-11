using System;
using System.Collections.Generic;
using System.Text;

namespace _07FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken=int.Parse(Console.ReadLine());
            int fish=int.Parse(Console.ReadLine());
            int veggan=int.Parse(Console.ReadLine());

            double price = chicken * 10.35 + fish * 12.4 + veggan * 8.15;
            price *= 1.2;
            price += 2.5;
            Console.WriteLine(price);
        }
    }
}
