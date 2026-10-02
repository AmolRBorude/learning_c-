using System;

class Program
{
    // Method 1
    public void Add(int a, int b)
    {
        Console.WriteLine("Sum: " + (a + b));
    }

    // Method 2
    public void Add(int a, int b, int c)
    {
        Console.WriteLine("Sum: " + (a + b + c));
    }

    // Method 3
    public void Add(double a, double b)
    {
        Console.WriteLine("Sum: " + (a + b));
    }

    static void Main()
    {
        Program c = new Program();

        c.Add(10, 20);
        c.Add(10, 20, 30);
        c.Add(10.5, 20.5);
    }
}