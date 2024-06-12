using System;
namespace Swap{

    class Swapp{
        static void Main(string[] args){
            int a,b;
            Console.WriteLine("Swapping.");
            Console.WriteLine("Enter A :");
            a=Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Enter B:");
            b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before Swpping: A = " +a +" B = "+b);

            a =  a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("After Swapping: A = "+a +" B = "+b);

        }
    }
}