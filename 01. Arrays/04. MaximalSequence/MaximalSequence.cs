using System;

class MaximalSequence
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = new int[N];

        for (int i = 0; i < N; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        int counter = 1;
        int maxSequence = 0;
        for (int i = 1; i < N; i++)
        {
            if (array[i - 1] == array[i])
            {
                counter++;
                maxSequence = Math.Max(counter, maxSequence);
            }
            else
            {
                counter = 1;
            }
        }
        Console.WriteLine(maxSequence);
    }
}