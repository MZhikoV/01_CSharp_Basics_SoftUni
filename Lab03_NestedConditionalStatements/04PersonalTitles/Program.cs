using System;
using System.Collections.Generic;
using System.Text;

namespace _04PersonalTitles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double age=double.Parse(Console.ReadLine());
            string gender=Console.ReadLine();

            if (gender == "m")
            {
                if (age >= 16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }
            }
            else if (gender == "f")
            {
                if (age >=16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
