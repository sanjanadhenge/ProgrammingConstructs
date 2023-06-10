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
            Console.WriteLine("Enter 1st num ");
            int a=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd num ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd Num ");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a>b && a>c)
            {
                Console.WriteLine(a+ "is Largest");
            }
            else if(b>a && b>c)
            {
                Console.WriteLine(b + "is Largest");
            }
            else
            {
                Console.WriteLine(c + "is Largest");
            }



        }

    }
}