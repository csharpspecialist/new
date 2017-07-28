using System;


namespace IfCheck
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("What is your favorite color");
            string favorite = Console.ReadLine();
            


            if (favorite == "Red")
            { 
                Console.WriteLine("Red is a good favorite color");
            }
            else if (favorite == "Blue")
            {
                Console.WriteLine("Blue is a good favorite color");
            }
            else if (favorite == "Green")
            {
                Console.WriteLine("Green is a good favorite color");
            }
            else if (favorite == "Yellow")
            {
                Console.WriteLine("Yellow is a good favorite color");
            }
            else
            {
                Console.WriteLine("we only like either red or blue");
            }
            //line 37  runs no matter what 
            Console.WriteLine("The program has ended");
             
            Console.ReadKey();
            Console.ReadLine(
        }
    }
}
