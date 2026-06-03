namespace Q1;

public class BankAccount
{
    public string Name;
    public int Age;
    private int Balance;

    //constructor
    public BankAccount()
    {
        Balance = 1000;
    }

    public int getBalance()
    {
        return Balance;
    }

    public void setBalance(int value)
    {
        if (value > 0)
        {
            Balance = value;
        }
        else
        {
            Console.WriteLine("Insufficuent Balance !!!");
        }
        
    }

    public int CheckBalance()
    {
        return getBalance();

    }

    public void withdraw(int value)
    {
        int bal = getBalance();
        bal -= value;
        setBalance(bal);
    }


}

public class Madhuka
{
    public static void Main(string[] arg)
    {
        //create an object of the class BankAccount
        BankAccount Acc1 = new BankAccount();

        Console.WriteLine($"Account Name : {Acc1.Name}");
        Console.WriteLine($"Account Age : {Acc1.Age}");
        Console.WriteLine($"Account Balance : {Acc1.CheckBalance()}");
        Acc1.withdraw(50000);
        Console.WriteLine($"Account Balance : {Acc1.CheckBalance()}");


        Console.Read();
    }
}


