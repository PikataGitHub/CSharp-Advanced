using System;

class ParseTags
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        string patternStart = "<upcase>";
        string patternEnd = "</upcase>";

        int startIndex = inputText.IndexOf(patternStart);
        int endIndex = inputText.IndexOf(patternEnd);

        while (startIndex > 0 && endIndex > 0)
        {
            string textToParse = inputText.Substring(startIndex + patternStart.Length, endIndex - startIndex - patternStart.Length);
            
            inputText = inputText.Replace(patternStart + textToParse + patternEnd, textToParse.ToUpper());
                        
            startIndex = inputText.IndexOf(patternStart);
            endIndex = inputText.IndexOf(patternEnd);
        }
        Console.WriteLine(inputText);
    }
}