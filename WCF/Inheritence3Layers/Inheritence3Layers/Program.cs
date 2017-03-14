using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Inheritence3Layers
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Manager man = new Manager();

            Console.WriteLine($" New dude equals  {man.Greeting()}");

            Console.WriteLine($"here it is {emp.Greeting()}");
            ReadLine();
            

        }

        public virtual string Greeting()
        {
            string greeting = "Hello People";
            
            return greeting;
        }
    }
}
