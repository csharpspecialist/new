using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGameIntTryParsePrac4
{
    class Program
    {
        static void Main()
        {
            Random rand = new Random();
            Program p = new Program();

            int mysteryN = rand.Next(1, 21);

            int guessCounter = 1;
            int realAns;

            Console.WriteLine("Welcome to the Guessing Game \n" +
                "Enter a # between 1 and 21");

            do
            {

                string answ = ReadLine();

                while (!int.TryParse(answ, out realAns) || realAns < 1 || realAns > 21)
                {

                    Console.WriteLine("Invalid Choice...please enter a # \n" +
                        "Between 1 and 21");

                    answ = ReadLine().ToUpper();
                    guessCounter++;

                }

                if (mysteryN == realAns)

                {
                    WriteLine($"Your guess of {realAns} is correct \n" +
                "U R a Winna!!!! \n " +
                $"You guessed {guessCounter} times");
                }

                else
                {
                    WriteLine($"Your guess of {realAns} was not correct \n" +
             "Guess again");
                    guessCounter++;
                }

            } while (mysteryN != realAns);

            p.Menu();           
            
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
            ReadLine();
            //make sure the main method looks like this   static void Main()
            //and not like this---  static void Main (string [] args)
        }

    }
}
