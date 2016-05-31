using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ExtractSentences
{
    static void Main()
    {
        string inputPattern = Console.ReadLine();
        string inputText = Console.ReadLine();

        List<string> sentences = new List<string>();
        int index = 0;

        sentences = inputText
            .Split('.')
            .ToList();

        for (int i = 0; i < sentences.Count; i++)
        {
            sentences[i] = sentences[i] + '.';
        }

        StringBuilder outputText = new StringBuilder();

        foreach (string sentance in sentences)
        {
            index = sentance.IndexOf(inputPattern, StringComparison.InvariantCultureIgnoreCase);

            while (index >= 0)
            {
                if (index == 0)
                {
                    if (!char.IsLetter(sentance[index + inputPattern.Length]))
                    {
                        outputText.Append(sentance);
                        break;
                    }
                    else
                    {
                        index = sentance.IndexOf(inputPattern, index + inputPattern.Length, StringComparison.InvariantCultureIgnoreCase);
                    }
                }
                else
                {
                    if (!char.IsLetter(sentance[index - 1]) && !char.IsLetter(sentance[index + inputPattern.Length]))
                    {
                        outputText.Append(sentance);
                        break;
                    }
                    else
                    {
                        index = sentance.IndexOf(inputPattern, index + inputPattern.Length, StringComparison.InvariantCultureIgnoreCase);
                    }
                }
            }
        }
        if (outputText.Length > 0)
        {
            if (outputText[0] == ' ')
            {
                outputText.Remove(0, 1);
            }
        }
        Console.WriteLine(outputText.ToString());
    }
}