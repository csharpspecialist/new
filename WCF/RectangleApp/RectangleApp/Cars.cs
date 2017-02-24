using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApp
{
    class Dealership
    {            

        public void List() //called 3rd
        {
            WriteLine("which vehicle is your favorite");
            string fav = ReadLine().ToUpper();
                 
            switch (fav)
            {
                case "NISSAN":
                    WriteLine("Nissan's are A OK");
                    break;
                case "CHEVY":
                    WriteLine("Heavy Chevy's..Still In Style");
                    break;

                case "DODGE":
                    WriteLine("These are Car Classics");
                    break;

                case "FORD":
                    WriteLine("Still Found on road DEAD!!!");
                    break;

                default:
                    WriteLine("That Vehicle is for Sissies!! \n ************");
                    break;                    
                   
            }

            Rectangle dog = new Rectangle();
            dog.Car(); //called 4th
            Detailers spree = new Detailers();

            WriteLine("I am thinking of a magic #");
            string mnum = Console.ReadLine();
            
            int newMNum = Convert.ToInt32(mnum);
            int guess = 10;
            string answer = (newMNum == guess) ? "U r great!!!" : "Your name is muDD!!!";
            
            WriteLine(answer);
        }
         
        //I cannot call any code that is written
        //here for some reason
        class Detailers
        {
            public void Specials()
            {

            }


            public void Mass()
            {
                int wimpy = 22;
                int glee = 55;
               // string igloo = "Clue";

                string food = ReadLine().ToUpper();

                string dude = (glee > wimpy) ? "Cool" : "Not cool";

                WriteLine(dude);
                ReadKey();

            }



        }



    }




   
}
