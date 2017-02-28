using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace WhileByHand2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int newNum;

            int guessCount = 1;

            int mysteryNem = rnd.Next(1, 21);
            WriteLine("You are Playing...Guess the mystery # \n Guess between 1 and 21");

            newNum = Convert.ToInt16(ReadLine());

            while(newNum != mysteryNem)
            {
                Console.WriteLine($"Your guess of {newNum} was not the correct Guess \n Guess again");
                newNum = Convert.ToInt16(ReadLine());
                guessCount++;
                 
            }
            WriteLine($"U Guessed the mystery # of {mysteryNem}!! \n U R a Winna!!!");
            WriteLine($"U Guessed {guessCount} Times");
            ReadLine();



        }
    }
}
