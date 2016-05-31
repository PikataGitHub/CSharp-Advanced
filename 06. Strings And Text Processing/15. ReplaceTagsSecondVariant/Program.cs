using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string hrefPattern = @"<\s*a\s[^>]*?\bhref\s*=\s*('[^']*'|""[^""]*""|\S*)[^>]*>((.|\s)*?)<\s*/a\s*>";
        string replacement = "[$2]($1)";
        string result = Regex.Replace(Console.ReadLine(), hrefPattern, replacement);
        Console.WriteLine(result.Replace("(\"", "(").Replace("\")", ")"));
    }
}
