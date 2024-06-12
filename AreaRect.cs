using System;
 
 public class AreaOfRectangle
 {
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Length of rectangle");
        int Length  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Breadth of rectangle");
        int Breadth = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Area of rectangle:"+(Length*Breadth));
}   
} 
 