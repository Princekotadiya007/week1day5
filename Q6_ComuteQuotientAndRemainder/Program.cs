using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6_ComuteQuotientAndRemainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the dividend and divisor
            int dividend ;
            int divisor ;

            Console.WriteLine("enter number devidend :");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter number divisor :");
            divisor = Convert.ToInt32(Console.ReadLine());

            // Compute the quotient and remainder
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            // Print the results
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
        }
    }
}
