using System;
using System.Collections.Generic;
using System.Text;

namespace _05GodzillavsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget=double.Parse(Console.ReadLine());
            int statists=int.Parse(Console.ReadLine());
            double clothesPrice=double.Parse(Console.ReadLine());

            double dekor = 0.1 * budget;
            double statistsMoney = statists* clothesPrice;

            if (statists >150) {
                statistsMoney *= 0.9;
            }

            double totalPrice = dekor + statistsMoney;

            if (totalPrice > budget)
            {
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs {(totalPrice-budget):f2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - totalPrice):f2} leva left.");
            }
        }
    }
}
