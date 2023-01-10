using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the input year
            Console.Write("Enter a year: ");
            int year = Convert.ToInt32(Console.ReadLine());

            // Check if the year is a leap year
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                Console.WriteLine("The year {0} is a leap year.", year);
            }
            else
            {
                Console.WriteLine("The year {0} is not a leap year.", year);
            }
        }
    }
}
