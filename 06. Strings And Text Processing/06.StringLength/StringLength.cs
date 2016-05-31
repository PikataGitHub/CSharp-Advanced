using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        string inputText = Console.ReadLine();
        inputText = inputText.Replace(@"\", string.Empty);

        if (inputText.Length >= 20)
        {
            Console.WriteLine(inputText.Substring(0, 20));
        }
        else
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(inputText);
            for (int i = inputText.Length; i < 20; i++)
            {
                sb.Append('*');
            }
            Console.WriteLine(sb.ToString());
        }
    }
}