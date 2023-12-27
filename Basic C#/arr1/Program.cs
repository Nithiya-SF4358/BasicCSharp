using System;

        public class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("-----------ASSIGNMENT 1----------");
                Console.WriteLine("Enter the size:");
                int size=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the elements:");
                int []arr=new int[size];
                for(int i=0;i<size;i++){
                    arr[i]=Convert.ToInt32(Console.ReadLine());
                }
                for(int i=0;i<size-1;i++){
                    for(int j=0;j<size-i-1;j++){
                        if(arr[j]>arr[j+1]){
                            int temp=arr[j];
                            arr[j]=arr[j+1];
                            arr[j+1]=temp;
                        }
                    }
                }
                foreach(int num in arr){
                    Console.Write(num+" ");
                }Console.WriteLine();
                Console.WriteLine("-----------ASSIGNMENT 1----------");
                Console.WriteLine("Enter the size:");
                int size1=Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the elements:");
                int []arr1=new int[size1];
                for(int i=0;i<size1;i++){
                    arr1[i]=Convert.ToInt32(Console.ReadLine());
                }
                int oddcount=0;
                int evencount=0;
                for(int i=0;i<size1;i++){
                    if(arr1[i]%2==0){
                        evencount++;
                    }else{
                        oddcount++;
                    }
                }
            }
        }
            