using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Height");
            num=Convert.ToInt32(Console.ReadLine());
            if (num<=135)
            {
                Console.WriteLine("The person is Dwarf.");
            }
            else
            {
                Console.WriteLine("The person is Tall.");
            }
        }
    }
}
