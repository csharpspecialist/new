using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopArrayPrac2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = {1,15,8,320,14,6 };


            for (int i = 0; i < numArray.Length; i++)
            {
                Array.Reverse(numArray);
                Console.WriteLine(numArray[i]);
                 

            }
            Console.ReadKey();
        }

        public void Show(int [] numbers)
        {

        }

    }
}
