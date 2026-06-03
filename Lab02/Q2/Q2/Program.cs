namespace Q2;

class Program
{
    static void Main(string[] args)
    {
        double tot = 0;
        for (int i = 1; i <= 5; i++)
        {
            double price;
            Console.Write($"Enter the {i} product price : ");
            price = Double.Parse(Console.ReadLine());

            double dis = 0;
            if (price > 1000)
            {
                dis = price * 0.1;
                Console.WriteLine($"Price of item {i} is {price}, Discount is {dis}");
            }
            else
            {
                Console.WriteLine($"Price of item {i} is {price}, Discount is {dis}");
            }
            price -= dis;
            tot += price;
        }
        Console.WriteLine($"Total price is {tot}");

        Console.Read();
    }
}

