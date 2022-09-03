using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int res = 0;
            Console.WriteLine("Enter number");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("----displaying the cube of the number up to given an integer----");

            for (int i = 1; i <= n; i++)
            {
                res = i * i * i;
                
                Console.WriteLine(res);
            }
        }
    }
}
