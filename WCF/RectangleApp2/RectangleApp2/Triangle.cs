using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp2
{
    class Triangle : BaseMath
    {
        BaseMath b = new BaseMath();

        public void ShowEverything()
        {
            AcceptValues();

            WriteLine($"The area of the Triangle is {area}");

            SquarRt();

            WriteLine($"The square root of the Triangle is {squareRtValue}");
            ReadKey();

            b.Thanks();
        }

    }
}
