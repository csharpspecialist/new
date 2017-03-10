using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AbstractPrac4
{
    class Program
    {
        static void Main(string[] args)
        {
            Marvel webhead = new Marvel();

            int please = 0;
            int bravery;
            string speed;
            webhead.Justice();

            speed = (webhead.Justice());

            Console.WriteLine(speed);
            ReadLine();

            bravery = (webhead.Scheme());

            Console.WriteLine(bravery);
            ReadLine();
        }
    }


    abstract class Hero
    {


       public abstract string Justice();
    }


     class Marvel : Hero
    {
        public int payment = 25;
        private int equation = 5;

        public override string Justice()
        {
            string muscle = "power";

            return muscle;
        } 

        private int  Hulk()
        {

           equation +=  payment;

            return equation; 
            
        }

        public int Scheme()
        {
            return Hulk();
        }

    }

}
