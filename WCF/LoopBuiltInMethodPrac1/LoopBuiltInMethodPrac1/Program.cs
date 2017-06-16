using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopBuiltInMethodPrac1
{
    class Program
    {
        static void Main()
        {
            Program p = new Program();
            int[] numbers = new [] { 2, 5, 9, 4, 3, 4, 6, 5 };
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }


            Array.Reverse(numbers);
            Console.WriteLine(numbers[0]);
            
            int crazy = p.Sorted(numbers);
            //Console.WriteLine($"the answer is {dude}");
            Console.WriteLine(crazy);
            Console.ReadLine();
        }

        public int Sorted(int [] stuff)
        {


            int place = stuff.Sum();
            return (place);
            //Array.Sort(stuff);
            //Console.WriteLine(stuff);
            //Console.ReadLine();
            //return (stuff[2]);
        }


    }
}
