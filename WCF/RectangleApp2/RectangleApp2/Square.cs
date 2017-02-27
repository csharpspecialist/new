using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApp2
{
    class Square : BaseMath
    {

        public void SquareVal()
        {
            //needs to accept 2 values
            AcceptValues();
           
            WriteLine($"The area of the Square is {area}");
        
            SquarRt();

            WriteLine($"The square root of the Square is {squareRtValue}");
            ReadKey();
        }


    }
}
