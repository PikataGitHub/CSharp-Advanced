using System;

class ParseURL
{
    static void Main()
    {
        string inputURL = Console.ReadLine();

        int indexProtocol = inputURL.IndexOf("//");
        Console.WriteLine("[protocol] = {0}", inputURL.Substring(0, indexProtocol - 1));

        int indexServer = inputURL.IndexOf('/', indexProtocol + 2);
        Console.WriteLine("[server] = {0}", inputURL.Substring(indexProtocol + 2, indexServer - indexProtocol - 2));

        Console.WriteLine("[resource] = {0}", inputURL.Substring(indexServer, inputURL.Length - indexServer));
    }
}