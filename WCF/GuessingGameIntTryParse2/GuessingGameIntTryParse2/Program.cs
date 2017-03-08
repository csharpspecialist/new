using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGameIntTryParse2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int mystNum = rand.Next(1, 21);

            int realGuess;

            Console.WriteLine("Guess the magic # between 1 and 21");
            string stringGuess = Console.ReadLine();

           while(!int.TryParse(stringGuess ,out realGuess))
            {
                Console.WriteLine("We don't recognize your entry \n" +
                    "Guess the magic # between 1 and 21");
                stringGuess = Console.ReadLine();

            }


         

        }
    }
}
