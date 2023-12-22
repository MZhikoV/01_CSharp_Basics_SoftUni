using System;
using System.Collections.Generic;
using System.Text;

namespace _02SummerOutfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempDeg = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine();

            string outfit=" ", shoes=" ";

            if (dayTime == "Morning")
            {
                if (tempDeg >= 10 && tempDeg <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (tempDeg > 18 && tempDeg <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (tempDeg >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (dayTime == "Afternoon")
            {
                if (tempDeg >= 10 && tempDeg <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (tempDeg > 18 && tempDeg <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (tempDeg >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (dayTime == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It's {tempDeg} degrees, get your {outfit} and {shoes}.");
        }
    }
}
