using System;

class EnglishNumber
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int lastDigit = N % 10;

        string digitInEnglish = EnglishDigit(lastDigit);
        Console.WriteLine(digitInEnglish);
    }

    private static string EnglishDigit(int lastDigit)
    {
        string digitName = null;
        switch (lastDigit)
        {
            case 0: digitName = "zero"; break;
            case 1: digitName = "one"; break;
            case 2: digitName = "two"; break;
            case 3: digitName = "three"; break;
            case 4: digitName = "four"; break;
            case 5: digitName = "five"; break;
            case 6: digitName = "six"; break;
            case 7: digitName = "seven"; break;
            case 8: digitName = "eight"; break;
            case 9: digitName = "nine"; break;
            default: Console.WriteLine("There is something terribly wrong"); break;
        }
        return digitName;
    }
}