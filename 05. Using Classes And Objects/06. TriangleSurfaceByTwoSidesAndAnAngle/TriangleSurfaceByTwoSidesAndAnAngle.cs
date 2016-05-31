using System;

class TriangleSurfaceByTwoSidesAndAnAngle
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double angleBetween = double.Parse(Console.ReadLine());
        double area = 0;

        area = sideA * sideB * Math.Sin(angleBetween * Math.PI / 180) / 2;

        Console.WriteLine("{0:F2}", area);
    }
}