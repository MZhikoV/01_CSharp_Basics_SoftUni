using System;
using System.Collections.Generic;
using System.Text;

namespace _03DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum=double.Parse(Console.ReadLine());
            int periodM=int.Parse(Console.ReadLine());
            double lihva=double.Parse(Console.ReadLine());

            double sum=depositSum+ periodM*((depositSum*lihva/100)/12);
            Console.WriteLine(sum);
        }
    }
}
