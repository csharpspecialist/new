using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PracticingByHand
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rgen = new Random();

            int randNum = rgen.Next(1, 21);

            int guess;

            int guessNum = 1;


            WriteLine("Guess the random # between 1 and 20");

            guess = Convert.ToInt16(ReadLine());

            while(randNum != guess)
            {
                WriteLine($"Your guess of {guess} is not the Random # \n Guess again");
                guess = Convert.ToInt16(ReadLine());
                guessNum++;


            }
            WriteLine($"You guess the random # of {randNum} Hooray!!! \n You are a winna!!!");
            WriteLine($"You guessed {guessNum} times");
            ReadKey();


        }
    }
}
