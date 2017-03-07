using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ArrayDemoClassLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] values = { 21, 33, 55, 49, 77, 68, 99 };

            Console.WriteLine("Which would you like to do... \n See an array in Ascending order choose 1 \n Descending order choose 2 \n Find a specific value in the array choose 3");

            int choice = Convert.ToInt16(ReadLine().ToUpper());
            switch (choice)
            {
                case 1:
                    p.Ascend(values);
                    break;

                case 2:
                    p.Rev(values);
                    break;

                case 3:
                    p.Find(values);
                    break;

                default:
                    break;
            }                      
                                

        }
        public void Ascend(int[] val2)
        {
            Array.Sort(val2);
            
            for (int i = 0; i < val2.Length; i++)
            {
                Console.WriteLine(val2[i]);
                Console.WriteLine("*************");
            }
            ReadKey();

        }

        public void Rev(int[] vals)
        {
            Array.Reverse(vals);

            for (int i = 0; i < vals.Length; i++)
            {
                Console.WriteLine(vals[i]);
            }
            ReadKey();
        }

        public void Find(int[] valNums)
        {
            int x;
            Console.WriteLine("Which array value would you like to find??");

            int numChoice = Convert.ToInt16(ReadLine());

            x = Array.BinarySearch(valNums,numChoice);

            if (x < 0)

            {
                Console.WriteLine($"Your choice of {numChoice} was found!!!");
                ReadKey();
            }
            else
            {
                Console.WriteLine($"Your choice of {numChoice} was not located on the list");
            }
            ReadKey();
           
        }

    }
}
