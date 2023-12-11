using System;
using System.Collections.Generic;
using System.Text;

namespace _09FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenL=int.Parse(Console.ReadLine());
            int widW=int.Parse(Console.ReadLine());
            int heiH=int.Parse(Console.ReadLine());
            double percP=double.Parse(Console.ReadLine());

            double volume = (1.0 * (lenL * widW * heiH) / 1000) * (1 - percP / 100);
            Console.WriteLine(volume);
        }
    }
}
