using System;

class CompareArrays
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] firstArray = new int[N];
        int[] secondArray = new int[N];

        for (int i = 0; i < N; i++)
        {
            firstArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < N; i++)
        {
            secondArray[i] = int.Parse(Console.ReadLine());
        }
        bool isEqual = true;
        for (int i = 0; i < N; i++)
        {
            if (firstArray[i]==secondArray[i])
            {
                isEqual = true;
            }
            else
            {
                isEqual = false;
                break;
            }
        }
        if (isEqual)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}