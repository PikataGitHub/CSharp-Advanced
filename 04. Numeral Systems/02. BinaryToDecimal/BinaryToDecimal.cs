using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        long decimalNumber = 0;
        
        foreach (char bit in binaryNumber)
        {
            decimalNumber = (bit - '0') + decimalNumber * 2;
        }
        Console.WriteLine(decimalNumber);
    }
}