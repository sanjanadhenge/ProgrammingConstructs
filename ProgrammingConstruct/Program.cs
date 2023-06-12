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
            bool flag = true;
            int head=0,tail=0;
            Random random = new Random();
            while(flag)
            {
                  int check = random.Next(0,2);
                  if(check == 0)
                {
                    tail++;
                }
                  if(check == 1)
                {
                    head++;
                }
                  if(head == 20 || tail == 20)
                {
                    flag = false;
                }
            }
            Console.WriteLine("Head=> "+head + "Tail=> " + tail);
        }

    }

    
}