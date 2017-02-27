using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugEx2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, bossName;
            Boolean areNamesTheSame;
            WriteLine("Enter your name");
            name = ReadLine();
            WriteLine($"Hello {name}! Enter the name of your boss");
            bossName = ReadLine();
            areNamesTheSame = name == bossName;
            WriteLine($"It is {areNamesTheSame} that you are your own boss");


        }
    }
}
