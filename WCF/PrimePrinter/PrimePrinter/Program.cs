using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PrimePrinter
{
    class Program
    {
        static void Main()
        {
            for (int i = 2; i <=100; i++)
            {
                if(i % 2 != 0)
                {
                    Print(i);
                }
                else
                {
                    WriteLine($" {i} Is Not a Prime #");
                }
                
            }

            ReadLine();
        }

        static void Print(int prime)
        {

            Console.WriteLine($"{prime} Is a Prime Number!!!");

           // Main();
        }


    }
}
