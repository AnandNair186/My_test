using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4,n5,n6,n7,n8,n9,n10,res;
            float avg;


            Console.WriteLine("Enter num1");
            n1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num2");
            n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num3");
            n3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter num4");
            n4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num5");
            n5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num6");
            n6 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num7");
            n7 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num8");
            n8 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num9");
            n9 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num10");
            n10 = Convert.ToInt32(Console.ReadLine());

            res = n1 + n2 + n3 + n4 + n5 + n6 + n7 + n8 + n9 + n10;
            avg = res / 10f;
            Console.WriteLine("Sum of 10 numbers :"+res);
            Console.WriteLine("Average :"+avg);

        }
        
    }
}
