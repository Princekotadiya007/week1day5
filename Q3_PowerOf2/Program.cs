using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_PowerOf2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N ;
            Console.WriteLine("Enter the number between 0 to 30");
            N = Convert.ToInt32(Console.ReadLine());

            // Make sure N is in the valid range
            if (N < 0 || N >= 31)
            {
                Console.WriteLine("Error: N must be between 0 and 30 ");
            }

            // Print powers of 2
            Console.WriteLine("Powers of 2 that are less than or equal to 2^{0}:", N);
            int num = 1;
            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine("2^{0} = {1}", i, num);
                num *= 2;
            }
        }
    }
}
