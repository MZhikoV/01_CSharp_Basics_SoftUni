using System;
using System.Collections.Generic;
using System.Text;

namespace _07Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            int vCard=int.Parse(Console.ReadLine());
            int procc=int.Parse(Console.ReadLine());
            int ramM=int.Parse(Console.ReadLine());

            double priceVC = vCard * 250;
            double priceProcc = priceVC * 0.35 * procc;
            double priceRam = priceVC * 0.1 * ramM;

            double totPrice = priceVC + priceProcc + priceRam;

            if (vCard>procc)
            {
                totPrice *= 0.85;
            }
            if (budget>= totPrice) {
                Console.WriteLine($"You have {budget - totPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totPrice - budget:f2} leva more!");
            }
        }
    }
}
