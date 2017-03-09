using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AbstractionPrac1
{
    class Program
    {
        static void Main(string[] args)
        {

            Car speed = new Car();

            WriteLine($"This is the mileage {speed.GetMileage()}");
            ReadKey();


            WriteLine($"This is the color {speed.GetColor()}");
            ReadKey();

            WriteLine($"Here is the formula {speed.StealFormula()}");
            ReadKey();
        }




    }

    public class Car
    {
        public int mileage = 85;

        public string color = "Red";

        private string formula = "a * b";
        public string StealFormula()
        {
            return Form();
        }

        private string Form()
        {
            return formula;
        }

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
