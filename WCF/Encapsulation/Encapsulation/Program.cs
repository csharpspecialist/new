using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Car fast = new Car();

            WriteLine($"Car mileage is {fast.GetMileage()}");

            WriteLine($"Car color is {fast.GetColor()}");

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
                
    }

}
