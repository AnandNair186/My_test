using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x;
            Console.WriteLine("Enter a Vowel");
            x=Convert.ToChar(Console.ReadLine());

            if (x == 'a' || x=='A'|| x == 'e' || x == 'E' || x == 'i' || x == 'I' || x == 'o' || x == 'O' || x == 'u' || x == 'U')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("The alphabet is a consonant");
            }
        }
    }
}
