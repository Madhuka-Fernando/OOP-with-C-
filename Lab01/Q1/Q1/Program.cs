namespace Q1;

class Program
{
    static void Main(string[] args)
    {
        double width;
        double height;

        Console.Write("Enter the Width : ");
        width = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the Height : ");
        height = Double.Parse(Console.ReadLine());

        double area = width * height;

        Console.WriteLine($"Area is {area}");


        Console.Read();
    }
}

