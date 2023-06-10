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
            Console.WriteLine("Enter 1st No ");
            int a=Convert.ToInt32(Console.ReadLine());
            if(a%2 == 0)
            {
                Console.WriteLine(a+" is Even Number");
            }
            else
            {
                Console.WriteLine(a + " is Odd Number");
            }



        }

    }
}