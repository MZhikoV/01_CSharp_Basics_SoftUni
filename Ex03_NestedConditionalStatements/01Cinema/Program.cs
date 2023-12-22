using System;
using System.Collections.Generic;
using System.Text;

namespace _01Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type=Console.ReadLine();
            int column=int.Parse(Console.ReadLine());
            int rows=int.Parse(Console.ReadLine());

            double price = 0;
            int totalSeats=column*rows;

            if (type =="Premiere")
            {
                price = 12.00;
            }
            else if (type =="Normal")
            {
                price = 7.5;
            }
            else if (type =="Discount")
            {
                price = 5.0;
            }

            price *= totalSeats;
            Console.WriteLine($"{price:f2} leva");
        }
    }
}
