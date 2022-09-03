using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, p, c,total;
            Console.WriteLine("Enter marks in Maths");
            m=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks in Physics");
            p = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks in Chem");
            c = Convert.ToInt32(Console.ReadLine());

            total = m +p + c;
            Console.WriteLine("Total Marks :"+total);

            if (total>=180)
            {
                Console.WriteLine("The candidate is eligible for admission");
            }
            else
            {
                Console.WriteLine("Not Eligible for admission");
            }
        }
    }
}
