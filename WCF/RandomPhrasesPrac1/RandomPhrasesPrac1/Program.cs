using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPhrasesPrac1
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomWords();
            NewRandom();
        }

        private static void RandomWords()
        {
            string[] mystrings = "apple|orange|mayo|fruit|dog".Split('|');


            int choice = new Random().Next(mystrings.Length);


            string blah = "Your selection is: " + mystrings[choice];

            Console.WriteLine(blah);
            Console.ReadLine();
        }


        public static void NewRandom()
        {

            string[] mystrings = "apple|orange|mayo|fruit|dog".Split('|');
            Random rnd = new Random();
            string blah1 = mystrings[rnd.Next(mystrings.Length)];
            string blah2 = mystrings[rnd.Next(mystrings.Length)];
            string sentence = "here i am " + blah1 + " result chosen from mystring was " + blah2;
            Console.WriteLine(sentence);
            Console.ReadLine();

        }
    }
}
