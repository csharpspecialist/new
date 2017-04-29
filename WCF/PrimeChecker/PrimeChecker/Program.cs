using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            bool currNum = false;

            for (int i = 2; i < 100; i++)
            {
                for (p = 2; p < i; p++)
                {
                    if (i % p == 0)
                    {
                        currNum = true;
                    }
                }

                if (currNum == false)
                {
                    Checker(p);
                }
                else currNum = false;
            }

            ReadLine();
        

 

        }

        public static void Checker(int primeNum)
        {

            Console.WriteLine($"The prime #'s are {primeNum}");           


        }
     

    }
}
