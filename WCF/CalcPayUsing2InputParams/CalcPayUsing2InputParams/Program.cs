using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CalcPayUsing2InputParams
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("How many hours did u work last week??");

            double hoursWorked = Convert.ToDouble(ReadLine());

            Console.WriteLine("What's you hourly pay rate??");

            double payRate = Convert.ToDouble(ReadLine());

            FigureWeeklyPay(payRate, hoursWorked);
        }

        public static void FigureWeeklyPay(double hoursWorked, double payRate)
        {
            //double payRate;
           // double hoursWorked;

            double weeklyPay = payRate * hoursWorked;
            Console.WriteLine($"Your weekly pay is {weeklyPay} which is \n " +
                $"the hours u worked last week, {hoursWorked} times your rate of {payRate} \n");


            WriteLine("Would you like to figure you weekly pay for another week?? \n Y or N \n ");
            string searchAgain = ReadLine().ToUpper();

            if (searchAgain == "Y" || searchAgain == "YES")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Thanks for shopping with us!!! \n Come Again Soon!!");
                Console.WriteLine("Press any key to exit");
                ReadKey();
            }

        }


    }
}
