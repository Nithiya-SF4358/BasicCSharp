using System;
namespace assignment;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number 1:");
        int num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number 2:");
        int num2=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the number 3:");
        int num3=Convert.ToInt32(Console.ReadLine());
        if((num1>num2)&&(num1>num3)){
            Console.WriteLine(num1+"is greater.");
        }else if((num2>num1)&&(num2>num3)){
            Console.WriteLine(num2+"is greater.");
        }else{
            Console.WriteLine(num3+"is greater.");
        }
    }
}