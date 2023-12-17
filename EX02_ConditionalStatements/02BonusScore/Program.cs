using System;
using System.Collections.Generic;
using System.Text;

namespace _02BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num=double.Parse(Console.ReadLine());
            double bonus = 0;

            if (num < 100 ) {
                bonus = 5;
            }
            else if (num >1000)
            {
                bonus = 0.1 * num;
            }
            else
            {
                bonus=0.2 * num;
            }

            if (num%2==0)
            {
                bonus += 1;
            }

            if (num%10==5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
