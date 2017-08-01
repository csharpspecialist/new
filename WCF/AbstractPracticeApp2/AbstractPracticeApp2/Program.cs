using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPracticeApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Marvel spidey = new Marvel();

            int bravery;
            string speed;
            
            speed = spidey.Justice();
            Console.WriteLine(speed);


            bravery = spidey.Scheme();

            Console.WriteLine(bravery);

            Console.ReadLine();



        }
    }
}
