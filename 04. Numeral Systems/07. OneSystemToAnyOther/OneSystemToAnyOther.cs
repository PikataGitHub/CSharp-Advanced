using System;
using System.Collections.Generic;

class OneSystemToAnyOther
{
    static void Main()
    {
        int numberS = int.Parse(Console.ReadLine());
        string numberN = Console.ReadLine();
        int numberD = int.Parse(Console.ReadLine());
        long numberAsDec = 0;

        numberAsDec = ConverToDecima(numberN, numberS);
        
        numberN = ConvertToAny(numberAsDec, numberD);
        Console.WriteLine(numberN);
    }

    private static string ConvertToAny(long numberAsDec, int numberD)
    {
        const string Digits = "0123456789ABCDEF";
        List<char> numberArray = new List<char>();
        string result = "";

        while (numberAsDec > 0)
        {
            int remainder = (int)(numberAsDec % numberD);
            numberArray.Add(Digits[remainder]);
            numberAsDec = numberAsDec / numberD;
        }

        for (int i = numberArray.Count - 1; i >= 0; i--)
        {
            result += numberArray[i];
        }

        return result;
    }

    private static long ConverToDecima(string numberN, int numberS)
    {
        const string Digits = "0123456789ABCDEF";
        long result = 0;
        long multiplier = 1;

        for (int i = numberN.Length - 1; i >= 0; i--)
        {
            char charDigit = numberN[i];
            int digit = Digits.IndexOf(charDigit);
            result += digit * multiplier;
            multiplier *= numberS;
        }

        return result;
    }
}