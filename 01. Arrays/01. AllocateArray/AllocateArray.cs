using System;

class AllocateArray
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] arrayN = new int[N];

        for (int i = 0; i < N; i++)
        {
            arrayN[i] = arrayN[i] + i;
            arrayN[i] = arrayN[i] * 5;

            Console.WriteLine(arrayN[i]);
        }
    }
}