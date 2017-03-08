using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FlexArrayMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            int[] first = {1,2,3,5,8,9};

            int[] sacred = { 10, 50, 80, 90, 120 };

            int[] blessed = { 41, 62, 93, 475, 87, 19, 1662,1778 };

            p.ArrayDisplay(sacred);

           WriteLine("*********************");

            p.ArrayDisplay(first);

           WriteLine("*********************");

            p.ArrayDisplay(blessed); 
            
            WriteLine("We have completely figured out your game!!!! \n" +
                "Thanks for stopping by!!!");
            WriteLine();
            ReadKey();

        }

        public void ArrayDisplay(int [] clever)
        {
            for (int i = 0; i < clever.Length; i++)
            {
                WriteLine(clever[i]);
            }
             int dude = clever.Sum();

            Console.WriteLine($" \n The sum of the elements of the array is {dude} \n");

            //ReadKey();
        }
    }
}
