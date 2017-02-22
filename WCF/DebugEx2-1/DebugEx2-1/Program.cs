using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace DebugEx2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Whatever";
            string bossName = "Dude";
            Boolean areNamesTheSame;
            WriteLine("Enter your name");
            name = ReadLine();
            WriteLine("Hello {0}! Enter the name of your boss", name);
            name = ReadLine();
            areNamesTheSame = (name == bossName);
            WriteLine("It is {0} that you are your own boss", areNamesTheSame);
        }
    }
}
