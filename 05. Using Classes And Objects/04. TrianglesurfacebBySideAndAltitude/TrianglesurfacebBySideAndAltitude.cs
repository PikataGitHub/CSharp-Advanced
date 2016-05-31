using System;

class TrianglesurfacebBySideAndAltitude
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double heightH = double.Parse(Console.ReadLine());
        double surface = 0;

        surface = (sideA * heightH) / 2;
        Console.WriteLine("{0:F2}", surface);
    }
}