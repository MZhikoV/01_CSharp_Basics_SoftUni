using System;
using System.Collections.Generic;
using System.Text;

namespace _06WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordTime=double.Parse(Console.ReadLine());
            double distance=double.Parse(Console.ReadLine());
            double timeForM=double.Parse(Console.ReadLine());

            double totalTime=distance*timeForM;
            double resistance = (Math.Floor(distance / 15)) * 12.5;

            totalTime += resistance;

            if (totalTime < recordTime) {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {totalTime - recordTime:f2} seconds slower.");
            }
        }
    }
}
