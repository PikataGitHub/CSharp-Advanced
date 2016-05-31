using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string inputLine = Console.ReadLine();

        var inputArray = new int[N];

        inputArray = inputLine
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();

        int count = CalculateLargerThanNeighbours(inputArray);
        Console.WriteLine(count);

    }

    private static int CalculateLargerThanNeighbours(int[] inputArray)
    {
        int counter = 0;

        for (int i = 1; i < inputArray.Length - 1; i++)
        {
            if (inputArray[i] > inputArray[i - 1] && inputArray[i] > inputArray[i + 1])
            {
                counter++;
            }
        }
        return counter;
    }
}