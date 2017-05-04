using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApp2
{
    class Octagon : BaseMath
    {
        BaseMath b = new BaseMath();
        public void EightValue()
        {

            InputVals();

            WriteLine($"The area of the Octagon is {area}");

            SquarRt();

            WriteLine($"The square root of the Octagon is {squareRtValue}");
            ReadKey();

           // b.Thanks();

        }             

        public double InputVals()
        {
            WriteLine($"Enter the length of 1 side of the Octagon ");

            length = Convert.ToDouble(ReadLine());                          

            return area = (2 * (1 + Math.Sqrt(2)) * Math.Pow(length, 2));
        }
        


    }
}
