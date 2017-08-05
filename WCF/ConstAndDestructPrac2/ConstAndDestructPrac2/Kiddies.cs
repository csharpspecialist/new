using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAndDestructPrac2
{
    class Kiddies : Student
    {


        /* you can only create 1 of the inherited constructor
         * inside of the derived class.  below I commented out the
         * constructor that took in/used the int variables in order to make this work/remove squigglies.
         * */

        //public Kiddies(): base(500, 1000)
        //{      


        //}

        public Kiddies() : base("nice", " boring")
        {
            base.ToString();
            Console.WriteLine("Things that make you go hmmmm");

        }

        public void Elementary()
        {

            Console.WriteLine("we like candy");
        }





    }
}
