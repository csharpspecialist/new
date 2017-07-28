using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReturnValueWorking
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            Console.WriteLine("Enter the width of your rectangle");

            int width = Convert.ToInt16(ReadLine());

            Console.WriteLine("Enter the height of your rectangle");

            int height = Convert.ToInt16(ReadLine());


            r.SetWidth(width);
            r.SetHeight(height);
           //calling the method below!!!  Works like it should
            WriteLine($"Total Area {r.GetArea()} ");
            //Save yourself headaches....make sure that you do the work
            //insIde of the method...not here in the main method!!!!ALWAYS!!!
            ReadKey();

        }
    }
    //Base class shape below
    class Shape
    {
        protected int width;
        protected int height;
        public void SetWidth(int w)
        {
            width = w;

        }
        public void SetHeight(int h)
        {
            height = h;
        }
    }






    //derived class below named Rectangle
    class Rectangle : Shape
    {
        public int GetArea()
        {
            return (width * height);
        }
    }
}
