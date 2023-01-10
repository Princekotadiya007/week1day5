using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numFlip = 10; //coin 10 times flip
            double head = 0;
            double tail = 0;

            Random random = new Random();
            int coin = random.Next(0, 1);

            //double div = coin / 2;
            //Console.WriteLine(div);

            for (int i = 0; i < numFlip; i++)
            {
                if(coin == 0.5)
                {
                    Console.WriteLine("Tail");
                    tail++;
                }
                else
                {
                    Console.WriteLine("head");
                    head++;
                }

                // Calculate the percentage
                double coinHead = (head / numFlip) * 100 ;
                double coinTail = (tail / numFlip) * 100 ;
                Console.WriteLine("percentage head is{0} and tail is {1}", coinHead, coinTail);
            }
        }
    }
}



