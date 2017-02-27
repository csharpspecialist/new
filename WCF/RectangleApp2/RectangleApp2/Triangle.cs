using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp2
{
    class Triangle
    { 


        double trLength;
        double trWidth;
        double area;
        double squareRtValue;


        public double AcceptValues()
      {
        WriteLine($"Enter the {trLength} of the triangle ");

        trLength = Convert.ToDouble(ReadLine());

        WriteLine($"Enter the {trWidth} of the triangle ");

        trWidth = Convert.ToDouble(ReadLine());

        return area = trLength * trWidth;
      }


        public double Squaring()
        {
            //double squareRtValue =   Math.Sqrt(area);
            return squareRtValue = Math.Sqrt(area);
        }

        public void ShowEverything()
        {
            AcceptValues();
            Squaring();
            WriteLine($"The area of the Triangle is {area}");
            WriteLine($"The square root of the Triangle is {squareRtValue}");
            ReadKey();
        }

    }
}
