﻿using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp2
{
    class Triangle : BaseMath
    { 
      
      
        public void ShowEverything()
        {
            AcceptValues();
            SquarRt();
            WriteLine($"The area of the Triangle is {area}");
            WriteLine($"The square root of the Triangle is {squareRtValue}");
            ReadKey();
        }

    }
}