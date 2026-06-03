namespace Q3;

class Program
{
    static void Main(string[] args)
    {
        double price;
        int qty;

        Console.Write("Enter the item price : ");
        price = Double.Parse(Console.ReadLine());

        Console.Write("Enter the quantity you purchased : ");
        qty = Int32.Parse(Console.ReadLine());

        double tot = price * qty;

        Console.WriteLine($"Your total price is {tot}");

        Console.Read();
    }
}

