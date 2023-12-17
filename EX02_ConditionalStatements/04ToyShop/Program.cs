using System;
using System.Collections.Generic;
using System.Text;

namespace _04ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double excPrice=double.Parse(Console.ReadLine());
            int puzzle=int.Parse(Console.ReadLine());
            int dolls=int.Parse(Console.ReadLine());
            int bears=int.Parse(Console.ReadLine());
            int minion=int.Parse(Console.ReadLine());
            int trucks=int.Parse(Console.ReadLine());

            double totPrice = puzzle * 2.60 + dolls * 3 + bears * 4.1 + minion * 8.2 + trucks * 2;

            int sumToys= puzzle  + dolls  + bears + minion + trucks;

            if (sumToys>=50)
            {
                totPrice *= 0.75;
            }

            totPrice *= 0.9;

            if (totPrice >= excPrice)
            {
                Console.WriteLine($"Yes! {totPrice - excPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(Math.Abs(totPrice - excPrice)):F2} lv needed.");
            }
        }
    }
}
