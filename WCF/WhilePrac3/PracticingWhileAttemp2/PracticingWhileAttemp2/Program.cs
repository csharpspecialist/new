using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PracticingWhileAttemp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();

            int rnum = rand.Next(1, 21);
            
            int guess;

            int guessNum = 0;
            WriteLine("Enter a guess between 1 and 20");
            guess = Convert.ToInt16(Console.ReadLine());
            while(guess != rnum)
            {
                WriteLine($"Your guess of {guess} is not the correct # \n Guess again");
                guess = Convert.ToInt16(Console.ReadLine());

                guessNum++;

            }
            WriteLine($"Your guess of {rnum} was correct!!!");
            WriteLine($"You guessed {guessNum} times");
            ReadLine();
        }
    }
}
