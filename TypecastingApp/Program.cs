using System;

class Program
{
    static void Main(string[] args)
    {
        // Implicit casting
        int number = 100;
        double value = number;

        Console.WriteLine("Integer value: " + number);
        Console.WriteLine("Double value: " + value);

        // Explicit casting
        double price = 99.99;
        int newPrice = (int)price;

        Console.WriteLine("Original double value: " + price);
        Console.WriteLine("After casting to int: " + newPrice);
    }
}