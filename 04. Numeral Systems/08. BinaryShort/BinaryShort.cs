using System;

class BinaryShort
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        int[] binaryArray = new int[16];
        long binaryDigit = 0;
        int counter = 0;
        long moduleN = Math.Abs(N);

        while (moduleN > 0)
        {
            binaryDigit = moduleN % 2;
            binaryArray[counter] = (int)binaryDigit;
            moduleN = moduleN / 2;
            counter++;
        }

        if (N < 0)
        {
            for (int i = 15; i >= 0; i--) //Bits Inverted
            {
                if (binaryArray[i] == 0)
                {
                    binaryArray[i] = 1;
                }
                else
                {
                    binaryArray[i] = 0;
                }
            }
            int p = 0;
            while (binaryArray[p] == 1) //Add one
            {
                binaryArray[p] = 0;
                p++;
            }
            binaryArray[p] = 1;
        }

        for (int i = 15; i >= 0; i--)
        {
            Console.Write(binaryArray[i]);
        }
    }
}
