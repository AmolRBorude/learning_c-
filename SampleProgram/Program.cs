using System;

class Employee
{
    public virtual void Work()
    {
        Console.WriteLine("Employee is working");
    }
}

class Program : Employee
{
    public override void Work()
    {
        Console.WriteLine("Developer is writing code");
    }

    static void Main()
    {
        Program d = new Program();

        d.Work();
    }
}