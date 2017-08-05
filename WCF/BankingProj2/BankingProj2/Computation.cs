using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProj2
{
    class Computation
    {
        

        public  double Deposit(ref double tempBalance)
        {
            Computation c = new Computation();
            double currentBalance;
            Console.WriteLine("What amount would you like to deposit??");
            string tempDep = Console.ReadLine();
            double.TryParse(tempDep, out currentBalance );          
            currentBalance += tempBalance;


            return currentBalance;

        }

        public double RunAgain(ref double transBalance)
        {
            Computation c = new Computation();
            double direction;
            Console.WriteLine($"Your current balance is {transBalance} \n Would you like to \n 1. Make a deposit \n 2. Make a withdrawal \n 3. Exit the program");
            string tempDecison = Console.ReadLine();
            double.TryParse(tempDecison, out direction  );

            switch (tempDecison)
            {
               case "1":
                    c.Deposit(ref transBalance);
                    break;

                case "2":
                    c.Deposit(ref transBalance);
                    break;

                case "3":
                    c.Deposit(ref transBalance);
                    break;
                default:
                    Console.WriteLine("See Ya later");
                    break;
            }


            return transBalance;
        }


    }
}
