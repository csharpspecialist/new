using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace OutputParamPrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            
            //numA and numB must be initialized with a value or this will not work!!!
            int numA = 0, numB = 0;            

            Console.WriteLine($"The initial value of num a and num b are {numA} and {numB}");

            p.Mult(out numA, out numB);

            Console.WriteLine(numA);

            Console.WriteLine(numB);

            ReadLine();
        }


        public void Mult(out int gnum, out int tNum )
        {
            Console.WriteLine("This ");
             gnum =  10;

            tNum = 20;


        }


    }
}
