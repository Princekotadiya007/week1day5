using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Q4_HormonicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the harmonic value N from the command-line argument
            int N ;
            N = Convert.ToInt32(Console.ReadLine());

            // Make sure N is not 0
            if (N == 0)
            {
                Console.WriteLine("Error: N must be greater than 0.");
            }

            // Compute the Nth harmonic number
            double harmonic = 0.0;
            for (int i = 1; i <= N; i++)
            {
                harmonic += 1.0 / i;
            }

            // Print the result
            Console.WriteLine("The {0}th harmonic number is: {1}", N, harmonic);
        }
    }
}
