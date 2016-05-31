using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] instructions = new string[N];
        List<int> digits = new List<int>();
        instructions[0] = Console.ReadLine();
        int X = int.Parse(instructions[0][0].ToString()); ;
        int Y = int.Parse(instructions[0][(instructions[0].Length - 1)].ToString());
        digits.Add(X);
        digits.Add(Y);

        for (int i = 1; i < N; i++)
        {
            instructions[i] = Console.ReadLine();
            X = int.Parse(instructions[i][0].ToString());
            for (int j = 0; j < digits.Count; j++)
            {
                if (X == digits[j])
                {
                    break;
                }
                else if (j == digits.Count - 1)
                {
                    digits.Add(X);
                }
            }
            Y = int.Parse(instructions[i][(instructions[i].Length - 1)].ToString());
            for (int j = 0; j < digits.Count; j++)
            {
                if (Y == digits[j])
                {
                    break;
                }
                else if (j == digits.Count - 1)
                {
                    digits.Add(Y);
                }
            }
        }
        digits.Sort();

        foreach (string todo in instructions)
        {
            X = int.Parse(todo[0].ToString());
            Y = int.Parse(todo[todo.Length - 1].ToString());
            string subInstruction = todo.Substring(2, todo.Length - 4);
            int indexY = digits.IndexOf(Y);
            int indexX = digits.IndexOf(X);

            if (X < Y && subInstruction == "is after" && indexX < indexY)
            {
                int i = indexY + 1;
                while (i < digits.Count && X > digits[i])
                {
                    indexY++;                    
                    i++;
                }
                int temp = X;
                for (int j = indexX; j < indexY; j++)
                {
                    digits[j] = digits[j + 1];                    
                }
                digits[indexY] = temp;

            }

            if (X > Y && subInstruction == "is before" && indexX > indexY)
            {
                int i = indexX + 1;
                while (i < digits.Count && Y > digits[i])
                {
                    indexX++;
                    i++;
                }

                int temp = Y;
                for (int j = indexY; j < indexX; j++)
                {
                    digits[j] = digits[j + 1];
                }
                digits[indexX] = temp;

            }

        }

        for (int i = 0; i < digits.Count; i++)
        {
            Console.Write(digits[i]);
        }

    }
}