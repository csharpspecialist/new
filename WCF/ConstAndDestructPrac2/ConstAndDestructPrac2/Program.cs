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
            Console.WriteLine("++++++++++++++++\n+++++++++");
            Student n = new Student(20, 30);
            n.SecretNumbers();

            Console.WriteLine($"I like chili!!!");


            Kiddies k = new Kiddies();
            k.Elementary();

            Console.ReadLine();


            string blah = Golden();
            Console.WriteLine(blah);
            Console.ReadLine();
        }

        public static string Golden()
        {
            string great = "Eat At Joe's";
            return great;
        }


    }




    
}
