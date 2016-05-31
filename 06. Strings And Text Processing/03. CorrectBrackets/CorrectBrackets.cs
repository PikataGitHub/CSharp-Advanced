using System;

class CorrectBrackets
{
    static void Main()
    {
        string someExpression = Console.ReadLine();
        int bracketCounter = 0;
        int oneCycleCount = 0;

        while (bracketCounter >= 0 && oneCycleCount <= someExpression.Length - 1)
        {
            foreach (char symbol in someExpression)
            {
                if (symbol == '(')
                {
                    bracketCounter++;
                }
                else if (symbol == ')')
                {
                    bracketCounter--;
                }
                oneCycleCount++;
            }
            if (bracketCounter == 0)
            {
                Console.WriteLine("Correct");
                return;
            }
        }
        Console.WriteLine("Incorrect");
    }
}