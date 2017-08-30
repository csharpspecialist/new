using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndMultiProjectPrac1
{


    public class Master  //THis must b public to see it from other project!!!!!
    {

        public int ID { get; set; }
        public string Name { get; set; }

        public void Working()
        {
            Console.WriteLine("The work is being done here");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {       
                           
                Master C1 = new Master();
                C1.ID = 101;
                C1.Name = "Dude"           
;
            //object initializer syntax!!!! started in C# 3.0
            Master C2 = new Master
            {
                Name = "Mary",
                ID = 2001

            };

            Master C3 = new Master
            {
                Name = "Franklin",
                ID = 4251

            };
            //the list must be inside of a method or this will not work!!!!
            //the accessors can be outside of the method / created inside of the class...that's ok!!
            List<Master> people = new List<Master>();

            people.Add(C2);
            people.Add(C3);

            foreach (var item in people)
            {
                Console.WriteLine($"the name is {item.Name} and my id is {item.ID}");
            }
            
            Console.ReadLine();
        }


        public class Apprentice : Master
        {
            public int Grade { get; set; }
            //below is called    object initializer syntax
            Apprentice k1 = new Apprentice
            {
                ID = 2002,
                Name = "Destro",
                Grade = 8
                
            };
            
        }

        /*
         * you cannot inherit from a struct/use it as a base class. a struct is a value type
         * a struct cannot have a return type.  a struct cannot have a destructor
         * */
        public struct Water
        {

            public int FirstID { get; set; }


        }

    }
}
