using System;
namespace ABC {
    class fibo{
        static void Main(string[] args){
            int a1,a2,a3,number;
            Console.WriteLine("Fibonacci Series:");
            Console.Write("Enter the First element:");
            a1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Second element:");
            a2=Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of elements: ");    
            number = Convert.ToInt32(Console.ReadLine());  
             Console.Write(a1+" "+a2+" "); //printing 0 and 1    
             for(int i=2;i<number;++i) //loop starts from 2 because 0 and 1 are already printed    
             {    
                    a3=a1+a2;    
                    Console.WriteLine(n3+" ");    
                    a1=a2;    
                    a2=a3;    
            }    
      }  
   }
}