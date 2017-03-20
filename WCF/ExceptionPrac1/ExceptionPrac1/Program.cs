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
          

            //p.GetMpg1();

            p.GetMpg2();

        }

        public void GetMpg1()
        {
            int milesGal;
           
            Console.WriteLine("Enter miles driven");
            int milesDriven = Convert.ToInt16( ReadLine());

            Console.WriteLine("Enter gallons of gas used");
            int galsUsed = Convert.ToInt16(ReadLine());

            
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
            {
                mpg = 0;
                Console.WriteLine("You attempted to divide by zero");
            }


            //if (milesDriven != 0 || galsUsed != 0)
            //{
            //    milesGal = milesDriven / galsUsed;
            //}
            //else
            //{
            //    milesGal = 0;
            //}

            Console.WriteLine(mpg);
            ReadLine();

        }


    }
}
