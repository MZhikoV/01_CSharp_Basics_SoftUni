using System;
using System.Collections.Generic;
using System.Text;

namespace _01USDtoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd=double.Parse(Console.ReadLine());
            double lev = usd * 1.79549;
            Console.WriteLine(lev);
        }
    }
}
