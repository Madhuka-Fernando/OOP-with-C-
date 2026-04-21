using System;

public class lab1
{
    public static void Main(string[] arg)
    {
        int width;
        int height;
        int area;
        
        Console.Write("Enter the width : ");
        width = Int16.Parse(Console.ReadLine());
        
        Console.Write("Enter the height : ");
        height = Int16.Parse(Console.ReadLine());

        area = width * height;
        
        Console.WriteLine($"Area is {area}");
    }
}
