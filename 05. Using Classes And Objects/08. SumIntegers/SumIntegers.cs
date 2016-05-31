using System;
using System.Linq;

class SumIntegers
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        var inputIntegers = new int[1000];
        int sum = 0;

        inputIntegers = inputLine
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();
        
        foreach (int number in inputIntegers)
        {
            sum = sum + number;
        }
        Console.WriteLine(sum);        
    }
}