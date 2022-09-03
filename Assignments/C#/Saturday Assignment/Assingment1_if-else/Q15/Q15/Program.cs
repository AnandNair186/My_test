using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2, s3,total;
            Console.WriteLine("Enter Side 1");
            s1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Side 2");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Side 3");
            s3 = Convert.ToInt32(Console.ReadLine());

            total=s1+s2+s3;
            Console.WriteLine(" Sum of Interior angle :"+total);

            if (total>=180)
            {
                Console.WriteLine("Valid Triangle");
            }
            else
            {
                Console.WriteLine("Not a Triangle");
            }
        }
    }
}
