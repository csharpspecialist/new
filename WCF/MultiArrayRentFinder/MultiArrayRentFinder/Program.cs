using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MultiArrayRentFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.ApartmentSearch();
            
        }


        public void ApartmentSearch()
        {
            int[,] rents = { { 400, 450, 510},
            { 500, 560,630},
                { 625, 675, 710},
                { 1000, 1300, 1600}
            };

            int floor;
            int bedrooms;

            Console.WriteLine("Enter the floor on which u wish to live");

            floor = Convert.ToInt16(ReadLine());

            Console.WriteLine("Enter the # of bedrooms you are looking for");

            bedrooms = Convert.ToInt16(ReadLine());

            Console.WriteLine($"The rent is {rents[floor, bedrooms]} \n for an Apartment on floor # " +
                $"{floor} with {bedrooms} bedroom(s) \n");


            WriteLine("Would you like to see the price for another Apartment \n  Y or N \n ");
            string searchAgain = ReadLine().ToUpper();

            if (searchAgain == "Y" || searchAgain == "YES")
            {
                ApartmentSearch();
            }
            else
            {
                Console.WriteLine("Thanks for shopping with us!!! \n Come Again Soon!!");
                Console.WriteLine("Press any key to exit");
                ReadKey();
            }

        }

    }
}
