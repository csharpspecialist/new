using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApp2
{
    class Rectangle :BaseMath
    {

        public void RectangleVal()
        {
            AcceptValues();
            SquarRt();
            WriteLine($"The area of the Square is {area}");
            WriteLine($"The square root of the Square is {squareRtValue}");
            ReadKey();

        }        

        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Square s = new Square();
            Octagon o = new Octagon();
            Triangle t = new Triangle();


            WriteLine("Which shape would you like to find the value of??");

            string shape = ReadLine().ToUpper(); 


            switch (shape)
            {
                case "SQUARE":
                    s.AcceptValues();
                    break;

                case "RECTANGLE":
                    r.AcceptValues();
                    break;

                case "OTAGON":
                    o.AcceptValues();
                    break;

                case "TRIANGLE":
                    t.AcceptValues();
                    break;
                default:
                    Write("We don't understand your choice");
                    break;
            }

        }
    }
}
