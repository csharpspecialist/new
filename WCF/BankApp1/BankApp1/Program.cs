using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp1
{
     class Program
    {
        int balance = 500;
        int updatedBalance;

        static void Main(string[] args)
        {
            Program now = new Program();
            now.Start();

        }

        public void Start()
        {
            Program p = new Program();

            Console.WriteLine("Your balance is $500... \n " +
                 "would you like to do \n 1.Deposit \n 2.Withdraw \n 3.Check Balance");
            int numchoice = Convert.ToInt32(Console.ReadLine());

            switch (numchoice)
            {
                case 1:
                    p.Deposit();
                    break;
                case 2:
                    p.Withdraw();
                    break;
                case 3:
                    p.CBalance();
                    break;

                default:
                    Console.WriteLine("You did not choose a valid choice" +
                        "\n Would you like to start use the banking app");
                    string again = Console.ReadLine();


                    p.Start();

                    Console.ReadKey();
                    break;



            }
        }

        private void Deposit()
        {
           
            Console.WriteLine($"How much would you like to deposit??");
            int bAmount = Convert.ToInt16(Console.ReadLine());
            updatedBalance = balance + bAmount;

            if(bAmount <= 0)
            {
                Console.WriteLine("You need to enter a positive amount or get lost!!! ");
            }

            Console.WriteLine($"Your new balance is {updatedBalance}");
            Console.ReadLine();
        }



        private void Withdraw()
        {
            int wAmount;
            Console.WriteLine($"How much would you like to withdraw??");
            string withdrawal = Console.ReadLine();
            int.TryParse(withdrawal, out wAmount);

            updatedBalance = balance - wAmount;
            if (wAmount >= 0)
            {
                Console.WriteLine($"Your new balance is {updatedBalance}  ");
            }
            else
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }
            Console.ReadLine();
        }

        private void CBalance()
        {
           
            Console.WriteLine($"Your account has {updatedBalance} in it ");
            Console.ReadKey();
        }

        public void StartAgain()
        {
            Program p = new Program();

            Console.WriteLine("Would you like to start the banking app over?? " +
                " \n Y or Yes \n N or no");
            string overAns = Console.ReadLine();

            switch (overAns)
            {
                case "Y":
                    p.Start();
                    break;



                default:
                    Console.WriteLine("Thanks for using our application");
                    Console.WriteLine("Have a nice day...\n Press any Key to continue");
                    break;
            }




        }

     

    }




}
