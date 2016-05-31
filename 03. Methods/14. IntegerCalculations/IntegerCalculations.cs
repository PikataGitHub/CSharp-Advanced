using System;
using System.Linq;

class IntegerCalculations
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        var inputNumbers = new int[5];

        inputNumbers = inputLine
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();

        Console.WriteLine(GetMinValue(inputNumbers));
        Console.WriteLine(GetMaxValue(inputNumbers));
        Console.WriteLine("{0:F2}", GetAverageValue(inputNumbers));
        Console.WriteLine(GetSum(inputNumbers));
        Console.WriteLine(GetProduct(inputNumbers));
    }

    private static long GetProduct(int[] inputNumbers)
    {
        long product = inputNumbers[0];
        for (int i = 1; i < inputNumbers.Length; i++)
        {
            product *= inputNumbers[i];
        }
        return product;
    }

    private static int GetSum(int[] inputNumbers)
    {
        int sum = inputNumbers[0];
        for (int i = 1; i < inputNumbers.Length; i++)
        {
            sum += inputNumbers[i];
        }
        return sum;
    }

    private static double GetAverageValue(int[] inputNumbers)
    {
        double average = inputNumbers[0];
        for (int i = 1; i < inputNumbers.Length; i++)
        {
            average += inputNumbers[i];
        }
        average = average / inputNumbers.Length;
        return average;
    }

    private static int GetMaxValue(int[] inputNumbers)
    {
        int maxValue = inputNumbers[0];
        for (int i = 1; i < inputNumbers.Length; i++)
        {
            if (inputNumbers[i] > maxValue)
            {
                maxValue = inputNumbers[i];                
            }
        }
        return maxValue;
    }

    private static int GetMinValue(int[] inputNumbers)
    {
        int minValue = inputNumbers[0];
        for (int i = 1; i < inputNumbers.Length; i++)
        {
            if (inputNumbers[i] < minValue)
            {
                minValue = inputNumbers[i];
            }
        }
        return minValue;
    }
}