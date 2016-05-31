using System;
using System.Linq;

class NumberAsArray
{
    static void Main()
    {
        string inputLine = Console.ReadLine();
        var lenght = new int[2];

        lenght = inputLine
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();

        var firstArray = new int[lenght[0]];
        var secondArray = new int[lenght[1]];

        inputLine = Console.ReadLine();
        firstArray = ReadInput(inputLine, lenght[0]);

        inputLine = Console.ReadLine();
        secondArray = ReadInput(inputLine, lenght[1]);

        int newArrayLength = Math.Max(firstArray.Length, secondArray.Length) + 1;
        var resultArray = new int[newArrayLength];

        resultArray = CalculateSum(firstArray, secondArray, newArrayLength);

        PrintArray(resultArray);                
    }

    private static void PrintArray(int[] resultArray)
    {
        if (resultArray[resultArray.Length - 1] == 0)
        {
            for (int i = 0; i < resultArray.Length - 1; i++)
            {
                Console.Write("{0} ", resultArray[i]);
            }
        }
        else
        {
            foreach (var c in resultArray)
            {
                Console.Write("{0} ", c);
            }
        }
    }

    private static int[] CalculateSum(int[] firstArray, int[] secondArray, int newArrayLength)
    {
        var result = new int[newArrayLength];
        if (firstArray.Length >= secondArray.Length)
        {
            for (int i = 0; i < secondArray.Length; i++)
            {
                firstArray[i] = firstArray[i] + secondArray[i];
            }
            for (int i = 0; i < firstArray.Length; i++)
            {
                result[i] = firstArray[i];
            }
        }
        else
        {
            for (int i = 0; i < firstArray.Length; i++)
            {
                secondArray[i] = firstArray[i] + secondArray[i];
            }
            for (int i = 0; i < secondArray.Length; i++)
            {
                result[i] = secondArray[i];
            }
        }

        int ednoNaUm = 0;
        for (int i = 0; i < newArrayLength; i++)
        {
            if ((result[i] + ednoNaUm) > 9)
            {
                result[i] = (result[i] + ednoNaUm) % 10;
                ednoNaUm = 1;
            }
            else
            {
                result[i] = result[i] + ednoNaUm;
                ednoNaUm = 0;
            }
        }
        return result;
    }

    private static int[] ReadInput(string inputLine, int N)
    {
        var array = new int[N];

        array = inputLine
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();

        return array;
    }
}