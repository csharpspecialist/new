using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayPassingToAnotherMethodParams
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Mark", "James", "Maria", "Carl", "Frieda", };
            DisplayStrings("Ginger"); //choose any name you want here!!!
            DisplayStrings("Dare Devil", "Spider" , "Thor");  //choose any name you want here!!!
            DisplayStrings("Electra");  //choose any name you want here!!!
            DisplayStrings(names);
            ReadKey();

        }

        private static void DisplayStrings(params string[] names)
        {
            foreach (string name in names)
            {
                Console.Write(name);
                WriteLine("\n-------------------");
            }
        }

    }
}
