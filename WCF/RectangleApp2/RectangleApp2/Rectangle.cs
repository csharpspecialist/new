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

            WriteLine($"The area of the Rectangle is {area}");

            SquarRt();

            WriteLine($"The square root of the Rectangle is {squareRtValue}");
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
                    s.SquareVal();
                    break;

                case "RECTANGLE":
                    r.RectangleVal();
                    break;

                case "OCTAGON":
                    o.EightValue();
                    break;

                case "TRIANGLE":
                    t.ShowEverything();
                    break;
                default:
                    Write("We don't understand your choice");
                    break;
            }
            Console.WriteLine("Thanks Anyway");
            ReadKey();

        }
    }
}
