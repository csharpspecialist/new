using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace RectangleApp
{
    public class Dealership 
    {
        //creating 2 vars for inheritance practice
        public int crush = 33; 
        public double smash = 1022.22;

       



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
            spree.Specials();

            WriteLine("I am thinking of a magic #");
           
            //combining conversion & reading from console into 1 step
            int newMNum = Convert.ToInt32(Console.ReadLine());
            
           //ternary practice
            int guess = 10;
            string answer = (newMNum == guess) ? "U r great!!!" : "Your name is muDD!!!";
            
            WriteLine(answer);
        }
              
    }

    public class Detailers
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

    public class Motor
    {
        public int v6;
        public int v8;
    }



}
