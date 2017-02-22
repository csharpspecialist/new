using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using the line below aleviates the need to 
// write Console everytime we write or read 
//from the console!!!
using static System.Console;
 

namespace HelloWorldGreat___
{
    class Program

    {
        static void Main(string[] args)
        {
            WriteLine("Do u like Sports");

            string dog = ReadLine().ToUpper();

            if (dog == "YES")
            {
                WriteLine($"Your answer of {dog} means that U R A Man's Man!!!");
            }
            else if (dog == "NO")
            {
                WriteLine($"Your answer of {dog} means that U R A Girlie Man!!!");
            }
            else
            {
                WriteLine($"We don't understand your answer of {dog}!!");
            }
            ReadLine();

            WriteLine("What kind of car do you drive ");

            string what = ReadLine().ToUpper();

            string dude = (what == "INFINITI") ? "U R a Great person" : "U Don't know anything";

            WriteLine(dude);

            ReadLine();

            Green();

        }



        public static void Green()
        {
            WriteLine("Today is the 2md day of ");
            ReadKey();
        }
    }
}
