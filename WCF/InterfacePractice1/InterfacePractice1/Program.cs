using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice1
{

    //IZap has 2 members!!!
    //declared at namespace level!!!!
    //outside of any/all classes!!!
    public interface IZap
    {
        void Play();
        void Surf();

    }

    class Program
    {
    
        /*
         * IWork, IClean & IRun are declared inside of the Program class
         * if you don't want to create a new class inside of the 
         * program (Class Names) class then the interfaces must be declared at the 
         * namespace level!!!!
         * */
        public  interface IWork 
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

        public class People : IZap
        {
            public void Play()
            {
                Console.WriteLine("The game has been cancelled!!!");
            }

           public void Surf()
            {
                Console.WriteLine("The waves are calm today");
            }
        }


        static void Main(string[] args)
        {
            People p = new People();
            Names n = new Names();
            n.Display();
            n.Printing();
            p.Surf();
            p.Play();

            Console.ReadLine();
     
        }


       public interface IRun
        {
            void Sprint();
            

        }
        

    }
}
