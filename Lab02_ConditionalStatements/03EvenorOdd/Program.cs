using System;
using System.Collections.Generic;
using System.Text;

namespace _03EvenorOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());

            if (a%2 == 0) {
                Console.WriteLine("even");
            }
            else { Console.WriteLine("odd"); }
        }
    }
}
