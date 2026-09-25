using System;

class Program
{
    static void Main()
    {
        int a = 20;
        int b = 10;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("Addition: " + (a + b));
        Console.WriteLine("Subtraction: " + (a - b));
        Console.WriteLine("Multiplication: " + (a * b));
        Console.WriteLine("Division: " + (a / b));
        Console.WriteLine("Modulus: " + (a % b));

        // Relational Operators
        Console.WriteLine("\nRelational Operators:");
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < b: " + (a < b));
        Console.WriteLine("a >= b: " + (a >= b));
        Console.WriteLine("a <= b: " + (a <= b));

        // Logical Operators
        bool x = true;
        bool y = false;

        Console.WriteLine("\nLogical Operators:");
        Console.WriteLine("x && y: " + (x && y));
        Console.WriteLine("x || y: " + (x || y));
        Console.WriteLine("!x: " + (!x));

        // Assignment Operators
        int c = 10;

        Console.WriteLine("\nAssignment Operators:");

        c += 5;
        Console.WriteLine("c += 5: " + c);

        c -= 3;
        Console.WriteLine("c -= 3: " + c);

        c *= 2;
        Console.WriteLine("c *= 2: " + c);

        c /= 4;
        Console.WriteLine("c /= 4: " + c);

        // Increment and Decrement
        int number = 5;

        Console.WriteLine("\nIncrement and Decrement:");

        number++;
        Console.WriteLine("After increment: " + number);

        number--;
        Console.WriteLine("After decrement: " + number);

        // Ternary Operator
        int age = 20;

        string result = age >= 18 ? "Adult" : "Minor";

        Console.WriteLine("\nTernary Operator:");
        Console.WriteLine(result);
    }
}