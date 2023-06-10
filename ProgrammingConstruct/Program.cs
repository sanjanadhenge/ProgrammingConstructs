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

            Console.WriteLine("Enter the power ");
            double a= Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for(int i = 0; i <=a; i++)
            {
                result = Math.Pow(2, i);
                Console.WriteLine("2*"+i+"="+result);
            }
            
        



        }

    }
}