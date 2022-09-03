using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2;
            float res = 0;
            char op;
            Console.WriteLine("Enter num1");
            num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter no. 2");
            num2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator");
            op = Convert.ToChar(Console.ReadLine());
            switch (op)
            {
                case '+':
                    res=num1 + num2;
                    break;
                    case '-':
                        res=num1 - num2;
                    break;
                case '*':
                    res=num1 * num2;
                    break;
                    case '/':
                        res=num1 / num2;
                    break;

                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
            Console.WriteLine("Result :"+res);
        }
    }
}
