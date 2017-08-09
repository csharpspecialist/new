using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antidote;  //added a using statement to Antidote proj here

namespace Intake
{
    public class Begin  // 2 - make sure that this class is public!!!!
    {
        static void Main()

        {
            // 1 - add a new project file
            //  1.1 - create/add a reference to Antidote project in references
     

            Console.WriteLine("Getting ready to take on the world...again");
            // 4 - created an instance of the durango class from the Antidote project
            // 5 - then called a method from that class
            Durango d = new Durango();  //this class must b public in its project or will not be seen!!!
            d.Boxer();
            Business b = new Business();   //this class must b public in its project or will not be seen!!!

            //6 - make this the starting project
            // 7 - This will not work both ways...this is an example of information hiding!!!!
           int tot =  d.PerformAdding(2, 4);
            Console.WriteLine(tot);
            Console.ReadLine();

        }

        public void Shout()
        {

            Console.WriteLine("Getting the word out!!!!");


        }

        public int PerformMult(int x, int y)
        {


            return x * y;
        }


    }
}
