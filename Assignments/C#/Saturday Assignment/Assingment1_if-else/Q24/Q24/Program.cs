using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int l, b,r,s;
            float res = 0;
            int ip;

            Console.WriteLine("Enter Length");
            l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Breadth");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Radius");
            r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Side");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Choice : 1=Circle 2=Rectangle 3=Triangle 4=Square");
            Console.WriteLine("Enter Input Choice");
            ip = Convert.ToInt32(Console.ReadLine());
           

            
           
           
            

            

            switch (ip)
            {
                case (1):
                    res = 3.14f * r * r;
                    break;
                    case (2):
                    res = l * b;
                    break;
                case (3):
                    res = 0.5f * l * b;
                    break;
                    case (4):
                    res = s * s;
                    break;

                default:
                    break;
            }
            Console.WriteLine("Area :"+res);

        }
    }
}
