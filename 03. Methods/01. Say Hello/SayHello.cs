using System;

class SayHello
{
    static void Main()
    {
        PrintGreetings();
    }

    static void PrintGreetings()
    {
        string inputName = Console.ReadLine();
        Console.WriteLine("Hello, {0}!", inputName);
    }
}