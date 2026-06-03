using System;

class user
{
    //Creating an array
    int[] nums = new int[5];

    //taking 5 inputs
    public void takingInputs()
    {
        for(int i = 0; i < 5; i++)
        {
            Console.Write($"Enter the {i+1} number : ");

            //Storing in an array 
            nums[i] = Int32.Parse(Console.ReadLine());


        }
    }
    //Display the array
    public void display()
    {
        for(int i = 0; i < 5; i++)
        {
            Console.Write($"{nums[i]}  ");
        }
        Console.WriteLine();
        
    }
    

    //Calculating the sum
    public int sum()
    {
        int tot = 0;
        for (int i =0; i < 5; i++)
        {
            tot += nums[i];
        }
        return tot;
    }

}

class run_program
{
    public static void Main(string[] arg)
    {
        user check1 = new user();
        check1.takingInputs();
        check1.display();
        Console.WriteLine($"Sum of the array is {check1.sum()}");

        Console.Read();
    }
}


