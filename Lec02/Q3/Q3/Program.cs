// Create a c# program to display a students grade when their module marks are entered (A>75,B>60,C>50,C->=40,F<40)
namespace Q3;

class Program
{
    static void Main(string[] args)
    {
        int marks;
        
        Console.Write("Enter student marks : ");
        marks = Int16.Parse(Console.ReadLine());

        if (marks > 75)
        {
            Console.Write("Grade : A");
        }
        else if (marks > 60)
        {
            Console.Write("Grade : B");
        }
        else if (marks > 50)
        {
            Console.Write("Grade : C");
        }
        else if (marks >= 40)
        {
            Console.Write("Grade : C-");
        }
        else
        {
            Console.Write("Failed");
        }

        Console.readline();
    }
}