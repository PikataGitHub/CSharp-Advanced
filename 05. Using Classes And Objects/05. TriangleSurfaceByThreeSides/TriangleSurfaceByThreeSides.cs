using System;

class TriangleSurfaceByThreeSides
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double sideC = double.Parse(Console.ReadLine());
        double parameterS = (sideA + sideB + sideC) / 2;
        double area = 0;

        area = Math.Sqrt(parameterS * (parameterS - sideA) * (parameterS - sideB) * (parameterS - sideC));

        Console.WriteLine("{0:F2}", area);
    }
}