using System;
using System.Collections.Generic;

class NFactorial
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        List<int> arrayOfDigits = new List<int>(new int[200000]);
        arrayOfDigits[0] = 1;
        
        for (int multiplier = 1; multiplier <= N; multiplier++)
        {
            arrayOfDigits = MultiplyArrayByNumber(arrayOfDigits, multiplier);            
        }
                
        PrintArray(arrayOfDigits);  
    }

    private static void PrintArray(List<int> arrayOfDigits)
    {
        for (int i = arrayOfDigits.Count; i >= 0; i--)
        {
            if (arrayOfDigits[i - 1] > 0)
            {
                for (int j = i-1; j >= 0; j--)
                {
                    Console.Write(arrayOfDigits[j]);
                }
                break;
            }
        }
    }

    private static List<int> MultiplyArrayByNumber(List<int> arrayOfDigits, int multiplier)
    {
        for (int i = 0; i < arrayOfDigits.Count; i++)
        {
            arrayOfDigits[i] = multiplier * arrayOfDigits[i];
        }
        for (int i = 0; i < arrayOfDigits.Count; i++)
        {
            if (arrayOfDigits[i] > 9)
            {
                arrayOfDigits[i + 1] = arrayOfDigits[i + 1] + arrayOfDigits[i] / 10;
                arrayOfDigits[i] = arrayOfDigits[i] % 10;
            }
        }
        return arrayOfDigits;
    }
}
