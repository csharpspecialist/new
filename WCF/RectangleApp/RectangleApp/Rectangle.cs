﻿using System;
using static System.Console;


namespace RectangleApp
{
    class Rectangle
    {
        Dealership sgo = new Dealership();                
              
        //variables
        double length;
        double width;

        public void InsertValues()
        {
            length = 4.5;
            width = 3.5;
        }

        public double GetArea()
        {
            return length * width;
        }



        public void Display() //called 2nd
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
                Dealership now = new Dealership();
                
              
                show.InsertValues(); //called first
                show.Display();//called 2nd
                now.List(); //called 3rd
                show.Bossman();
                show.Miles();
                ReadKey();
                


               
            }
        }

        public void Car() //called 4th
        {
             WriteLine("Do u like bowling??");

            string bowl = ReadLine();

             WriteLine($"Your answer was {bowl}...that means that u r a sissy!!! \n a BIG SISSY");
        }

        public void Bossman()
        {
             WriteLine("How many cars have u owned??");

            string carAns = ReadLine();

            int car = int.Parse(carAns);

            string crush = (car < 5) ? "U r a Whippersnapper!!!" : "U r just getting revved Up!!!";
            WriteLine(crush);

            WriteLine("*****************");
            WriteLine("Do U Like Chess??");

            string gameAns = ReadLine().ToUpper();            

            string playa = (gameAns == "YES") ?
                "You know what time it is!!!" :
                "U Don't have a clue";
            WriteLine(playa);
            WriteLine("This is a wrap!!!!");
        }

        public void Miles()
        {
            string name, bossName;
            Boolean areNamesTheSame;
            WriteLine("Enter your name");
            name = ReadLine();
            WriteLine($"Hello {name}! Enter the name of your boss");
            bossName = ReadLine();
            areNamesTheSame = name == bossName;
            WriteLine($"It is {areNamesTheSame} that you are your own boss");
        }


    }
}
