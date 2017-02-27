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

        string Nissan;
        string Dodge;


        public void List()
        {
            WriteLine("which vehicle is your fav");
            string fav = ReadLine().ToUpper();


            switch (fav)
            {
                case "Nissan":
                    WriteLine("Nissan's are A OK");
                    break;
                case "Chevy":
                    WriteLine("Nissan's are A OK");
                    break;

                case "Dodge":
                    WriteLine("Nissan's are A OK");
                    break;

                case "Ford":
                    WriteLine("Nissan's are A OK");
                    break;
                   
                default:
                    WriteLine("That Vehicle is for Sissies!!");
                    break;
                   
            }
            ReadKey();

        }




    class Cars
    {


            public void Mass()
            {
                int wimpy = 22;
                int glee = 55;
               // string gloo = "Clue";

                string food = ReadLine().ToUpper();

                string dude = (glee > wimpy) ? "Cool" : "Not cool";


            }
       
    }


    }
}
