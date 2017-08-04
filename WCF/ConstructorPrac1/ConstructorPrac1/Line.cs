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

        public static string GetData()
        {
            return "Dude...Whatever";
            

        }

  

        static void Main(string[] args)
        {
            string dw = GetData();
            Console.WriteLine(dw);
            Line game = new Line(); //the constructor is called right here!!!!!
            //before anything else!!!!!
            game.SetLength(6.0);
            WriteLine($"Length of the line is {game.GetLength()}");
            WriteLine($"Length of the line is {game.length}");

            Console.ReadLine();
            Console.WriteLine("");
            ReadKey();
        }

        /*only 1 destructor per class.
         * they are used to destroy instances of classes
         * they are only used with classes.
         * they cannot be inherited or overloaded
         * they cannot be called nor invoked. invoking is done automatically.
         * they cannot take modifiers or have parameters.
         * start with the ~ (tilda), must match the name of the class being destroyed
         * demonstration below
         * 
         * */
        ~Line()
        {
            System.Diagnostics.Trace.WriteLine("We are cleaning up our resources now!!!!");
            Console.ReadKey();
        }
        
    }
}
