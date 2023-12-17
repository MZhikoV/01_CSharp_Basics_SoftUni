using System;
using System.Collections.Generic;
using System.Text;

namespace _08LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string series=Console.ReadLine();
            int seriesLen=int.Parse(Console.ReadLine());
            int breakLen=int.Parse(Console.ReadLine());

            double totTime = 0.125 * breakLen + 0.25 * breakLen + seriesLen;

            if (totTime > breakLen) {
                Console.WriteLine($"You don't have enough time to watch {series}, you need {Math.Ceiling(totTime - breakLen)} more minutes.");
            }
            else
            {
                Console.WriteLine($"You have enough time to watch {series} and left with {Math.Ceiling(breakLen - totTime)} minutes free time.");
            }
        }
    }
}
