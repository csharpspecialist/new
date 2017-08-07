using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DictionaryTry1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Dictionary<string, int> animals = new Dictionary<string, int>();
            
            animals.Add("Bear", 4);
            animals.Add("Squid", 10);
            animals.Add("Bird", 2);
            animals.Add("Owl", 3);
            animals.Add("Deer", 9);
            animals.Add("Buffalo", 5);
            try
          

           
            {

                Console.WriteLine("Which key are you looking for?");
                string dude = Console.ReadLine();
                int val = Convert.ToInt16(Console.ReadLine());
                if (animals.ContainsKey("Moose"))
                {

                    //Console.WriteLine("We have a " + dude + " here ");
                    val = animals["Bear"];
                    Console.WriteLine("bear has "  + val + "whaterver");
                }
                else
                {
                    Console.WriteLine($"The key that you are trying to find {val} Does not exist");
                }

                Console.ReadKey();
            }
            catch (FormatException)
           
            {

                Console.WriteLine("Format exception Caught here");
            }

            catch (Exception)
            {

                Console.WriteLine("Caught the general exception");
            }

            Console.ReadLine();



            //if (animals.ContainsKey(dude))
            //{
            //    val = animals["Moose"];
            //    Console.WriteLine("We have a " + val + "Legs");

            //}





        }
    }
}
