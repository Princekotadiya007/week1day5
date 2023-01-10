using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9_AlphabetVowelConsonst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter ;
            letter = (Char)Console.Read();

            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' ||
                letter == 'A' || letter == 'E' || letter == 'I' || letter == 'O' || letter == 'U')
            {
                Console.WriteLine("The letter is a vowel.");
            }
            else
            {
                Console.WriteLine("The letter is a consonant.");
            }
          
        }
    }
}
