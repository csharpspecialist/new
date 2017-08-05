using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPrac1
{
    class Football
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public string  Division { get; set; }
        public int NetWorth { get; set; }
        public string Conference { get; set; }


        public void PrintClub()
        {
            Console.WriteLine($"Team ID number, {ID}, The {TeamName} of the {Conference} \n " +
            $"in the {Division} have a net worth of {NetWorth}.  ");


        }
    }
}
