using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string op = Console.ReadLine();
            double result = 0;
            string chetnost = "";

            switch (op)
            {
                case "+":
                    result = n1 + n2; break;
                case "-":
                    result = n1 - n2; break;
                case "*":
                    result = n1 * n2; break;
                case "/":
                    if (n2 != 0)
                    {
                        result = (double)n1 / n2;
                    }
                    break;
                case "%":
                    if (n2 != 0)
                    {
                        result = n1 % n2;
                    }
                    break;
            }

            if (n2 == 0)
            {
                if (op == "/" || op == "%")
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
            }
            else
            {
                double Chetnost = result % 2;

                if (Chetnost == 0)
                {
                    chetnost = "even";
                }
                else if (Chetnost == 1)
                {
                    chetnost = "odd";
                }
                if (op == "%")
                {
                    Console.WriteLine($"{n1} {op} {n2} = {result}");
                }
                else if (op == "/")
                {
                    Console.WriteLine($"{n1} {op} {n2} = {result:f2}");
                }
                else
                {
                    Console.WriteLine($"{n1} {op} {n2} = {result} - {chetnost}");
                }
            }
        }
    }
}