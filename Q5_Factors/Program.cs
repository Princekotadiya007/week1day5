using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_Factors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the number to find the prime factors of
            int N ;
            N = Convert.ToInt32(Console.ReadLine());
            // check if N is greater than 1
            if (N <= 1)
            {
                Console.WriteLine("Error: N must be greater than 1.");
            }

            Console.Write("The prime factors of " + N + " are: ");

            // Find the prime factors
            for (int i = 2; i <= N; i++)
            {
                while (N % i == 0)
                {
                    Console.Write(i + " ");
                    N = N / i;
                }
            }
        }
    }
}
