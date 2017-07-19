using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace WhilePrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Martian beta = new Martian();

             //beta.SpaceGhost();
           // beta.BankAppLoop();
            ReadKey();


            int num = 1;

            int limit = 5;

            while(num < limit)
            {
                WriteLine("This is iteration # " + limit);
                WriteLine(num++);
                num++;



            }
            ReadKey();

           // beta.ArrayLoop();

        }
    }
}
