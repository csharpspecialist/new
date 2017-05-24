using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExcepPrac3
{
    class Program
    {
        static void Main()
        {
            Program er = new Program();

           // er.Error1();
            er.ArrayError();

        }



        public void Error1()
        {


            int milesDriven;
            int gallonsOfGas;
            int mpg;
            try
            {

                Console.WriteLine("Enter # of miles Driven");

                milesDriven = Convert.ToInt16(ReadLine());
                WriteLine("Enter # of Gallons purchased");

                gallonsOfGas = Convert.ToInt16(ReadLine());

                mpg = milesDriven / gallonsOfGas;

                Console.WriteLine($"You get {mpg} Miles Per Gallon");

                ReadLine();
            }
            catch (Exception e)
            {
                mpg = 0;
                Console.WriteLine("You attempted to divide by zero \n"
                    + " We r now in the catch block");


            }
            Console.WriteLine($"You get {mpg} Miles Per Gallon");
            ReadLine();

        }

        public void ArrayError()

        {

            int num = 13, denom = 0, result;
            int[] ar = { 22, 33, 44 };

            try
            {
               // result = num / denom;
                result = ar[num];


            }

            catch(DivideByZeroException error)
            {
                Console.WriteLine("In first catch block");
                Console.WriteLine(error.Message);
            }

            catch(IndexOutOfRangeException er)
            {
                Console.WriteLine("In index out of range error block");
                Console.WriteLine(er.Message);
            }

            ReadLine();
        }


        public void ExcepError()

        {

            int num = 13, denom = 0, result;
            int[] ar = { 22, 33, 44 };

            try
            {
                // result = num / denom;
                result = ar[num];


            }

            catch (Exception error)
            {
                Console.WriteLine("In first catch block");
                Console.WriteLine(error.Message);
            }
            //the code below will never been reached
            //because the exception errro above is is a catch all error!!!

            //catch (IndexOutOfRangeException error)
            //{
            //    Console.WriteLine("In first catch block");
            //    Console.WriteLine(error.Message);
            //}


            ReadLine();
        }



   
        }

    }



    enum cars
    {

        DODGE =1,
        FORD= 2,
        MAZDA = 3,
        JAGUAR = 4,
        MASERATI = 5,
        BMW = 6,


    }

