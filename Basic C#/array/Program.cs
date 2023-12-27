using System;
namespace assignment;
class Array
{
    public static void Main()
    {
        string[] namesArray = new string[5];
        namesArray[0] = "Mani";
        namesArray[1] = "Ganesh";
        namesArray[2] = "Venkat";
        namesArray[3] = "Suresh";
        namesArray[4] = "Venkat";
        Console.WriteLine("All names in the array:");
        for (int i = 0; i < namesArray.Length; i++)
        {
            Console.WriteLine(namesArray[i]);
        }
        Console.Write("\nEnter a name to search in the array: ");
        string searchName = Console.ReadLine();
        bool isNamePresent = false;
        for (int i = 0; i < namesArray.Length; i++)
        {
            if (namesArray[i].Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"The name is present in array at index {i}");
                isNamePresent = true;
                break;
            }
        }

        if (!isNamePresent)
        {
            Console.WriteLine("The name is not present in array");
        }
        isNamePresent = false;
        foreach (string name in namesArray)
        {
            if (name.Equals(searchName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("The name is present in array");
                isNamePresent = true;
                break;
            }
        }

        if (!isNamePresent)
        {
            Console.WriteLine("The name is not present in array");
        }
    }
}
