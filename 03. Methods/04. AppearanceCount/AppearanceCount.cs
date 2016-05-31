using System;
using System.Linq;

class AppearanceCount
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var inputArray = new int[N];
        string inputLines = Console.ReadLine();

        inputArray = inputLines
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();

        int X = int.Parse(Console.ReadLine());
        
        int counter = AppearanceCounter(inputArray, X);
        Console.WriteLine(counter);
    }

    private static int AppearanceCounter(int[] inputArray, int X)
    {
        int counter = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i]==X)
            {
                counter++;
            }
        }
        return counter;
    }
}