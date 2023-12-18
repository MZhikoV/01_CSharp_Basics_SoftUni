using System;
using System.Collections.Generic;
using System.Text;

namespace _10InvalidNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());

            if (num != 0 && (num<100 || num>200)) 
            {
                Console.WriteLine("invalid");
            }
        }
    }
}
