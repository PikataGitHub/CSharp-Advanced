using System;
using System.Linq;

class SortingArray
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

        int indexOfMax = 0;
        for (int i = 0; i < N; i++)
        {
            indexOfMax = GetIndexOfMaxElement(inputArray, i);
            inputArray = SwapElements(inputArray, indexOfMax, i);
        }
        PrintArray(inputArray);
    }

    private static void PrintArray(int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.Write("{0} ", inputArray[i]);
        }
    }

    private static int[] SwapElements(int[] inputArray, int indexOfMax, int i)
    {
        int temp = inputArray[indexOfMax];
        inputArray[indexOfMax] = inputArray[inputArray.Length - 1 - i];
        inputArray[inputArray.Length - 1 - i] = temp;
        return inputArray;
    }

    private static int GetIndexOfMaxElement(int[] inputArray, int i)
    {
        int index = 0;
        for (int j = 1; j < inputArray.Length - i; j++)
        {
            if (inputArray[index] < inputArray[j])
            {
                index = j;
            }
        }
        return index;
    }
}