using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        StringBuilder sb = new StringBuilder();
        sb.Append(inputText[0]);

        for (int i = 1; i < inputText.Length; i++)
        {
            if (inputText[i-1]!=inputText[i])
            {
                sb.Append(inputText[i]);
            }
        }
        Console.WriteLine(sb.ToString());
    }
}