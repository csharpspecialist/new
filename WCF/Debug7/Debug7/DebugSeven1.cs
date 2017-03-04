// Uses DisplayWebAddress method three times
using static System.Console;
public class DebugSeven1
{

    public double things = 2.0;
    public int num = 33;
   // public string 
    public string smart = "";
    public string thinker = "";

    public int DisplayWebAddress(int num)
    {
        int number = 0 + num;
        return number;
    }

    public string DisplayWebAddress(string things,string place)
    {
       string address =
           ("What's the word..Thunderbird!!!!");
        return address;
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
