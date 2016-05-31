using System;

class SelectionSort
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int K = int.Parse(Console.ReadLine());
        int[] numbers = new int[N];

        int tempMinElement = 0;
        int tempIndex = 0;

        for (int i = 0; i < N; i++) //Input
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Start
        for (int j = 0; j < N; j++)
        {

            tempMinElement = numbers[j];
            tempIndex = j;

            //Find min. elem. in array and position
            for (int i = (j + 1); i < N; i++)
            {
                if (tempMinElement >= numbers[i])
                {
                    tempMinElement = numbers[i];
                    tempIndex = i;
                }
            }

            // swap !!!!
            numbers[tempIndex] = numbers[j];
            numbers[j] = tempMinElement;
        }
        int sum = 0;

        for (int i = (N-1); i > (N- K-1) ; i--) 
        {
            sum = sum + numbers[i];
        }
        Console.WriteLine(sum);
    }
}