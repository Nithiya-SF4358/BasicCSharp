using System;
namespace assignment;
class Datetime
{
    public static void Main()
    {
        DateTime customDateTime = new DateTime(2021, 8, 10, 10, 40, 32);
        Console.WriteLine("Individual Components:");
        Console.WriteLine($"Year: {customDateTime.Year}");
        Console.WriteLine($"Month: {customDateTime.Month}");
        Console.WriteLine($"Day: {customDateTime.Day}");
        Console.WriteLine($"Hours: {customDateTime.Hour}");
        Console.WriteLine($"Minutes: {customDateTime.Minute}");
        Console.WriteLine($"Seconds: {customDateTime.Second}");
        string dateTimeString = customDateTime.ToString();
        string[] dateTimeComponents = dateTimeString.Split(' ');
        Console.WriteLine("\nSplit and Print in Reverse Order:");
        for (int i = dateTimeComponents.Length - 1; i >= 0; i--)
        {
            Console.Write(dateTimeComponents[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("\nEnter a date and time (yyyy/MM/dd hh:mm:ss tt):");
        string userInput = Console.ReadLine();
        if (DateTime.TryParseExact(userInput, "yyyy/MM/dd hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out DateTime userDateTime))
        {
            Console.WriteLine($"Year: {userDateTime.Year}");
            Console.WriteLine($"Month: {userDateTime.Month}");
            Console.WriteLine($"Day: {userDateTime.Day}");
        }
        else
        {
            Console.WriteLine("Invalid date and time format. Please enter a valid format.");
        }
    }
}

