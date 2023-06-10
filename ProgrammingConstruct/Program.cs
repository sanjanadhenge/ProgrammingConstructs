using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class Program

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Marks in Physics ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks in Chemistry");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marks in Maths ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a>=55 && b>=50 && c>=65 && (a+b+c)>=180)
            {
                Console.WriteLine( "Eligible for admission");
            }
            else if((c+a)>=140 || (c+b)>=140)
            {
                Console.WriteLine("Eligible for admission");
            }
            else
            {
                Console.WriteLine("Not Eligible for admission");
            }



        }

    }
}