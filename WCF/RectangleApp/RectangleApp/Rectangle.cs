using System;
using static System.Console;


namespace RectangleApp
{
    class Rectangle
    {

        //variables
        double length;
        double width;

        public void AcceptDetails()
        {
            length = 4.5;
            width = 3.5;
        }


        public double GetArea()
        {
            return length * width;
        }



        public void Display()
        {
            WriteLine("Length : {0}", length);
            WriteLine("Width : {0}", width);
            WriteLine("Area : {0}", GetArea());
            ReadKey();

        }
            //Console.WriteLine("what's the best kind of sandwich");

            //string words = Console.ReadLine();

        


        class ExecuteRectangle
        {
            static void Main(string[] args)

            {

                Rectangle show = new Rectangle();

               
                //show.GetArea();
                show.AcceptDetails();
                show.Display();
                ReadKey();


                Console.WriteLine("what's the best kind of sandwich");

                string words = Console.ReadLine();
            }
        }

        public void Car()
        {
            Console.WriteLine("Do u like bowling??");

            string bowl = Console.ReadLine();

            Console.WriteLine($"Your answer was {bowl} means that u r a sissy!!!  a BIG SISSY");
        }

    }
}
