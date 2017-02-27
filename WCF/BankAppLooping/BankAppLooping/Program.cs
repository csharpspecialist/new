using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BankAppLooping
{
    class Program
    {
        static void Main() 
        {

            double bankBal;
            double rate;
            int year;

            double firstBal = 1000;
            double startBal;            
            const double START_INT = 0.04;
            const double INT_INCREASE = 0.02;
            const double LAST_INT = 0.08;
            const int END_YEAR = 6;

            WriteLine($"Your starting balance is {firstBal}\n how much would you like to deposit");

            //string tempBal = ReadLine();

            bankBal = Convert.ToDouble(ReadLine());

            startBal = firstBal + bankBal;

            WriteLine($"Your new balance is {startBal} " );            
            

     

           
            for (rate = START_INT; rate <= LAST_INT; rate += INT_INCREASE)
            {
                bankBal = startBal;
                WriteLine($"Starting Bank Balance is {bankBal.ToString("C")} ");
                WriteLine($"Interest Rate: {rate.ToString("p")}");
                for (year = 1; year <= END_YEAR; ++year) 

                {
                    bankBal = bankBal + bankBal * rate;
                    WriteLine($"After year {year}, Bank Balance is {bankBal.ToString("C")}");
                }
               

            }
            ReadKey();

 





        }
    }
}
