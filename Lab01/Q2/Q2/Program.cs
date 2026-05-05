namespace Q2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number 1 : ");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Enter number 2 : ");
        int num2 = Int32.Parse(Console.ReadLine());

        int tot = num1 + num2;

        Console.WriteLine($"Final Answer: {tot}");

        Console.Read();

    }
}

