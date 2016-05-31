using System;
using System.Linq;

class GetLargestNumber
{
    static void Main()
    {
        var inputMatrix = new int[3];
        string inputLines = Console.ReadLine();
        
        inputMatrix = inputLines
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();

        int maxValue = GetMax(inputMatrix[0],inputMatrix[1]);
        maxValue = GetMax(maxValue, inputMatrix[2]);

        Console.WriteLine(maxValue);
    }

    private static int GetMax(int firstNumber, int secondNumber)
    {
        int max = 0;
        if (firstNumber<=secondNumber)
        {
            max = secondNumber;
        }
        else
        {
            max = firstNumber;
        }
        return max;
    }
}