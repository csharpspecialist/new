using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGameTryParsePrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int guessCounter = 1;

            int numChoice;

            int mysteryNum = rand.Next(1,21);

            Console.WriteLine("Welcome to the Guessing Game \n " +
              "Enter a # between 1 and 21");

            do
            {
                //Console.WriteLine("Welcome to the Guessing Game \n " + 
                //"Enter a # between 1 and 21");

            string choice = ReadLine();

            while (!int.TryParse(choice, out numChoice) || numChoice < 1 || numChoice > 21)
            {
                Console.WriteLine("Invalid choice...please choose a valid # between 1 and 21");
                choice = ReadLine();
                    //++guessCounter;

            }
          
                if (numChoice == mysteryNum)
                {
                    Console.WriteLine($"You Guessed the Mystery # of {mysteryNum}...you won!!!!");
                    Console.WriteLine($"You guessed {guessCounter} times");
                }
                else
                {
                    Console.WriteLine("Not the correct # guess again");
                }

                ++guessCounter;
            } while (numChoice != mysteryNum);

            ReadKey();            

        }
    }
}
