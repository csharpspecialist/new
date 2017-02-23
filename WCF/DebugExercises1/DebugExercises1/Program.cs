using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugExercises1
{
    class Program
    {
        static void Main(string[] args)

        {
            Program p = new Program();

            p.Caller();

        }
        public void Caller()
        {
            One1();
            One2();
            One3();
            One4();

        }

        public static void One1()
        {
            WriteLine("Mary had a little lamb");
            WriteLine("Its fleece was white as snow");
            WriteLine("And everywhere that Mary went");
            WriteLine("The lamb was sure to go");


            ReadKey();
        }


        //Filename DebugOne2.cs
        // This program outputs a large C#
        public static void One2()
        {
            WriteLine("CCCCC   #  #");
            WriteLine("C     ########");
            WriteLine("C       #  #");
            WriteLine("C     ########");
            WriteLine("CCCCC   #  #");


            ReadKey();
            Console.WriteLine("This one is done Also!!!");
            ReadKey();

        }

        public static void One3()
        {

            WriteLine("Take Highway 51 north");
            WriteLine("Exit at County Road H");
            WriteLine("Go three blocks and make a right on School Street");
            WriteLine("Go right at Elm");
            WriteLine("Party is four houses down on the left");

            ReadKey();
            Console.WriteLine("This one is done Too!!!");
            ReadKey();
        }

        public static void One4()
        {
            WriteLine("Spinach dip:");
            WriteLine();
            WriteLine("1 package frozen chopped spinach");
            WriteLine("1 cup mayonnaise");
            WriteLine("1 chopped onion");
            WriteLine("Onions Taste Like Dirt!!!! Cold Dirt At That!!!");
            WriteLine("Mix ingredients together.");
            WriteLine("Chill and serve with chips.");



            ReadKey();

            WriteLine("That's All Folks!!!");

            ReadKey();


            {

            }


        }
        public void Two1()
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



        public void Two2()
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


        // This program computes net weekly pay
        // based on hours worked, rate per hour,
        // and 15% withholding

        public void Two3()
        {
            const double WITHHOLDING_RATE = .15;
            string hoursAsString, rateAsString;
            double hours, rate;
            double gross, net;
            //************************************************************

            Write("Enter the number of hours you worked this week ");
            hoursAsString = ReadLine();

            //************************************************************

            Write("Enter your hourly rate ");
            rateAsString = ReadLine();

            //************************************************************

            hours = Convert.ToDouble(hoursAsString);
            rate = Convert.ToDouble(rateAsString);

            //************************************************************


            gross = hours * rate;
            net = gross - WITHHOLDING_RATE;

            WriteLine($"You worked {hours} hours at {rate} per hour",
            hours, rate.ToString("C"));
            WriteLine("Gross pay is {0}", gross.ToString("C"));
            WriteLine("Net pay is {0}", net.ToString("C"));
        }

        public void Two4()
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
