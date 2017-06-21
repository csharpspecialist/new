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
            int newBal = balance + bAmount;

            if(bAmount <= 0)
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }

            Console.WriteLine($"Your new balance is {balance}");
            Console.ReadLine();
        }



        private void Withdraw()
        {
            
            Console.WriteLine($"How much would you like to withdraw??");
            int wAmount = Convert.ToInt16(Console.ReadLine());
            int newBal = balance - wAmount;
            if (wAmount <= 0)
            {
                Console.WriteLine("You need to enter a positive amount or beat it!!! ");
            }

        }

        private void CBalance()
        {
           
            Console.WriteLine($"Your account has {balance} in it ");
            Console.ReadKey();
        }

     

    }




}
