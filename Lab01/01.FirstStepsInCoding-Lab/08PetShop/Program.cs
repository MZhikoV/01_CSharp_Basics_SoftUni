using System;
using System.Collections.Generic;
using System.Text;

namespace _08PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood=int.Parse(Console.ReadLine());
            int catFood=int.Parse(Console.ReadLine());

            double price = dogFood * 2.5 + catFood * 4.0;
            Console.WriteLine(price + " lv.");
        }
    }
}
