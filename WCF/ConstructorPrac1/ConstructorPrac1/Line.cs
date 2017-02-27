using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConstructorPrac1
{
    class Line
       
    {

        private double length;  //Length of a line

        public Line()
        {
            WriteLine("The constructor is working now!!!!");
        }

        public void SetLength(double len)
        {
            length = len;
        }

        public double GetLength()
        {
            return length;
        }


        static void Main(string[] args)
        {
            Line game = new Line(); //the constructor is called right here!!!!!
            //before anything else!!!!!
            game.SetLength(6.0);
            WriteLine($"Length of line{game.GetLength()}");
            ReadKey();
        }
    }
}
