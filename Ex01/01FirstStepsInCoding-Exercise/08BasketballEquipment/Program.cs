using System;
using System.Collections.Generic;
using System.Text;

namespace _08BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearTax=int.Parse(Console.ReadLine());

            double shoes= 0.6 * yearTax;
            double shirt = 0.8 * shoes;
            double ball = 0.25 * shirt;
            double accessories = 0.2 * ball;

            double price = yearTax + shoes + shirt + accessories + ball;
            Console.WriteLine(price);
        }
    }
}
