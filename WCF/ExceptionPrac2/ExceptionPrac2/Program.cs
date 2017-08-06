using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExceptionPrac2
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            //  p.GasException();

           // p.Excepdual();

               p.FirstTry();

            Console.WriteLine("The program just kept going \n" +
                "This is a good thing!!!");

            ReadLine();
        }

        public void IntException()
        {
            //this one blows up on purpose!!!!!!
            int answ;
            int res;
            int zero = 0;
            Console.WriteLine("Enter an integer");
            answ = Convert.ToInt16(ReadLine());

            res = answ / zero;

            Console.WriteLine($"The answer is {answ} ");

        }

        public void GasException()
        {
            int milesDriven;
            int galsGas;
            int mpg;

            //this one blows up on purpose also!!!!!!

            Console.WriteLine("Enter miles driven");
                milesDriven = Convert.ToInt16(ReadLine());

                Console.WriteLine("Enter gallons of gas used");
                galsGas = Convert.ToInt16(ReadLine());
                mpg = milesDriven / galsGas;                    

            Console.WriteLine($"Your car gets {mpg} miles per gallon");
            ReadLine();            

        }

        public void FirstTry()
        {
            int milesDriven;
            int galsGas;
            int mpg;

            try
            {

                Console.WriteLine("Enter miles driven");
                milesDriven = Convert.ToInt16(ReadLine());

                Console.WriteLine("Enter gallons of gas used");
                galsGas = Convert.ToInt16(ReadLine());
                mpg = milesDriven / galsGas;

            }

            catch (Exception e)
            {
                mpg = 0;
               
                //below is a pre-written message 
                // that says u tried to divide by zero!!
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Your car gets {mpg} miles per gallon");
            ReadLine();            

        }

        public void Excepdual()
        {
            int num = 11, denom = 0, result;

            int[] arry = { 2, 5, 10 };

            try
            {
                result = num / denom;
                result = arry[num];
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("We r in the Divby0 catch block!!");
                Console.WriteLine(d.Message);
            }
            catch (IndexOutOfRangeException i)
            {
                Console.WriteLine("In the Index catch block");
                Console.WriteLine(i.Message);
            }

            Console.WriteLine("Game over...we survived!!!!");
            ReadLine();


        }


    }
}
