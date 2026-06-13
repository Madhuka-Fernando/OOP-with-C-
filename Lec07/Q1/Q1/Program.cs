using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a class called animal. which is the base class of dog.
//if every animal has a behavior called speak and an attribute called name impliment then in the bellow code.
//In the program create a dog name scooby when ever its speak it will say "scooby dooby dooo" .
//Impliment this funtinality in the bellow code create a separate driver class and a main method to impliment this functinality.

public class animal
{
    public void speak()
    {
     
    }

    public string name; 
}

public class dog : animal
{
    public void speak()
    {
        Console.WriteLine("Scooby Dooby Dooo");
    }

    public dog(string Nm)
    {
        name = Nm;
    }

    public void Name()
    {
        Console.WriteLine($"Name : {name}");
    }

}

public class driver
{
    public static void Main(string[] args)
    {
        dog dog1 = new dog("Scooby");
        dog1.Name();
        dog1.speak();



        Console.Read();
    }

}
