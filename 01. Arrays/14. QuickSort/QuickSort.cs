using System;

class QuickSort
{
    static void Main()
    {
        // Read Input
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];
        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        // Call QuickSort Method
        QuickSortRecursiveMethod(array, 0, N - 1);

        // Output array
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public static void QuickSortRecursiveMethod(int[] input, int left, int right)
    {
        if (left < right)
        {
            int q = PartitionAndSwapMethod(input, left, right);
            QuickSortRecursiveMethod(input, left, q - 1);
            QuickSortRecursiveMethod(input, q + 1, right);
        }
    }

    private static int PartitionAndSwapMethod(int[] input, int left, int right)
    {
        int pivot = input[right];
        int temp;
        int i = left;

        for (int j = left; j < right; j++)
        {
            if (input[j] <= pivot)
            {
                temp = input[j];
                input[j] = input[i];
                input[i] = temp;
                i++;
            }
        }

        input[right] = input[i];
        input[i] = pivot;

        return i;
    }
}