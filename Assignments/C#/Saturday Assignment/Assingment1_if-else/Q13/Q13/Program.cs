using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Enter Temperature.");
            temp = Convert.ToInt32(Console.ReadLine());

            if (temp<0)
            {
                Console.WriteLine("Very Cold");
            }
            else if (temp>0 && temp<=10)
            {
                Console.WriteLine("Cold Weather");
            }
            
            else if (temp > 10 && temp <=20)
            {
                Console.WriteLine("Normal ");
            }
            else if (temp > 20 && temp <=30)
            {
                Console.WriteLine("Hot Weather");
            }
            else
            {
                Console.WriteLine("Very Hot");
            }
        }
    }
}
