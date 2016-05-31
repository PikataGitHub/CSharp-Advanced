using System;

class SelectionSort
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
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

        int tempFrequentNumber = numbers[0];
        int frequentNumber = numbers[0];
        int tempTimes = 1;
        int times = 1;

        for (int i = 1; i < N; i++) //Output
        {
            if (tempFrequentNumber == numbers[i])
            {
                tempTimes++;               
            }
            else
            {
                if (tempTimes > times)
                {
                    frequentNumber = tempFrequentNumber;
                    times = tempTimes;
                }
                tempFrequentNumber = numbers[i];
                tempTimes = 1;
            }
        }

        if (tempTimes > times)
        {
            frequentNumber = tempFrequentNumber;
            times = tempTimes;
        }

        Console.WriteLine("{0} ({1} times)", frequentNumber, times);
    }
}