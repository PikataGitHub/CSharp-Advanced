using System;

class MergeSort
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

        // Call Sort Method
        MergeSortMethod(array, 0, N - 1);

        // Output array
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine(array[i]);
        }
    }

    public static void MergeSortMethod(int[] input, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSortMethod(input, left, middle);
            MergeSortMethod(input, middle + 1, right);

            //Merge
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;
            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }
        }
    }
}