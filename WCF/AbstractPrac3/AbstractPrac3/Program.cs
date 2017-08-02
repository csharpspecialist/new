using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AbstractPrac3
{
    class Program
    {
        static void Main(string[] args)
        {



            College now = new College();

            Console.WriteLine($"the winning show was a {now.Book()} pointer!!!");
            ReadKey();
        }
    }

    abstract class School
    {

        public abstract int Book();
        //above cannot have curly braces after it or anything else!!!
        //just write the abstract method just like this above!!!!
    }

    class College : School
    //you must inherit from School 
    //in order for this to work!!!!
    /*the class above cannot be public!!!  Don't give it a
     * access modifier!!!
    */
    { 

        public override int Book()
        {
            int threePointer = 3;
            return threePointer;

        }
    }

}
