using System;

class LeapYear
{
    static void Main()
    {
        int inputYear = int.Parse(Console.ReadLine());
        int leapYear = DateTime.Now.Year;
        int differance = Math.Abs(leapYear - inputYear);

        if (differance%4==0)
        {
            Console.WriteLine("Leap");
        }
        else
        {
            Console.WriteLine("Common");
        }
    }
}