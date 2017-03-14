using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using System.Threading.Tasks;

namespace LetterDemoClassLab
{
    class Program
    {
        static void Main(string[] args)
        {

            


            Letter scribe = new Letter();


            scribe.Name = "good";


            Console.WriteLine(scribe.GetType() );

            Console.WriteLine(scribe.Name.GetType());

            Console.WriteLine(scribe.DateMailed.GetType());

            Console.WriteLine(scribe.Name);

            ReadLine();
        }
    }
}
