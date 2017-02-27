using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InheritanceApp
{
    class RectangleTester
    {
        static void Main(string[] args)
        {

            Rectangle r = new Rectangle();

            r.SetWidth(5);
            r.SetHeight(7);
            WriteLine($"Total Area {r.GetArea()} ");
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
