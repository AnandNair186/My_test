using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cp, sp,profit ,loss;
            Console.WriteLine("Enter CP");
            cp=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter SP");
            sp=Convert.ToInt32(Console.ReadLine());

            profit = sp - cp;
            loss = cp - sp;

            if (cp<sp)
            {
                Console.WriteLine("Profit ="+profit);
            }
            else
            {
                    Console.WriteLine("Loss ="+loss);
            }
        }
    }
}
