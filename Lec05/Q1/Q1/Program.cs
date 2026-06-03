//Create a class for a dog where each dog has a name when an object is created the dogs name should be assigned and printed

namespace Q1;

class dog
{
    public dog(string name)
    {
        Console.WriteLine($"Dog name is : {name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        dog dog1 = new dog("Tommy");
        dog dog2 = new dog("Shadow");


        Console.Read();
    }
}

