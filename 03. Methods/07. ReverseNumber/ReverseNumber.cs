using System;

class ReverseNumber
{
    static void Main()
    {
        string inputNumber = Console.ReadLine();

        string revertedNum = RevertNumber(inputNumber);

        Console.WriteLine(revertedNum);
    }

    private static string RevertNumber(string inputNumber)
    {
        string temp = null;
        foreach (char c in inputNumber)
        {
            temp = c + temp;
        }
        return temp;
    }
}