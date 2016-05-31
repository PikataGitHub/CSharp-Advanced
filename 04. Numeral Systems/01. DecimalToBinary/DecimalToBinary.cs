using System;
using System.Collections.Generic;

class DecimalToBinary
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        List<byte> binaryArray = new List<byte>();
        long binaryDigit = 0;

        while (N > 0)
        {
            binaryDigit = N % 2;
            N = N / 2;
            binaryArray.Add((byte)binaryDigit);
        }

        for (int i = binaryArray.Count - 1; i >= 0; i--)
        {
            Console.Write(binaryArray[i]);
        }
    }
}
