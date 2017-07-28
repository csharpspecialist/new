using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CarPayment_LoopsPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
           // LoopTotal();

          //  LoopSum();

            CarCalc();

        }

        private static void LoopTotal()
        {
         
            int total = 0;

            for (int i = 2; i <= 20; i += 2)
            {
                total += i;
            }
            Console.WriteLine(total);
            Console.ReadLine();
        }

        private static void LoopSum()
        {
            int[] why = { 2, 5, 88, 14, 20, 48 };
            int sum = 0;

            for (int i = 0; i < why.Length; i += 1)
            {
                sum += (why[i]);
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }


        public static void CarCalc()
        {
            int total;

            WriteLine("Enter the time that you will finance the vehicle");
            //int financeTime  = Convert.ToInt16( ReadLine());

            string financeTime = ReadLine();

            //WriteLine


            int.TryParse(financeTime, out total);

            decimal amount;
            double rate = 0.069;
            Console.WriteLine("Year {0,2}", "Amount on Deposit");

            for (int year = 0; year < 10; year++)
            {
                amount = total * ((decimal)Math.Pow(1.0 + rate, year));
                Console.WriteLine("{0,4}{1,20:C}", year, amount);
            }
            ReadLine();

            StringArray();

        }

        private static void StringArray()
        {
            string[] friendNames = { "Todd Anthony", "Kevin Holton", "Shane Laigle" };
            //int i;
            WriteLine($"Here are {friendNames.Length} of my friends:");
            for (int i = 0; i < friendNames.Length; i++)
            {
                WriteLine(friendNames[i]);
            }
            ReadKey();
            ArrayListing();
        }


        public static void ArrayListing()
        {

            string[] dude = new string[6];
            dude[0] = "Opel";
            dude[1] = "BMW";
            dude[2] = "Lexus";
            dude[3] = "Chevy";
            dude[4] = "Mercury";
            dude[5] = "Lincoln";


            for (int i = 0; i < dude.Length; i++)
            {
                Console.WriteLine(dude[i]);
            }
            Console.ReadLine();
        }
        

    }
}
