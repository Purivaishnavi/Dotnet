using System;
public class AreaOfPolygon
{ 
    class polygonal{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number of side:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter length of one side:");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Apothem:");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Area of polygonal" +(0.5*a*b*c));
    }
    }
}