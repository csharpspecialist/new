using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using static System.Console;

namespace ListPrac1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Automobile> inventory = new List<Automobile>();

            Automobile car1 = new Automobile();

            car1.AutoID = 100;
            car1.Year = 2012;
            car1.Make = "Dodge";
            car1.Model = "Charger";
            car1.Miles = 32001;

            Automobile car2 = new Automobile();

            car2.AutoID = 200;
            car2.Year = 2010;
            car2.Make = "Dodge";
            car2.Model = "Dart";
            car2.Miles = 39061;

            inventory.Add(car1);
            inventory.Add(car2);

            //Console.WriteLine($"The oldest car was built in ");
            foreach (Automobile item in inventory)
            {
                item.PrintList();
                
            }
            Console.ReadLine();

            //below is how it would have to be done using a for loop
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"Listing of {inventory[i].Make}, {inventory[i].Model} is here");
            }
            Console.ReadLine();


        }
    }

   
}
