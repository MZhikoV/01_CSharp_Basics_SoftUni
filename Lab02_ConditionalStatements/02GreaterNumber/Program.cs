﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _02GreaterNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=int.Parse(Console.ReadLine());
            int b=int.Parse(Console.ReadLine());

            if (a>b)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
