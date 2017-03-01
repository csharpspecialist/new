using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApplication1
{
    class Program
    {
        //this enum must be created between the class name
        //and the first method...in other words ...right here!!
        //don't make it public or private or any other access modifier!!!!
        enum teams
        {
            Champs = 1,
            Cavs,
            Spurs,
            Miami

        }
        static void Main(string[] args)
        {

            int dud = 1;
            int lasso = 3;
            string warp = (dud == lasso) ? "Not so fast" : "We r out of here!!!"; 


        }

        public void BBall()
        {
            teams ballers = teams.Cavs;


            switch (ballers)
            {
                case teams.Champs:
                    break;
                case teams.Cavs:
                    break;
                case teams.Spurs:
                    break;
                case teams.Miami:
                    break;
                default:
                    break;
            }
        }

    }
}



    

