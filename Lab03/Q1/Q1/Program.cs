namespace Q1;

class Program
{
    static int Factorial(int num)
    {
        int tot = 1;

        for (int i = 1; i <= num; i++)
        {
            tot *= i;
        }

        return tot;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a Positive Number : ");
        int num = Int32.Parse(Console.ReadLine());


        int output = Factorial(num);

        Console.WriteLine($"Factorial of {num} is {output}");
        

        Console.ReadLine();
    }
}

