using System;
using System.Linq;

class RemoveElementsFromArray
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        int[] sequence = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
            sequence[i] = 1;
        }

        for (int i = 1; i < N; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[j] <= array[i])
                {
                    if (sequence[i] < sequence[j] + 1)
                    {
                        sequence[i] = sequence[j] + 1;
                    }
                }
            }
        }
        Console.WriteLine(N - sequence.Max());
    }
}