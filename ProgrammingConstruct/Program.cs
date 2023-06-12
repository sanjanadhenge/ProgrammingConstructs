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
            string s = "", rev = "";
            int len = 0;
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();
            len = s.Length - 1;
            while (len >= 0)
            {
                rev = rev + s[len];
                len--;
            }
            Console.WriteLine("Reverse of string is {0}", rev);
        }

    }

    
}