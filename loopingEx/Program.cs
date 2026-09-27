using System;

class Program
{
    static void Main()
    {
        // Console.WriteLine("for loop statement");
        // for (int i = 1; i <= 10; i++)
        // {
        //     Console.WriteLine(i);
        // }

        // int x = 1;
        // Console.WriteLine("while loop statement...");
        // while(x <= 10)
        // {
        //     Console.WriteLine(x);
        //     x++;
        // }

        // int x = 1;

        // do
        // {
        //     Console.WriteLine(x);
        //     x++;
        // }while(x <= 10);

        // whileloopEx.run();

        int[] numbers = {10,20,30,40,50};

        foreach(int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}