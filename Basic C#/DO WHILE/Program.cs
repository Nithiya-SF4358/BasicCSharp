using System;
using System.Globalization;
namespace ex{
    class Program{
        public static void Main(string[] args)
        {
            string input;
            do{
                Console.WriteLine("Enter the number: ");
                int num=Convert.ToInt32(Console.ReadLine());
                if(num%2==0){
                    Console.WriteLine("even");
                }else{
                    Console.WriteLine("odd");
                }
                Console.WriteLine("Do you want to continue:");
                input=Console.ReadLine();
                while(input !="No" && input!="yes"){
                            Console.WriteLine("The provided input is wrong and please enter a valid input.");
                            input=Console.ReadLine();
                }
                if(input=="No"){
                        break;
                }
            }while(input=="yes");
        }
    }
}
