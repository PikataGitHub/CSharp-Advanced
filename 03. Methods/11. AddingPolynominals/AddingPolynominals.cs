using System;
using System.Linq;

class AddingPolynominals
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        var firstPolynominal = new int[N];
        var secondPolynominal = new int[N];

        string inputLine = Console.ReadLine();
        firstPolynominal = ReadInput(inputLine, N);

        inputLine = Console.ReadLine();
        secondPolynominal = ReadInput(inputLine, N);

        var result = new int[N];
        result = SumOfPolynominals(firstPolynominal, secondPolynominal);

        foreach (int item in result)
        {
            Console.Write("{0} ", item);
        }
    }

    private static int[] SumOfPolynominals(int[] firstPolynominal, int[] secondPolynominal)
    {
        var array = new int[firstPolynominal.Length];

        for (int i = 0; i < firstPolynominal.Length; i++)
        {
            array[i] = firstPolynominal[i] + secondPolynominal[i];
        }

        return array;
    }

    private static int[] ReadInput(string inputLine, int dimention)
    {
        var array = new int[dimention];

        array = inputLine
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();

        return array;
    }
}