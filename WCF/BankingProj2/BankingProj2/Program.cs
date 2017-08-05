using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace BankingProj2
{
    class Program
    {
        static void Main(string[] args)
        {
            Computation c = new Computation();
            double currBalance;
            double BeginCash = 1000;
            int trChoice;
            Console.WriteLine("Welcome to the banking app. Your starting Balance is $1000\n 1. Deposit \n 2. Withdraw \n 3. View Balance");
            string startChoice = Console.ReadLine();
            int.TryParse(startChoice, out trChoice );

            switch (trChoice)
            {
                case 1:
               currBalance = c.Deposit(ref BeginCash);
                    c.RunAgain(ref currBalance);
                    break;
                
                default:
                    break;
            }

          

        }

    }
}
