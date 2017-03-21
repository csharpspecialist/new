using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ExceptionPrac1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Program p = new Program();
             string year = DateTime.Now.Year.ToString();

            //p.GetMpg1();
            Console.WriteLine($"The year is {year}");
            p.GetMpg2();
            p.GetMpg3();

        }

        public void GetMpg1()
        {
            int milesGal;
           
            Console.WriteLine("Enter miles driven");
            int milesDriven = Convert.ToInt16( ReadLine());

            Console.WriteLine("Enter gallons of gas used");
            int galsUsed = Convert.ToInt16(ReadLine());

            //this one uses an if statement to handle the div by 0 exception
            if (milesDriven != 0 || galsUsed != 0)
            {
               milesGal = milesDriven / galsUsed;
            }
            else
            {
                milesGal = 0;
            }

            Console.WriteLine(milesGal);
            ReadLine();

        }

        public void GetMpg2()
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

            catch(Exception)
            {//this one uses the exception method w/o a letter after it above
                mpg = 0;
                Console.WriteLine("You attempted to divide by zero");
            }                  

            Console.WriteLine(mpg);
            ReadLine();

        }

        public void GetMpg3()
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
            {//this one uses the built in e.message 
                mpg = 0;
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(mpg);
            ReadLine();

        }
    }
}
