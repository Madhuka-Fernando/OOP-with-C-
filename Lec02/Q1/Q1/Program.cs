//Create a program in c# to take in 2 numbers and display the multiplied value

using System;

public class Lec02
{
    static void Main(string[] arg)
    {
        int num1;
        int num2;
        
        Console.Write("Enter the first number : ");
        num1 = Int16.Parse(Console.ReadLine());
        
        Console.Write("Enter the second number : ");
        num2 = Int16.Parse(Console.ReadLine());

        int output = num1 * num2;
        
        Console.WriteLine($"Output is {output}");
    }
}