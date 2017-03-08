using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace NamedArgumentsPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Closing("smash");
            ReadKey();
        }

        public void Closing()
        {
            Console.WriteLine("Sincerely");
            Console.WriteLine("J master");
        }

        public void Closing(string name = "mystery")
        {
            Console.WriteLine("Sincerely");
            Console.WriteLine(name);
        }
        //run this to see what happens!!
     
    }
}
