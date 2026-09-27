using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter any Integer :");
        int x = Convert.ToInt32(Console.ReadLine());


        if(x < 0)
        {
            Console.WriteLine("The number is negative...");
        }
        else
        {
            Console.WriteLine("The number is positive...");
        }
    }
}