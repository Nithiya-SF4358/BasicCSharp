using System;
namespace assignment;
class Program{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the size:");
        int size1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the elements:");
        int []arr1=new int[size1];
        for(int i=0;i<size1;i++){
            arr1[i]=Convert.ToInt32(Console.ReadLine());
            }
        Console.WriteLine("EVEN NUMBERS:");
        for(int i=0;i<arr1.Length;i++){
            if(arr1[i]%2==0){
                if(arr1[i]%2==0){
                    Array.Sort(arr1);
                    Console.WriteLine(arr1[i]);
                }
            }
        }
        Console.WriteLine("ODD NUMBERS:");
        for(int i=0;i<arr1.Length;i++){
            if(arr1[i]%2!=0){
                if(arr1[i]%2!=0){
                    Array.Sort(arr1);
                    Console.WriteLine(arr1[i]);
                }
            }
        }
    }
}                
                