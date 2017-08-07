using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListPrac1
{
    class Automobile
    { 
        public int AutoID { get; set; }

        public int Year { get; set; }
        public string Make { get; set; }

        public string Model { get; set; }

        public int Miles { get; set; }

        public void PrintList()
        {


            Console.WriteLine($"Automobile Id # {AutoID} - {Year} {Make}, {Model} with {Miles} miles.");
        }

    }
}
