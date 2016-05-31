using System;

class BinarySearch
{
    static void Main()
    {
        //Read Input
        int N = int.Parse(Console.ReadLine());
        int[] sortedArray = new int[N];
        for (int i = 0; i < N; i++)
        {
            sortedArray[i] = int.Parse(Console.ReadLine());
        }
        int X = int.Parse(Console.ReadLine());

        //Search Algo
        int boundaryMin = 0;
        int boundaryMax = N - 1;


        while (boundaryMin <= boundaryMax)
        {
            int middleElem = (boundaryMin + boundaryMax) / 2;

            if (X == sortedArray[middleElem])
            {
                Console.WriteLine(middleElem);
                return;
            }
            else if (X < sortedArray[middleElem])
            {
                boundaryMax = middleElem - 1;
            }
            else if (X > sortedArray[middleElem])
            {
                boundaryMin = middleElem + 1;
            }
        }
        Console.WriteLine(-1);
    }
}