using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<int, Football> ballClub = new Dictionary<int, Football>();


            Football f1 = new Football() { ID = 101, TeamName = "Bears", Conference = "NFC", Division = "North", NetWorth = 110000000  };


            Football f2 = new Football() { ID = 102, TeamName = "Raiders", Conference = "AFC", Division = "West", NetWorth = 130000000 };


            ballClub.Add(f1.ID, f1);
            ballClub.Add(f2.ID, f2);


            foreach (KeyValuePair<int, Football> fballVal in ballClub)
            {

                Console.WriteLine($"here {fballVal.Key} ");
                Football fb = fballVal.Value;
                //  Football ft = fballVal.Key;  //line of code does not work!!!!
                fb.PrintClub();   // this line of code or write the code in line 33             
                Console.WriteLine($"Here we have the {fb.ID}, {fb.TeamName}, {fb.Conference }, {fb.Division} and the team is worth {fb.NetWorth}");
                Console.WriteLine("*************************");
            }

            /*
             * the code below does the same thing..it just uses the var keyword and lets VS determine the data type that it needs.
             * we must create/instantiate an object of the football class in line 30 & 45 or this does not work!!
             * */

            foreach (var item in ballClub)
            {
                //Console.WriteLine($"here {item.Key} ");
                Football fb = item.Value;  //must declare this or no linking to football class!!!!
                fb.PrintClub();
               // Console.WriteLine($"Here we have the {fb.ID}, {fb.TeamName}, {fb.Conference }, {fb.Division} and the team is worth {fb.NetWorth}");
                Console.WriteLine("*************************");
            }


            Console.ReadLine();

        }
    }
}
