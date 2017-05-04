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

        static void Main()
        {
            
            Rectangle r = new Rectangle();
            Square s = new Square();
            Octagon o = new Octagon();
            Triangle t = new Triangle();
            BaseMath b = new BaseMath();
            

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
                    Write("We don't understand your choice   ");
                    break;
            }
            r.Menu();
            //WriteLine("Exiting the program Now!!!");
            //ReadKey();

        }


        public void Menu()
        {
            Console.WriteLine("  Would You Like To Try Again?? \n \n" +
                "Y   or   N \n");
            string answ = Console.ReadLine().ToUpper();


            if (answ == "Y")
            {
                Main();
            }
            else
            {
                Console.WriteLine(" \n Thanks for using our program!!");
            }

            //make sure the main method looks like this   static void Main()
            //and not like this---  static void Main (string [] args)
        }
    }
}
