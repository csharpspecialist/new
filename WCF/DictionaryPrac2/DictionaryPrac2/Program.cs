using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryPrac2
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] array = { 10, 5, 10, 2, 2, 3, 4, 5, 5, 6, 7, 8, 9, 11, 12, 12 };
            var dict = new Dictionary<int, int>();

            foreach (var value in array)
            {
                if (dict.ContainsKey(value))
                    Console.WriteLine(value);
               
                else
                    Console.WriteLine(dict[value] = 1);
            }
            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);
            Console.ReadKey();

            Console.WriteLine("press any key to continue");
            Console.ReadLine();

            

            Console.WriteLine($"the answer to practice is {Practice()} ");

            Console.WriteLine("");


            Console.ReadLine();

        }

        public static int Practice()
        {

            int completed = 5 * 5;

            return completed;
        }

    }
}
