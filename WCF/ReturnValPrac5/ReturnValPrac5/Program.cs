using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReturnValPrac5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();


            //int totalInt;
            //Console.WriteLine("First # to multiply");

            //int fNum = Convert.ToInt16(ReadLine());

            //Console.WriteLine("2nd # to multiply");

            //int secNum = Convert.ToInt16(ReadLine());

            //totalInt = p.Multi(fNum, secNum);

            //Console.WriteLine($"The total is {totalInt}");
            //ReadKey();

            int[] numeros = {10,12,45,66 };

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);

            }
            int strk = numeros.Sum();

            Console.WriteLine($"The sum of the numeros array is {strk}");
            ReadKey();
        }

        public int Multi(int numVal1, int numVal2)
        {
            int sum = numVal1 + numVal2;


            return sum;
        }
    }
}
