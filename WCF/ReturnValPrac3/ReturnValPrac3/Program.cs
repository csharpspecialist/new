using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ReturnValPrac3
{
    class Program
    {
        static void Main(string[] args)
        {

            Program p = new Program();
            Console.WriteLine("what is your favorite food??");
            string foodAns;
            string food1 = Console.ReadLine();

            Console.WriteLine("what is your 2nd favorite food??");

            string food2 = Console.ReadLine();

            p.FavFood(food1, food2);

            foodAns = p.FavFood(food1, food2);

            Console.WriteLine($"here is your fav food {foodAns}");

            ReadKey();
        }


        public string FavFood(string eating1 , string eating2)
        {
            string goodFood = eating1 + eating2;
            return goodFood;
        }


    }
}
