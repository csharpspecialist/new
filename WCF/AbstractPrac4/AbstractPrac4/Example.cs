using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPrac4
{
    class Example
    {



    }


    abstract class absClass1
    {
        public abstract int AddTwoNumbers(int Num1, int Num2);
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }

    //Abstract Class2
    abstract class absClass2 : absClass1
    {
        //Implementing AddTwoNumbers
        public override int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
    }

    //Derived class from absClass2
    class absDerived : absClass2
    {
        //Implementing MultiplyTwoNumbers
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
    }


}
