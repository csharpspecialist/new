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
        static void Main()
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

            p.Menu();
            Console.WriteLine("*********************");
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

        public void Menu()
        {
            Console.WriteLine("  Would You Like To Try Again?? \n \n" +
                "Y   or   N \n");
            string answ = Console.ReadLine().ToUpper();


            if (answ == "Y")
            {
                Main();
            }
            else
            {
                Console.WriteLine(" \n Thanks for using our program!!");
            }

            //make sure the main method looks like this   static void Main()
        }
    }
}
