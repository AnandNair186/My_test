using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            Console.WriteLine("Enter X");
            X=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Y");
            Y=Convert.ToInt32(Console.ReadLine());

            if (X >0 && Y >0)
            {
                Console.WriteLine("1st Quadrant");
            }
            else if (X<0 && Y>0)
            {
                Console.WriteLine("2nd Quadrant");
            }
            else if (X<0 && Y<0)
            {
                Console.WriteLine("3rd Quadrant");
            }
            else
            {
                Console.WriteLine("4th Quadrant");
            }
        }
    }
}
