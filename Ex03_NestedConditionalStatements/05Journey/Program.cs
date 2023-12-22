using System;
using System.Collections.Generic;
using System.Text;

namespace _05Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            string season=Console.ReadLine();

            string destination = " ", stayType = " ";
            double totalCosts=0;

            if (budget<=100)
            {
                destination = "Bulgaria";

                if (season== "summer")
                {
                    totalCosts=budget*0.3;
                    stayType = "Camp";
                }
                else
                {
                    totalCosts = budget * 0.7;
                    stayType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";

                if (season == "summer")
                {
                    totalCosts = budget * 0.4;
                    stayType = "Camp";
                }
                else
                {
                    totalCosts = budget * 0.8;
                    stayType = "Hotel";
                }
            }
            else
            {
                destination = "Europe";
                totalCosts = budget * 0.9;
                stayType = "Hotel";
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{stayType} - {totalCosts:f2}");
        }
    }
}
