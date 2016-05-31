using System;
using System.Linq;

class MaximalSum
{
    static void Main()
    {
        string dimentionsOfArray = Console.ReadLine();
        var arrayDimentions = dimentionsOfArray
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();
        int N = arrayDimentions[0];
        int M = arrayDimentions[1];
        
        var inputMatrix = new int[N][];
        for (int i = 0; i < N; i++)
        {
            inputMatrix[i] = new int[M];
        }

        for (int i = 0; i < N; i++)
        {
            string inputLines = null;
            inputLines = Console.ReadLine();
            inputMatrix[i] = inputLines
                .Split(' ')
                .Select(z => Convert.ToInt32(z))
                .ToArray();
        }
        int maxSum = Int32.MinValue;
        
        for (int i = 1; i < N-1; i++)
        {
            for (int j = 1; j < M-1; j++)
            {
                int tempSum = 0;
                for (int p = -1; p < 2; p++)
                {
                    for (int q = -1; q < 2; q++)
                    {
                        tempSum = tempSum + inputMatrix[i + p][j + q];
                    }
                }
                if (maxSum<tempSum)
                {
                    maxSum = tempSum;
                }
            }           
        }
        Console.WriteLine(maxSum);
    }
}