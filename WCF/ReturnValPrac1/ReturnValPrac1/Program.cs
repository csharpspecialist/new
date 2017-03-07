using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReturnValPrac1
{
    class Program
    {


     static void Main(string[] args)
        {
            Program p = new Program();
            Work w = new Work();
            Console.WriteLine("enter a height value");

            double num1 = Convert.ToDouble(ReadLine());

            Console.WriteLine("enter a 2nd double value");

            double num2 = Convert.ToDouble(ReadLine());
            double num3;
           // w.GetWidth(num1);
           // w.GetHeight(num2);

            num3 = p.GetAnswer(num1, num2);

            WriteLine($"Total Area {w.RetAns()} ");
            WriteLine("Total area is {0}", num3);
            WriteLine("Total area is {0}", p.GetAnswer(num1, num2));


            ReadKey();
        }

        public double GetAnswer(double val1, double val2)
        {
            double ans = val1 * val2;
            return ans;
        }

        //public double RetAns()
        //{
        //    answ = (val1 * val2);
        //    return answ;
        //}
    }

    class Work
    {

        public double width;
        public double height;

    


        public double RetAns()
        {
           
            return height * width;
        }



    }

}
