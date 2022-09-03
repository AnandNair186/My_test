using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            string d="";
            Console.WriteLine("Enter Day no");
            n=Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 0:
                    d = "Sunday";
                    break;
                    case 1:
                    d = "Monday";
                    break ;
                    case 2:
                    d = "Tuseday";
                    break;
                    case 3:
                    d = "Wednesday";
                    break;
                    case 4:
                    d = "Thursday";
                    break;
                    case 5:
                    d = "Friday";
                    break;
                case 6:
                    d = "Saturday";
                    break;



                default:
                    Console.WriteLine("Day no. should be between (0-6)");
                    break;
            }
            Console.WriteLine("Day :"+d);
        }
    }
}
