namespace Q1;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the 1st number : ");
        int num1 = Int32.Parse(Console.ReadLine());

        Console.Write("Enter the 2nd number : ");
        int num2 = Int32.Parse(Console.ReadLine());


        if (num2 == 0)
        {
            Console.WriteLine("Division by zero is not allowed . ");
        }
        else
        {
            if (num1 % num2 == 0)
            {
                Console.WriteLine($"{num1} is divisible by {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} is not divisible by {num2}");
            }
        }

        Console.ReadLine();
        
    }
}

