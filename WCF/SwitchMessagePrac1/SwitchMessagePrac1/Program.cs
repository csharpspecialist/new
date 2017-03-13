using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SwitchMessagePrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] realNums = { 1, 2, 3, 4, 5 };

            for (int z = 0; z < realNums.Length; z++)
            {
                Console.WriteLine(realNums[z]);
            }

            ReadKey();

            Console.WriteLine("Which Sport is the best");

            string message = "";

            string player = ReadLine().ToUpper();

            switch (player)
            {
                
                case "FOOTBALL":
                    message = "Best Sport on the planet";
                    break;

                case "BASKETBALL":
                    message = "It's  a man's Sport Too";
                    break;
                case "SOCCER":
                    message = "Biggest Sport in the world";
                    break;
                case "BADMITTEN":
                    message = "Whatever!!!";
                    break;
                case "HOCKEY":
                    message = "I was watching a fight once... \n " + 
                        "A Hockey game broke out!!!";
                    break;

                default:
                    message = "That sport does not exist here";
                    break;
            }

            Console.WriteLine(message);
            ReadLine();
        }
    }
}
