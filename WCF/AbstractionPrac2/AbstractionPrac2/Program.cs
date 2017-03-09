using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AbstractionPrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pepsi food = new Pepsi();

            Console.WriteLine(food.Softdrink());
            ReadKey();
        }
    }


    abstract class Fastfood
    {

        abstract public string Softdrink();
        //above cannot have curly braces after it or anything else!!!
       //just write the abstract method just like this above!!!!
    }

    class Pepsi : Fastfood //you must inherit from Fastfood 
        //in order for this to work!!!!

    {

        public override string Softdrink() 
        {//must be override then data type above!!!!

            string pop = "Code Red";
            return pop;
        }

    }

}

