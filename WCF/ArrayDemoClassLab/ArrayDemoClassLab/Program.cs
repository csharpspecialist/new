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
        static void Main()
        {
            Program p = new Program();
            int[] values = { 21, 33, 55, 49, 77, 68, 99 };

            Console.WriteLine("Which would you like to do... \n See an array in Ascending order choose 1 \n Descending order choose 2 \n Find a specific value in the array choose 3 \n");

            int choice = Convert.ToInt16(ReadLine().ToUpper());
            switch (choice)
            {
                case 1:
                    p.Ascend(values);
                    WriteLine(" \n ");
                    break;

                case 2:
                    p.Rev(values);
                    break;

                case 3:
                    p.Find(values);
                    break;

                default:
                    WriteLine("That Choice is not Valid!!!" +
                        "Choose Either 1, 2, or 3 \n " +
                        "Press any key to continue \n");
                    ReadKey();
                    Main();
                    break;
            }                                  

        }
        public void Ascend(int[] val2)
        {
            Program p = new Program();
            Array.Sort(val2);
            
            for (int i = 0; i < val2.Length; i++)
            {
                Console.Write(val2[i]);
                Console.Write("   *   ");
                
            }
            Console.Write(" \n \n ");
            p.Menu();
            ReadKey();

        }

        public void Rev(int[] vals)
        {
            Program p = new Program();
            Array.Reverse(vals);

            for (int i = 0; i < vals.Length; i++)
            {
                Console.Write(vals[i]);
                Write("  ");
            }
            Console.Write(" \n \n ");
            p.Menu();
            ReadKey();
        }

        public void Find(int[] valNums)
        {
            Program p = new Program();
            int x;
            Console.Write("Which array value would you like to find??");

            int numChoice = Convert.ToInt16(ReadLine());

           // Array.Sort(valNums);

            x = Array.BinarySearch(valNums,numChoice);

            if (x < 0)

            {
                Console.WriteLine($"Your choice of {numChoice} was found!!! \n");
                ReadKey();
            }
            else
            {
                Console.WriteLine($"Your choice of {numChoice} was not located on the list \n");
            }
            Console.Write(" \n \n ");
            p.Menu();
            ReadKey();
           
        }

        public void Menu()
        {
            Console.WriteLine("  Would You Like To Try Again?? \n \n" +
                "Y   or   N \n");
            string answ = Console.ReadLine();


            if (answ == "Y")
            {
                Main();
            }
            else
            {
                Console.WriteLine(" \n Thanks for using our program!!");
            }
            

        }


    }
}
