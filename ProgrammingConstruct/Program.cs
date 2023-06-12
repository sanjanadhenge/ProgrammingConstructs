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
            int i = 1, sum = 0;
            while(i<=5)
            {
                i++;
                sum=sum+i;
            }
            Console.WriteLine("Sum of Five Natural No is "+sum);
        }

    }

    
}