using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropsAndFieldsPrac1
{

    public class AgeChecker
    {

        //public AgeChecker(int a, int b, string c, int d)
        //{

        //    idNumber = 22;
        //    age = 10;
        //    Name = "Dude";
        //    weight = 205;
        //}



        private int idNumber;

        public int IdNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        public string Name { get; set; }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 100)
                {
                    age = 99;
                }
                else if (value < 1)
                {
                    age = 1;
                }

            }
        }

        string input;
        private int weight;

        public int Weight
        {
            get { return weight; }
            set
            {
                while (!int.TryParse(input, out weight) || weight >= 300)
                {
                    Console.WriteLine("your weight is too high \n Try again");
                    input = Console.ReadLine();

                }


            }
        }

    }

    class Program
    {

        static void Main()
        {
           // AgeChecker a = new AgeChecker(2003, 36, "Houdini", 205);
            AgeChecker b = new AgeChecker();

            //a.Name = "Houdini";
            //a.Age = 36;
            //a.Weight = 199;

            //b.IdNumber = 2002;
            //b.Name = "Cruella";
            //b.Age = 27;
            //b.Weight = 225;

          //  PrintDetails(a);
            //PrintDetails(b);

            Console.ReadLine();

            int tempWeight;
            Console.WriteLine("What is your wight");
            string ageTemp = Console.ReadLine();

            int.TryParse(ageTemp, out tempWeight);
            b.Weight = tempWeight;

            Console.WriteLine($"Your weight is {b.Weight}");
            Console.ReadLine();
        }

        public static void PrintDetails(AgeChecker d)
        {
            Console.WriteLine($"my ID number is {d.IdNumber}, my name is {d.Name}, my age is {d.Age} and my weight is {d.Weight}");

        }

    }

   






}

