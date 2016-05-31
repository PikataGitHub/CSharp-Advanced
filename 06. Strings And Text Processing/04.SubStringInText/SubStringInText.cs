using System;

class SubStringInText
{
    static void Main()
    {
        string inputPattern = Console.ReadLine();
        string inputText = Console.ReadLine();
        int count = 0;
        int startIndex = 0;
        int index = inputText.IndexOf(inputPattern, startIndex, StringComparison.InvariantCultureIgnoreCase);

        while (index > 0)
        {
            count++;
            startIndex = index + inputPattern.Length;
            index = inputText.IndexOf(inputPattern, startIndex, StringComparison.InvariantCultureIgnoreCase);
        }
        Console.WriteLine(count);
    }
}