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

            Program z = new Program();
            //Prof();
            z.RainMan(10);
            Prof();
        }

        int value = 5;
        public int RainMan(int value)
        {

            return this.value;
            
        }


        public static void Prof()
        {
            WriteLine("You Drew first Blood!!!");
            ReadKey();

        }

    }
}
