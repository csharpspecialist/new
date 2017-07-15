
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace EnumPrac2
{
    class Program
    {
        //this enum must be created between the class name
        //and the first method...in other words ...right here!!
        //don't make it public or private or any other access modifier!!!!
        enum teams
        {
            Private = 1,
            Leiutinant,
            Major,
            General
        }

        enum sandwich
        {
            BigMac = 1,
            Whopper,
            Cheeseburger,
            QuarterPounder,
            DblCheeseBurger,
            Single,
            Double,
            Triple
        }

        enum cars
        {

            Honda = 1,
            Ford,
            Cadillac,
            GMC, 
            Corvette,
            Lincoln

        }

        enum Games
        {
            Halo = 1,
            COD,
            Rainbow6,
            DeathStrike,
            Titans,
            Zelda

        }


        enum Chicken
        {
            Fried = 1,
            Nuggets,
            Fingers,
            Grilled,
            Sauted
        }



        static void Main(string[] args)
        {
            //shift up after tab tab to create switch structure
            int rank;
            //string message;
            WriteLine("which rank are you");

            rank = Convert.ToInt16(ReadLine());

            switch ((teams)rank)
            {
                case teams.Private:
                    break;
                case teams.Leiutinant:
                    break;
                case teams.Major:
                    break;
                case teams.General:
                    break;
                default:
                    break;
            }

        }

        public void Grub()
        {
            int burgerChoice;

            //shift up after tab tab to create switch structure
            WriteLine("Which Burger is the best");

            burgerChoice = Convert.ToInt16(ReadLine());

            switch ((sandwich)burgerChoice)
            {
                case sandwich.BigMac:
                    break;
                case sandwich.Whopper:
                    break;
                case sandwich.Cheeseburger:
                    break;
                case sandwich.QuarterPounder:
                    break;
                case sandwich.DblCheeseBurger:
                    break;
                case sandwich.Single:
                    break;
                case sandwich.Double:
                    break;
                case sandwich.Triple:
                    break;
                default:
                    break;
            }
        }

        public void Machines()
        {
            //shift up after tab tab to create switch structure
            int vehicle;

            WriteLine("Which Car Manufacturer is your Favorite???");

            vehicle = Convert.ToInt16(ReadLine());

            switch ((cars)vehicle)
            {
                case cars.Honda:
                    break;
                case cars.Ford:
                    break;
                case cars.Cadillac:
                    break;
                case cars.GMC:
                    break;
                case cars.Corvette:
                    break;
                case cars.Lincoln:
                    break;
                default:
                    break;
            }

            //shift up after tab tab to create switch structure
            WriteLine("What's the best game ever!!");

            int gameAns = Convert.ToInt16(ReadLine());

            switch ((Games)gameAns)
            {
                case Games.Halo:
                    break;
                case Games.COD:
                    break;
                case Games.Rainbow6:
                    break;
                case Games.DeathStrike:
                    break;
                case Games.Titans:
                    break;
                case Games.Zelda:
                    break;
                default:
                    break;
            }

            WriteLine("What's the best game that u ever played!!");
            //shift up after tab tab to create switch structure
            int bestGame = Convert.ToInt16(ReadLine());

            switch ((Games)bestGame)
            {
                case Games.Halo:
                    break;
                case Games.COD:
                    break;
                case Games.Rainbow6:
                    break;
                case Games.DeathStrike:
                    break;
                case Games.Titans:
                    break;
                case Games.Zelda:
                    break;
                default:
                    break;
            }

            Console.WriteLine("What's the best type of Chicken");
            //shift up after tab tab to create switch structure
            int pollo =  Convert.ToInt16(Console.ReadLine());

            switch ((Chicken)pollo)
            {
                case Chicken.Fried:
                    break;
                case Chicken.Nuggets:
                    break;
                case Chicken.Fingers:
                    break;
                case Chicken.Grilled:
                    break;
                case Chicken.Sauted:
                    break;
                default:
                    break;
            }


        }

      
       

    }
}







