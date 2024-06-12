using System;
namespace MyApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the age :");
            int age= Convert.ToInt32(Console.ReadLine());
            if(age==6){
                Console.WriteLine("Allowed for admission");
            }
            else if(age!=6){
                Console.WriteLine("Not allowed for admission");

            }
      }
        
    }
}    
