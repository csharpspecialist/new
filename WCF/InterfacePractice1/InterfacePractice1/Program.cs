using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice1
{
    class Program
    {

        public interface IWork
        {

            void Printing();
            void Display();        
            
        }

        public interface IClean
        {
            void Shop();

        }



        public class Names : IWork, IClean, IRun
        {
             string coder = "nice";
            public void Printing()
            {
                Console.WriteLine("I love Lucy");

            }

            public void Display()
            {
                Console.WriteLine("We are in the Display method");
            }

            public void Shop()
            {
                Console.WriteLine("Shopping is really really fun!!!!");
            }

            public void Sprint()
            {
                Console.WriteLine("I like to run!!!!!");
            }

        }




        static void Main(string[] args)
        {
            Names n = new Names();
            n.Display();
            n.Printing();

            Console.ReadLine();       
            
            
        }


       public interface IRun
        {
            void Sprint();
            

        }




    }
}
