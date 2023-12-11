using System;
using System.Collections.Generic;
using System.Text;

namespace _04VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages=int.Parse(Console.ReadLine());
            int pagesPerHour=int.Parse(Console.ReadLine());
            int days=int.Parse(Console.ReadLine());

            int hourPerDay = pages / days / pagesPerHour;
            Console.WriteLine(hourPerDay);
        }
    }
}
