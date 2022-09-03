using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char x;
            string Grade="";
            
            Console.WriteLine("Enter Grade");
            x = Convert.ToChar(Console.ReadLine());

            switch (x)
            {
                case 'E':
                Grade="Excellent";
                break;
                case 'V':
                Grade="Very Good";
                break;

                case 'G':
                    Grade="Good";
                    break;

                case 'A':
                    Grade="Average";
                    break;

                case 'F':
                    Grade="Fail";
                    break;

                    default:
                    Grade="Invalid Grade";
                    break ;

                    



            }
            Console.WriteLine("Grade ="+Grade);
        }
    }
}
