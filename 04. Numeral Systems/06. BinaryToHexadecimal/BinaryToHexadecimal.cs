using System;
using System.Collections.Generic;

class BinaryToHexadecimal
{
    static Dictionary<string, string> HexBin = new Dictionary<string, string>()
    {             
        { "0000", "0" },
        { "0001", "1" },
        { "0010", "2" },
        { "0011", "3" },
        { "0100", "4" },
        { "0101", "5" },
        { "0110", "6" },
        { "0111", "7" },
        { "1000", "8" },
        { "1001", "9" },
        { "1010", "A" },
        { "1011", "B" },
        { "1100", "C" },
        { "1101", "D" },
        { "1110", "E" },
        { "1111", "F" }
    };

    static void Main()
    {
        string binaryNumber = Console.ReadLine();
        string hexNumber = "";

        if (binaryNumber.Length % 4 != 0)
        {
            binaryNumber = AddEnoughZeroesInfront(binaryNumber);
        }
        for (int i = 0; i < binaryNumber.Length / 4; i++)
        {
            hexNumber += HexBin[binaryNumber.Substring((i * 4), 4)];
        }
        Console.WriteLine(hexNumber);
    }

    private static string AddEnoughZeroesInfront(string binaryNumber)
    {
        while (binaryNumber.Length % 4 != 0)
        {
            binaryNumber = "0" + binaryNumber;
        }
        return binaryNumber;
    }
}