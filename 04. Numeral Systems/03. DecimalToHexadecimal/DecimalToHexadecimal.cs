using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        long N = long.Parse(Console.ReadLine());
        long leftOver = 0;
        string hexNumber = "";
        string hexDigts = "0123456789ABCDEF";
        
        while (N > 0)
        {
            leftOver = N % 16;
            hexNumber = hexDigts[(int)leftOver] + hexNumber;
            N = N / 16;
        }
        Console.WriteLine(hexNumber);
    }
}