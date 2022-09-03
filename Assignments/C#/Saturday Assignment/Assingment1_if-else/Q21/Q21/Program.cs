using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string n;
            string d="";
            Console.WriteLine("Read digit value");
            n = Console.ReadLine();
            switch (n)
            {
                case "one":
                    d = "1";
                    break;
                case "two":
                    d = "2";
                    break;
                case "three":
                    d = "3";
                    break;
                case "four":
                    d = "4";
                    break;
                case "five":
                    d = "5";
                    break;
                case "six":
                    d = "6";
                    break;
                case "seven":
                    d = "7";
                    break;

                    

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.WriteLine("Number :" +d);

        }
    }
}
