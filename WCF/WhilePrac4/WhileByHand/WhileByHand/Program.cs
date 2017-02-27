using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WhileByHand
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            

            int guess;
            int winningNum;

            int guessCount = 1;

            winningNum = rand.Next(1, 21);

            WriteLine("Guess the mystery # Here!!!");
            guess = int.Parse(ReadLine());

            while(winningNum != guess)
            {
                WriteLine($"Your guess of {guess} was not the mystery # \n Try again!!!");

                guess = int.Parse(ReadLine());
                guessCount++;

            }

            WriteLine($"You guessed the mystery # of {winningNum}!!! \n  Your are a Winner!!!");

            WriteLine($"You guessed {guessCount} times!!! ");
            ReadLine();
        }
    }
}
