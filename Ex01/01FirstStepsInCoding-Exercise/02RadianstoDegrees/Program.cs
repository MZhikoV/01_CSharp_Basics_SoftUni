using System;
using System.Collections.Generic;
using System.Text;

namespace _02RadianstoDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double rad=double.Parse(Console.ReadLine());
            double deg=rad*180/Math.PI;
            Console.WriteLine(deg);
        }
    }
}
