namespace Task01;

class Vehicle
{
    public string brand;
    public int wheels;

    public void sound()
    {
        Console.WriteLine("Bruuum Bruuuuuuuuuuuuuuuuuuuuuuum Bruuuuuuuuuuuuuuuuuuuuuuuuuum");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Vehicle car = new Vehicle();
        car.sound();
        car.wheels = 3;

        Console.WriteLine(car.wheels);

        Vehicle van = new Vehicle();
        van.sound();
        van.wheels = 6;

        Console.WriteLine(van.wheels);

        Console.ReadLine();



    }

}

