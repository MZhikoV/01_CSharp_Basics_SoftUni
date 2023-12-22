using System;
using System.Collections.Generic;
using System.Text;

namespace _03NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType=Console.ReadLine();
            int flowerCount=int.Parse(Console.ReadLine());
            int budget=int.Parse(Console.ReadLine());

            double totalCosts = 0, price = 0, discount=1;

            if (flowerType == "Roses")
            {
                price = 5.0;

                if (flowerCount > 80) 
                {
                    discount = 0.9;
                }
            }
            else if (flowerType == "Dahlias")
            {
                price = 3.8;

                if (flowerCount > 90)
                {
                    discount = 0.85;
                }
            }
            else if (flowerType == "Tulips")
            {
                price = 2.8;

                if (flowerCount > 80)
                {
                    discount = 0.85;
                }
            }
            else if (flowerType == "Narcissus")
            {
                price = 3.0;

                if (flowerCount < 120)
                {
                    discount = 1.15;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                price = 2.5;

                if (flowerCount < 80)
                {
                    discount = 1.2;
                }
            }

            totalCosts = flowerCount * price * discount;


            if (totalCosts <= budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} " +
                    $"{flowerType} and {(budget - totalCosts):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalCosts-budget):f2} leva more.");
            }
        }
    }
}
