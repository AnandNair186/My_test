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
            int n;
            int fact = 1;
            Console.WriteLine("Enter a no");
            n=Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
                
            }
            Console.WriteLine("Factorial :" + fact);
        }
    }
}
