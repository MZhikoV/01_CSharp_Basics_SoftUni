using System;
using System.Collections.Generic;
using System.Text;

namespace _04FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget=int.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            int fishermenCount=int.Parse(Console.ReadLine());

            double totalCosts = 0, discount = 1, price = 0;

            if (season=="Spring")
            {
                price = 3000;
            }
            else if (season== "Winter")
            {
                price = 2600;
            }
            else
            {
                price = 4200;
            }

            if (fishermenCount<= 6) 
            {
                discount = 0.9;
            }
            else if (fishermenCount<= 11) 
            {
                discount = 0.85;
            }
            else
            {
                discount = 0.75;
            }

            totalCosts = price * discount;

            if (fishermenCount%2==0 && season!="Autumn")
            {
                totalCosts *= 0.95;
            }

            if (totalCosts<=budget)
            {
                Console.WriteLine($"Yes! You have {(Math.Abs(totalCosts - budget)):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(Math.Abs(totalCosts - budget)):f2} leva.");
            }
        }
    }
}
