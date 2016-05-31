using System;
using System.Collections.Generic;

class HexadecimalToBinary
{
    static Dictionary<char, string> HexBin = new Dictionary<char, string>()
    {
        { '0', "0000"  },
        { '1', "0001"  },
        { '2', "0010"  },
        { '3', "0011"  },
        { '4', "0100"  },
        { '5', "0101"  },
        { '6', "0110"  },
        { '7', "0111"  },
        { '8', "1000"  },
        { '9', "1001"  },
        { 'A', "1010"  },
        { 'B', "1011"  },
        { 'C', "1100"  },
        { 'D', "1101"  },
        { 'E', "1110"  },
        { 'F', "1111"  }
    };

    static void Main()
    {
        string hexNumber = Console.ReadLine();
        string binaryNumber = "";

        foreach (char hexDigit in hexNumber)
        {
            binaryNumber += HexBin[hexDigit];
        }

        binaryNumber = RemoveZeroesInFront(binaryNumber);

        Console.WriteLine(binaryNumber);
    }

    private static string RemoveZeroesInFront(string binaryNumber)
    {
        while (binaryNumber[0]=='0')
        {
            binaryNumber = binaryNumber.Remove(0, 1);
        }        
        return binaryNumber;
    }
}