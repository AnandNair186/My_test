﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num3");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2 && num1>num3)
            {
                Console.WriteLine("Num1 is greater");
            }
            else if (num2>num1 && num2 > num3)
            {
                Console.WriteLine("Num2 is greater");
            }
            else
            {
                Console.WriteLine("Num3 is greater");
            }
        }
    }
}
