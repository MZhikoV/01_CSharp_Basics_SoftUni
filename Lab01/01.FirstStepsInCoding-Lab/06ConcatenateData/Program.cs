﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06ConcatenateData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName=Console.ReadLine();
            string lastName=Console.ReadLine();
            string age=Console.ReadLine();
            string town=Console.ReadLine();

            Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");

            //"You are <firstName> <lastName>, a <age>-years old person from <town>."
        }
    }
}
