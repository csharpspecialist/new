using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string love = "We Love Coding";

            string revString = new string(love.Reverse().ToArray());

            Console.WriteLine(revString);

            ReadLine();
        }
    }
}
