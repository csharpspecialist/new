﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApp2
{
    class Octagon : BaseMath
    {
        public void EightValue()
        {

            AcceptValues();
            SquarRt();
            WriteLine($"The area of the Octagon is {area}");
            WriteLine($"The square root of the Octagon is {squareRtValue}");
            ReadKey();

        }
        

    }
}