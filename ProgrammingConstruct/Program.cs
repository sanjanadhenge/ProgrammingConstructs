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
            Console.WriteLine("Enter 2nd No ");
            int b = Convert.ToInt32(Console.ReadLine());
            if(a==b)
            {
                Console.WriteLine("Two Numbers are Equal");
            }
            else
            {
                Console.WriteLine("Two Numbers are not Equal");
            }



        }

    }
}