using System;
using System.Collections.Generic;
using System.Text;

namespace _12TradeCommissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city=Console.ReadLine();
            double sales=double.Parse(Console.ReadLine());

            double comn = 0;

            if (city=="Sofia")
            {
                if (sales>=0 && sales<=500)
                {
                    comn = 0.05;
                }
                else if (sales <= 1000)
                {
                    comn = 0.07;
                }
                else if (sales <= 10000)
                {
                    comn = 0.08;
                }
                else if (sales > 1000)
                {
                    comn = 0.12;
                }
            }
            else if (city == "Varna")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comn = 0.045;
                }
                else if (sales <= 1000)
                {
                    comn = 0.075;
                }
                else if (sales <= 10000)
                {
                    comn = 0.10;
                }
                else if (sales > 1000)
                {
                    comn = 0.13;
                }
            }
            else if (city == "Plovdiv")
            {
                if (sales >= 0 && sales <= 500)
                {
                    comn = 0.055;
                }
                else if (sales <= 1000)
                {
                    comn = 0.08;
                }
                else if (sales <= 10000)
                {
                    comn = 0.12;
                }
                else if (sales > 1000)
                {
                    comn = 0.145;
                }
            }

            if (comn!=0 && sales>0)
            {
                comn *= sales;
                Console.WriteLine("{0:f2}", comn);
            }
            else
            {
                Console.WriteLine("error");
            }


            
        }
    }
}
