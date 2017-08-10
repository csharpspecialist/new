using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndMultiProjectPrac1
{


    public class Master
    {

        public int ID { get; set; }
        public string Name { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;

            if(i == 0)
            {
                int j = 20;
                Master C1 = new Master();
                C1.ID = 101;
                C1.Name = "Dude"
           
;

            }

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

            Apprentice k1 = new Apprentice
            {
                ID = 2002,
                Name = "Destro"

            };





        }

    }
}
