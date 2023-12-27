using System;
namespace assignment;
class Program{
    public static void Main(string[] args)
    {
        DateTime currentdate=DateTime.Now;
        Console.WriteLine("Current Month: "+currentdate.ToString("MMMM"));
        DateTime threedaysago=currentdate.AddDays(-3);
        Console.WriteLine("Three days ago was: "+threedaysago.ToString("dddd,MMMM dd,yyyy"));
        Console.WriteLine("Current Time in 12-hour format: "+currentdate.ToString("hh:mm tt"));
    }
}