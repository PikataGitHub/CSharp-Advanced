using System;

    class MaximalSum
    {
        static void Main()
        {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }


        int maxSoFar = 0;
        int currMax = 0;

        for (int i = 0; i < N; i++)
        {
            currMax = Math.Max(array[i], currMax + array[i]);
            maxSoFar = Math.Max(currMax, maxSoFar);
        }
        Console.WriteLine(maxSoFar);
    }
    }