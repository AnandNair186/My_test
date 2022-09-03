using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int sum=0;
            Console.WriteLine("Enter a number");
            n=Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }
            Console.WriteLine("Sum of 'n' natural no. :"+sum);
        }
    }
}
