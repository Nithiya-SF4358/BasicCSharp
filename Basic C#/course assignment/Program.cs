using System;
namespace assignment;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number 1:");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number 2:");
        int num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Addition: "+(num1+num2));
        Console.WriteLine("Subtraction: "+(num1-num2));
        Console.WriteLine("Multiplication: "+(num1*num2));
        Console.WriteLine("Division: "+(num1/num2));
        Console.WriteLine("Modulus: "+(num1%num2));
    }
}