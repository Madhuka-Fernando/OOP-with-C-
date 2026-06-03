namespace Q3;

class Program
{
    static int sum(int num)
    {
        int tot = 0;
        for(int i = 1; i <= num; i++)
        {
            tot += i;
        }
        return tot;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        int num = Int32.Parse(Console.ReadLine());

        int output = sum(num);

        Console.WriteLine($"Total of 1 to {num} is {output}");

        Console.Read();
    }
}

