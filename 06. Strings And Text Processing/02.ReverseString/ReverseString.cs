using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        string someString = Console.ReadLine();
        StringBuilder sb = new StringBuilder();

        for (int i = someString.Length - 1; i >= 0; i--)
        {
            sb.Append(someString[i]);
        }

        someString = sb.ToString();
        Console.WriteLine(someString);
    }
}