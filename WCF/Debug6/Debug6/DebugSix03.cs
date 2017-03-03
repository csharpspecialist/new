// Finds whether a book dealer carries a requested book
using System;
using static System.Console;
class DebugSix03
{
    public void Tres()
    {
        String[] books = {"CATCH-22", "HARRY POTTER",
         "C# RULES", "RICH DAD, POOR DAD",
         "THE DEEP", "WIZARD"};

        int x;
        string entryString;

        WriteLine("What book are you looking for? ");
        entryString = Console.ReadLine().ToUpper();

        x = Array.BinarySearch(books, entryString);

        if (x < 0)
        {
         WriteLine($"{entryString} not found" );
            ReadKey();
        }
        else
        { 
         WriteLine($"Yes, we carry {entryString}");
            ReadKey();
        }
    }
}
