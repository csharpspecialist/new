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
                Console.WriteLine("{0,4}{1,20:C}", year,amount);
            }
            ReadLine();



        }


    }
}
