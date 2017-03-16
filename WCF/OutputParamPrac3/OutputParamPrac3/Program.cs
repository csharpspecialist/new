using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OutputParamPrac3
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();

            double uno;

            double duo;

             p.FindAns(out uno, out duo);
        }


        public void FindAns(out double first, out double second)
        {
            //you must get the values for the vars from the user inside of this method of
            //fight with this for a long time...U HAVE BEEN WARNED!!!!!
            Console.WriteLine("type in the first # to multiply");

            first = Convert.ToInt16(ReadLine());

            Console.WriteLine("type in the 2nd # to multiply");

            second = Convert.ToInt16(ReadLine());


            double total = 0;
            double INT_RATE = .07;
            double rate = 0;
          

          

            total = first * second;
            rate += total * INT_RATE;
            Console.WriteLine($"The amount of the first value is {first} \n" 
                + $"And the amount of the second value is {second} \n" + 
                $"the total is {total} and the total amount of interest is ${rate}");

            ReadLine();

        }



    }
}
