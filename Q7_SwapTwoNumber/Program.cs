using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7_SwapTwoNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("enter the num1");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the num2");
            num2 = Convert.ToInt32(Console.ReadLine());

            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;

            Console.WriteLine("After swapping, first number: "+ num1);
            Console.WriteLine("After swapping, second number: "+ num2);

        }
    }
}
