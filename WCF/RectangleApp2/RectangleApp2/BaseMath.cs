using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleApp2
{
    class BaseMath
    {

        public double length;
        public double width;
        public double area;
        public double squareRtValue;


        public double AcceptValues()
        {
            WriteLine($"Enter the length ");

            length = Convert.ToDouble(ReadLine());

            WriteLine($"Enter the width ");

            width = Convert.ToDouble(ReadLine());

            return area = length * width;
        }

        public double SquarRt()
        {
            //double squareRtValue =   Math.Sqrt(area);
            return squareRtValue = Math.Sqrt(area);
        }

        public void Thanks()
        {
            WriteLine("Thanks for using our fine program");
            ReadKey();
        }

        public void WhatEver()
        {
            WriteLine("For which shape do u need to find the area ");
            ReadKey();
        }

    }
}
