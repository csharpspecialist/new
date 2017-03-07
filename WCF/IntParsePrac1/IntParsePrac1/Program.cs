using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace IntParsePrac1
{
    class Program
    {
        static void Main(string[] args)
        {

            string entry;
            int score;

            Console.WriteLine("Enter your test Score");

            entry = Console.ReadLine();

            score = int.Parse(entry);

            Console.WriteLine($"you entered {score}");

            ReadKey();
            // just created this to try it out...it does not do much




        }
    }
}
