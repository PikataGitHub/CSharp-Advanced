using System;

class IndexOfLetters
{
    static void Main()
    {
        //Input data
        char[] arrayOfLetters = new char[26];

        for (int i = 97; i <= 122; i++)
        {
            arrayOfLetters[i - 97] = (char)i;
        }

        string inputWord = Console.ReadLine();

        foreach (char c in inputWord)
        {
            for (int i = 0; i < 26; i++)
            {
                if (c==arrayOfLetters[i])
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}