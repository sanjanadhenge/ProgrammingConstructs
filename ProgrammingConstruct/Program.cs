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
            int a= Convert.ToInt32(Console.ReadLine());
          int  result = 0;
            int sum = 0;
            for(int i = 1; i <=a; i++)
            {
                result = i * i;
                sum += result;
               
            }
            Console.WriteLine("sum of the square is =>" + result);




        }

    }
}