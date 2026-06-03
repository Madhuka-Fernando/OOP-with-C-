// Create a c# program to display "*" patterns for a given number of lines.

using System;

public class Q2
{
    static void Main(string[] arg)
    {
        int num;
        
        Console.Write("Enter the number of line you want : ");
        num = Convert.ToInt16(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*"); 
            }
            Console.WriteLine(); 
        }
        

    }
}