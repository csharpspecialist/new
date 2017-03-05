using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BinaryArraySearch
{
    class Program
    {
        static void Main(string[] args)
        {

            Search();
            Order();
            


        }

        public static void Search()
        {

            int[] things = { 100, 220, 450, 410, 225, 700, };

            int x;
            //string entryString;
            int entryID;

            WriteLine("Enter an Entry Id for verification");
            entryID = Convert.ToInt16(ReadLine());

            x = Array.BinarySearch(things, entryID);

            if (x < 0)
            {
                WriteLine($"Your ID # of {entryID}..is not a valid id!!!");
            }
            else
            {
                WriteLine($"Your ID # of {entryID}..is valid!!!");
            }

            WriteLine("would you like to search again?? \n Y or N");

            string ans = ReadLine().ToUpper(); 

            if (ans == "Y")
            {
                Search();
            }
            else
            {
                WriteLine("Thanks for using our program!!");
            }
            
        }

        public static void Order()
        {

            string [] cpu = { "Piledriver", "Excavator", "Bulldozer", "I - 7", "Core 2 Duo" };

            WriteLine("Should we sort the array");

            Array.Sort(cpu);

            for (int i = 0; i < cpu.Length; i++)
            {
                WriteLine("Cpu's in alphabetical order " + cpu[i]);
            }

            ReadKey();

        }
    }
}
