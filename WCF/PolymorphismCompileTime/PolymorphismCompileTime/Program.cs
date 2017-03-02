using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PolymorphismCompileTime
{
    public class Base
    {
        /*Compile Time Polymorphism:
  * In this type of polymorphism, compiler identifies which polymorphism form it has
  * to take and execute at compile time is called as compile time polymorphism or early binding.
  * Examples of early binding are Method Overloading and Operator Overloading. The Method
  * Overloading means more than one method having same name but different signatures (or parameters)
  * in the same or different class.*/


            //method Overloading!!!!
        public object Display(object a)
        {  //method # 1
            return a;
        }

        public object Display(int a)
        {//method # 2
            return a;
        }

        public object Display(string a)
        {//method # 3
            return a;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {

            Base obj = new Base();

            int val = 7;

            int val2 = 12;

            string words = "Polymorphism overloaded string value";

            //1st method will be called below 
            WriteLine(obj.Display(val));

            //2nd method will be called below 
            WriteLine(obj.Display(val2));


            //3rd method will be called below --displays string
            WriteLine(obj.Display(words));

            ReadKey();

        }
    }
}
