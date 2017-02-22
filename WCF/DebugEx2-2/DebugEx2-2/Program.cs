using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugEx2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string firstString, secondString;
            int first = 10, second = 20, product;
            WriteLine("Enter your name");
            name = ReadLine();
            WriteLine("Hello {0}! Enter an integer", name);
            firstString = ReadLine();
            WriteLine("Enter another integer");
            secondString = ReadLine();
            product = first * second;
            WriteLine("Thank you {1}. The product of {2} and {3} is {4}",
            name, first, second, product);



        }
    }
}
