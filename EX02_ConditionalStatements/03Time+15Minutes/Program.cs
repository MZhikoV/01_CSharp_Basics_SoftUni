using System;
using System.Collections.Generic;
using System.Text;

namespace _03Time_15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourI=int.Parse(Console.ReadLine());
            int minI=int.Parse(Console.ReadLine());

            int totMin = hourI * 60 + minI + 15;

            int hourA, minA;

            if (totMin/60>=24)
            {
                hourA = totMin / 60 - 24;
            }
            else
            {
                hourA = totMin/60;
            }
            minA = totMin % 60;

            if (minA < 10)
            {
                Console.WriteLine($"{hourA}:0{minA}");
            }
            else
            {
                Console.WriteLine($"{hourA}:{minA}");
            }
        }
    }
}
