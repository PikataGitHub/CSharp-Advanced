using System;
using System.Collections;

class PrimeNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int sqrtN = (int)Math.Sqrt(N);

        BitArray primeNumbers = new BitArray(N, true);
        BitArray primeNumbersTemp = new BitArray(N, true);

        // Set all values that are multiple of 2 as Not Primes
        for (int i = 3; i < N; i = i + 2)
        {
            primeNumbersTemp.Set(i, false);
        }

        // Set all values that are multiple of 3 as Not Primes
        int q = 3;
        while (3 * q <= N)
        {
            primeNumbersTemp.Set(3 * q - 1, false);
            q = q + 2;
        }

        //Proceed if N>=25
        primeNumbers = primeNumbers.And(primeNumbersTemp);
        for (int p = 5; p <= sqrtN; p = p + 2)
        {
            if (primeNumbers.Get(p - 1) == true)
            {
                q = p;
                while (p * q <= N)
                {
                    if (primeNumbers.Get(q - 1) == true)
                    {
                        primeNumbersTemp.Set(p * q - 1, false);
                    }
                    q = q + 2;
                }
                primeNumbers = primeNumbers.And(primeNumbersTemp);
            }
        }

        //Print last prime in the sequence
        for (int i = N - 1; i >= 0; i--)
        {
            if (primeNumbersTemp.Get(i) == true)
            {
                Console.WriteLine(i + 1);
                break;
            }
        }
    }
}