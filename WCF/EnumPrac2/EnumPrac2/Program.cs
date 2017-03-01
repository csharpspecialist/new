
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

        static void Main(string[] args)
        {

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

        }

      
       

    }
}







