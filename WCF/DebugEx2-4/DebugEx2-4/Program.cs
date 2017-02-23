using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugEx2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string entry;
            int enteredInteger;
            int more;
            int less;
            Write("Enter an integer ");
            entry = ReadLine();
            WriteLine($"You entered {entry}");
            enteredInteger = Convert.ToInt32(entry);
            more = enteredInteger + 1;
            less = enteredInteger - 1;
            WriteLine($"One more than {enteredInteger} is {more} and one less than {enteredInteger} is {less}");


        }
    }
}
