using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FizzTryByHand
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 100; i++)
            {
                if  (i % 3 == 0 && i % 7 == 0)
                {
                    WriteLine("On");
                }
                else if (i % 7 == 0)
                {
                    WriteLine("Base");
                }
                else if (i % 3 == 0)

                {
                    WriteLine("OnBase");
                }
                else
                {
                    WriteLine("");
                }
            }

            ReadLine();


        }
    }
}
