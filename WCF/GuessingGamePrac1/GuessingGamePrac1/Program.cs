using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace GuessingGamePrac1
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            p.Game();
    
        }

        public void Game()
        {

            Random rand = new Random();

            int magicNum = rand.Next(1, 21);

            WriteLine("Guess the Magic # between 1 and 21");

            int guessNum = Convert.ToInt16(ReadLine());
            int guessCount = 1;

            while (guessNum != magicNum)
            {

                WriteLine($"Your guess of {guessNum} was not the Magic number \n guess again");
                guessNum = Convert.ToInt16(ReadLine());
                guessCount++;

            }

            WriteLine($"You guessed the Magic # of {magicNum} \n U R a Winna!! \n"
                + $"You guessed {guessCount} times");
            
            WriteLine("Would you like to play again??? \n  Y for Yes or N for No" );

           
            string ans = ReadLine().ToUpper();            

            if (ans == "Y" || ans == "YES")
            {
                Main();
            }
            else
            {
                Console.WriteLine("Have a nice day!!!!");
                Environment.Exit(0);
            }
            
        }      
      
    }
}
