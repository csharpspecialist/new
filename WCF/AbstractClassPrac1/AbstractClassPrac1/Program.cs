using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AbstractClassPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog fido = new Dog();

            WriteLine( fido.Describe());
            ReadKey();


        }
    }
}

#region SuperClass
abstract class FourLeggedAnimal
{
    public virtual string Describe()
    {
        return "This is a strange 4 legged animal";
    }


}
#endregion

#region Subclasses
class Dog : FourLeggedAnimal
{

}

class Cat : FourLeggedAnimal
{

}
#endregion

