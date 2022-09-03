using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q22
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
                    d = "January";
                    break;
                case 2:
                    d = "February";
                    break;
                case 3:
                    d = "March";
                    break;
                case 4:
                    d = "April";
                    break;
                case 5:
                    d = "May";
                    break;
                case 6:
                    d = "June";
                    break;
                case 7:
                    d = "July";
                    break;
                case 8:
                    d = "August";
                    break;
                case 9:
                    d = "September";
                    break;
                case 10:
                    d = "October";
                    break;
                case 11:
                    d = "November";
                    break;
                case 12:
                    d = "December";
                    break;





                default:
                    Console.WriteLine("Invalid");
                    break;
            }
            Console.WriteLine("Month :" + d);

        }
    }
}
