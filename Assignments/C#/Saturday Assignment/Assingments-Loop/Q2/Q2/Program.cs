using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count;
            int sum=0;
            for (count = 1; count <= 10; count++)
            {
               sum=sum+count;

            }
            Console.WriteLine(sum);
        }
    }
}
