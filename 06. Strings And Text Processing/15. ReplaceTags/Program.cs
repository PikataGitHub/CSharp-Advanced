using System;
using System.Text;

class Program
{
    static void Main()
    {
        string inputText = Console.ReadLine();

        string urlsToChange = "";
        string changedUrls = "";

        int firstIndex = inputText.IndexOf("<a href=");
        int secondIndex = inputText.IndexOf("</a>") + "</a>".Length;
        
        while (firstIndex >= 0 && secondIndex > 0)
        {
            urlsToChange = inputText.Substring(firstIndex, secondIndex - firstIndex);

            changedUrls = ReplaceTags(urlsToChange);

            inputText = inputText.Replace(urlsToChange, changedUrls);

            firstIndex = inputText.IndexOf("<a href=");
            secondIndex = inputText.IndexOf("</a>") + "</a>".Length;
        }
        Console.WriteLine(inputText);
    }

    private static string ReplaceTags(string urlsToChange)
    {
        StringBuilder sb = new StringBuilder();
        int tempIndex1 = urlsToChange.IndexOf('>') + 1;
        int tempIndex2 = urlsToChange.LastIndexOf('<');

        sb.Append('[');
        sb.Append(urlsToChange.Substring(tempIndex1, tempIndex2 - tempIndex1));
        sb.Append("](");

        tempIndex1 = urlsToChange.IndexOf('"') + 1; 
        tempIndex2 = urlsToChange.LastIndexOf('"');
                
        sb.Append(urlsToChange.Substring(tempIndex1, tempIndex2 - tempIndex1));
        sb.Append(')');

        return sb.ToString();
    }
}