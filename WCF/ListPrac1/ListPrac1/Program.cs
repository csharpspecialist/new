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
            car1.Make = "Dodge";
            car1.Model = "Charger";
            car1.Miles = 32001;

            Automobile car2 = new Automobile();

            car2.AutoID = 200;
            car2.Make = "Dodge";
            car2.Model = "Dart";
            car2.Miles = 39061;

            inventory.Add(car1);
            inventory.Add(car2);

            Console.WriteLine($"The oldest car was build in {inventory[1]}");
            foreach (Automobile item in inventory)
            {
                Console.WriteLine(item);
                
            }

            ReadLine();


        }
    }

    class Automobile
    {
        public int AutoID { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        public int Miles { get; set; }



    }
}
