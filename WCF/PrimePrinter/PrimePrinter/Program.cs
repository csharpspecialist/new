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
            int i = 2;
            for (i = 2; i <=100; i++)
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

            for (int a = 2; a <= i / 2; a++)
            {
                if (i % a == 0)
                {
                    Console.WriteLine(i + " is not prime number");
                    return;
                }

            }
            Console.WriteLine(i + " is a prime number");

            ReadLine();
        }

        static void Print(int prime)
        {

            Console.WriteLine($"{prime} Is a Prime Number!!!");

           // Main();
        }


    }
}
