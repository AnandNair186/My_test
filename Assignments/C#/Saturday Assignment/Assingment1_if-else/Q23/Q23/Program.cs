using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string d = "";
            Console.WriteLine("Enter month no.");
            n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    d = "31 days";
                    break;
                case 2:
                    d = "31 days";
                    break;
                case 3:
                    d = "31 days";
                    break;
                case 4:
                    d = "30 days";
                    break;
                case 5:
                    d = "31 days";
                    break;
                case 6:
                    d = "30 days";
                    break;
                case 7:
                    d = "31 days";
                    break;
                case 8:
                    d = "31 days";
                    break;
                case 9:
                    d = "30 days";
                    break;
                case 10:
                    d = "31 days";
                    break;
                case 11:
                    d = "30 days";
                    break;
                case 12:
                    d = "31 days";
                    break;





                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.WriteLine("Month has :" + d);
        }
    }
}
