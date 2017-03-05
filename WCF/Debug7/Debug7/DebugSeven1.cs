// Uses DisplayWebAddress method three times
using static System.Console;
public class DebugSeven1
{

    public double things = 1000.00;//
    public int num = 33;
   // public string 
    public string smart = "";//
    public string thinker = ""; //
    public string place = "";//
    public string passion = "";
    public string glory = "Fully committing yourself to the Cleveland Codes instructor can fix that!!!";

    public int DisplayWebAddress(int num)
    {
        int number = 0 + num;
        return number;
    }

    public string DisplayWebAddress(string passion,string place)
    {
       string address =
           ("What's the word..Thunderbird!!!!");
        return address;
    }

    public string DisplayWebAddress(double things, string glory)
    {
        string words =
            ($"You have {things} in your account...{glory} ");
        return words;
    }



    public void ShowWebAddress()
    {
        DisplayWebAddress();
    }     

    private void DisplayWebAddress()
   {
     
        WriteLine("------------------------------");
        WriteLine("Visit us on the web at:");
        WriteLine("www.shoppersworldbargains.com");
        WriteLine("******************************");
    }
}
