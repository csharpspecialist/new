using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AbstractionDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Car obj = new Car();

            Console.WriteLine($"Car mileage is {obj.GetMileage()}");

            Console.WriteLine($"Car color is {obj.GetColor()}");

            Console.WriteLine($"car formula is {obj.DisplayEngFormula()}");

            //inaccessible outside of car class
            ReadKey();
                        
        }
    }

    public class Car
    {
        public int mileage = 85;

        public string color = "Red";

        private string formula = "a * b";

        public int GetMileage()
        {
            return mileage;
        }

        public string GetColor()
        {
            return color;
        }

        private string GetEngineFormula()
        {
            return formula;
        }

        public string DisplayEngFormula()
        {
            return GetEngineFormula();
        }

    }


}
   


