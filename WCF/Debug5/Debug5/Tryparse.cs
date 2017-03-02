using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debug5
{
    class Tryparse
    {

        public void Example()
        {

            Random rand = new Random();

            int mysteryNum = rand.Next(1, 21);

            bool goodOrBad = false;

            int guessNum;

            int countOfGuesses = 1;
            

            WriteLine("Enter a # between 1 and 21 ");

            string number = ReadLine().ToUpper();

            goodOrBad = int.TryParse(number, out guessNum);


            while (goodOrBad == false || guessNum != mysteryNum )
            {
                WriteLine($"Your guess of {guessNum} was not the mystery number \n  Try again ");
                number = ReadLine().ToUpper();
                goodOrBad = int.TryParse(number, out guessNum);
                countOfGuesses++;
            }
            Console.WriteLine($"You guessed the mystery # of {mysteryNum} \n  You are a Winner!!! \n You guessed {countOfGuesses} times");
            ReadKey();
        }


    }
}
