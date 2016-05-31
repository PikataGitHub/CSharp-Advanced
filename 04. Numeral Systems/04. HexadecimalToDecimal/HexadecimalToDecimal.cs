using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexNumber = Console.ReadLine();

        char[] hexDigits = "0123456789ABCDF".ToCharArray();
        long decimalNumber = 0;

        foreach (char hex in hexNumber)
        {
            decimalNumber = HexDigitToDecimal(hex) + decimalNumber * 16;
        }
        Console.WriteLine(decimalNumber);
    }

    static int HexDigitToDecimal(char hexDigit)
    {
        if (char.IsDigit(hexDigit))
        {
            return hexDigit - '0';
        }
        return hexDigit - 'A' + 10;
    }
}