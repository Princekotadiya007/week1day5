using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10_LargestThreeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the third number:");
            int C = Convert.ToInt32(Console.ReadLine());

            if(A>B && A>C)
            {
                Console.WriteLine("First : is largest number is among three number");
            }
            else if (B>A && B>C)
            {
                Console.WriteLine("Second : is largest number is among three number");
            }
            else
            {
                Console.WriteLine("Third : is largest number is among three number");
            }
        }
    }
}
