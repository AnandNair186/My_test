using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string n;
            int id, unit;
            float bill;
            float totbill = 0;
            
            
            Console.WriteLine("Enter Customer ID :");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name");
            n = Console.ReadLine();
            Console.WriteLine("Enter Unit Consumed");
            unit = Convert.ToInt32(Console.ReadLine());
            

            if (unit<=199)
            {
                bill = unit * 1.20f;
                Console.WriteLine("Bill @1.20/unit :"+bill);
                totbill = bill;
            }
            else if (unit>=200 && unit<400)
            {
                bill = unit * 1.50f;
                Console.WriteLine("Bill @1.50/unit :" + bill);
                totbill = bill;
            }
            else if (unit >=400 && unit < 600)
            {
                bill = unit * 1.80f;
                Console.WriteLine("Bill @1.80/unit :" + bill);
                totbill = bill;
            }
            else if  (unit>600)
            {
                bill = unit * 2.00f;
                Console.WriteLine("Bill @2.00/unit :" + bill);
                totbill = bill;
            }
            Console.WriteLine("----------------Service Charge Calculation-------------------");
            Console.WriteLine("Bill per unit : "+totbill);

            float surcharge;
            float netamount;

            if (totbill>400)
            {
                surcharge=0.15f*totbill;
                Console.WriteLine("Service Charge : "+surcharge);
                netamount = surcharge + totbill;
                Console.WriteLine("Net Amount to be paid : "+netamount);
            }
            
            
        }
    }
}
