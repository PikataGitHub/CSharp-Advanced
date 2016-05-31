using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        foreach (char i in inputText)
        {
            Console.Write(@"\u{0:X4}", (int)i);
        }
        Console.WriteLine(sb.ToString());
    }
}