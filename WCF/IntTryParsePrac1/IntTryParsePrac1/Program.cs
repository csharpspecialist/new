using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IntTryParsePrac1
{
    class Program
    {
        static void Main(string[] args)
        {

            string entry;
            int score;

            Console.WriteLine("Enter your test Score");

            entry = Console.ReadLine();

            int.TryParse(entry, out score);

            Console.WriteLine($"you entered {score}");

            ReadKey();
            // the above code block does not really do too much
            //better code is below
            //----------------------------------------------------------------

            string typing;
            int numbers;

            Console.WriteLine("Enter your test Score");


          
            typing = Console.ReadLine();

            while (!int.TryParse(typing, out numbers))
            {
                Console.WriteLine($"please enter a valid test score \n" + 
                    "That was not a valid test score");
                typing = Console.ReadLine();

            }

            Console.WriteLine("You finally choose a valid test score");
           

            ReadKey();







        }
    }
}
