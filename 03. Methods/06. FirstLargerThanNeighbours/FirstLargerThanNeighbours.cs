using System;
using System.Linq;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var inputArray = new int[N];
        string inputLine = Console.ReadLine();

        inputArray = inputLine
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();

        int firstIndex = GetIndex(inputArray);

        Console.WriteLine(firstIndex);
    }

    private static int GetIndex(int[] inputArray)
    {
        int firstIndexValue = -1;

        for (int i = 1; i < inputArray.Length - 1; i++)
        {
            if (inputArray[i]>inputArray[i-1]&& inputArray[i] > inputArray[i + 1])
            {
                firstIndexValue = i;
                return firstIndexValue;
            }
        }
        return firstIndexValue;
    }
}