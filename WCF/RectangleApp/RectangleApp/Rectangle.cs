using System;
using static System.Console;


namespace RectangleApp
{
    public class Rectangle : Dealership  //inheriting from dealership class
    {
             
        
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
            //use of string interpolation
            WriteLine($"Length : {length}");
            WriteLine($"Width : {width}");
            WriteLine($"Area : {GetArea()}");
              ReadKey();

        }
            //Console.WriteLine("what's the best kind of sandwich");

            //string words = Console.ReadLine();                  
            
        class ExecuteRectangle

            
        {
            static void Main(string[] args)

            {

                //WriteLine("give me an integer");

                //double integerNum = Convert.ToDouble(ReadLine().ToUpper());

                Rectangle show = new Rectangle();

                //show.GetArea();
                Dealership now = new Dealership();
                Triangle tr = new Triangle();
               
                ///show.InsertValues(); //called first
              //  show.Display();//called 2nd
                //now.List(); //called 3rd
                //show.Bossman();
               // show.Miles();
                //ReadKey();
                tr.ShowEverything();

                //tr.AcceptValues();

               
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

            //string carAns = ReadLine();
            //int car = int.Parse(carAns);

            //code below combines the above 2 lines of code into 1
            int car = int.Parse(ReadLine());
            

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
