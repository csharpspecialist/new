using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstAndDestructPrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Dr.", "Strange");
            s.PrintFullName();

            Console.WriteLine($"I like chili!!!");

            Console.ReadLine();

          
        }
    }
}
