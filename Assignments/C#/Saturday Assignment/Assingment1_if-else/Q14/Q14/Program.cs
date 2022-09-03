using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s1, s2,s3;
            Console.WriteLine("Enter Side 1");
            s1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Side 2");
            s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Side 3");
            s3 = Convert.ToInt32(Console.ReadLine());

            /*if (s1==s2 || s1 == s3)
            {
                Console.WriteLine("Isoceles Triangle");
            }
            else if(s2==s3)
            {
                Console.WriteLine("Isoceles");
            }
            else if (s3==s1)
            {
                Console.WriteLine("Isoceles");
            }*/


            if (s1==s2 && s2==s3 )
            {
                Console.WriteLine("Equilateral Trinagle");
            }
            else if (s1!=s2 && s2!=s3 && s3!=s1)
            {
                Console.WriteLine("Scalene Triangle");
            }
            else
            {
                Console.WriteLine("Isoceles Triangle");
            }
        }
    }
}
