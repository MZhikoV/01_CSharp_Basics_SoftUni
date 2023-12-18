using System;
using System.Collections.Generic;
using System.Text;

namespace _06NumberinRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num=double.Parse(Console.ReadLine());

            if (num != 0 && (num>=-100 && num<=100 ))
            {
                Console.WriteLine("Yes");
            }
            else { Console.WriteLine("No"); }
        }
    }
}
