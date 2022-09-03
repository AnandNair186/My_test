using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rno, ph, ch, ca,total;
            string n,div="";
            float per;

            Console.WriteLine("Enter Name");
            n = Console.ReadLine();

            Console.WriteLine("Enter marks in Rollno.");
            rno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks in Physics");
            ph=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks in Chemistry");
            ch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter marks in Computer Applicaations");
            ca = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name :"+n);
            Console.WriteLine("Roll no :"+rno);

            Console.WriteLine("Marks in Physics :"+ph);
            Console.WriteLine("Marks in Chemistry :"+ch);
            Console.WriteLine("Marks in Computer Applicaations :"+ca);

            total =ph+ch+ca;
            Console.WriteLine("Total Marks :"+total);

            per = (total / 300f) * 100f;
            Console.WriteLine("Percentage :" + per);

            if (per>75)
            {
                div="First";
            }
            else
            {
                div = "Second";
            }
            Console.WriteLine("Division :"+div);
        }
    }
}
