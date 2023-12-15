using System;
using System.Collections.Generic;
using System.Text;

namespace _07AreaofFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type=Console.ReadLine();
            double area = 0;

            if (type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                area = Math.Pow(side, 2);
            }
            else if (type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                area = sideA * sideB;
            }
            else if(type == "circle")
            {
                double radius=double.Parse(Console.ReadLine());
                area=Math.Pow(radius, 2)*Math.PI;
            }
            else if( type == "triangle")
            {
                double sideA=double.Parse(Console.ReadLine());
                double heihghtH=double.Parse(Console.ReadLine());
                area = sideA * heihghtH / 2;
            }
            Console.WriteLine(Math.Round(area,3));
        }
    }
}
