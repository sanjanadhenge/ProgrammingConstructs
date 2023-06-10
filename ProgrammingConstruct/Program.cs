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
            Console.WriteLine("Enter Age ");
            int a=Convert.ToInt32(Console.ReadLine());
            if(a>18)
            {
                Console.WriteLine("Candidate is Eligible");
            }
            else
            {
                Console.WriteLine( "Candidate is not Eligible");
            }



        }

    }
}