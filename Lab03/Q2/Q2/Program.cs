namespace Q2;

class Program
{
    static void multable(int n)
    {
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
    }


    static void Main(string[] args)
    {
        Console.Write("Enter a number : ");
        int num = Int32.Parse(Console.ReadLine());

        multable(num);

        Console.Read();
    }
}

