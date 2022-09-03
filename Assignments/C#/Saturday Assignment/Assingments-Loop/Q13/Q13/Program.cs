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
            int count=0;
            for (int i = 1; i <= 3; i++)
            {
                for (int j = i; j <=3 ; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    count++;
                    Console.Write(count);
                }
                for (int l = 2; l <= i; l++)
                {
                    count++;
                    Console.Write(count);
                }
                Console.WriteLine();
            }
        }
    }
}
