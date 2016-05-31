using System;

class FillTheMatrix
{
    static void Main()
    {

        int N = int.Parse(Console.ReadLine());
        string character = Console.ReadLine();
        int[,] array = new int[N, N];
        int number = 1;

        //Fill the Matrix
        switch (character)
        {
            case "a":
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        array[j, i] = number;
                        number++;
                    }
                }
                break;

            case "b":
                for (int i = 0; i < N; i++)
                {
                    if (i % 2 == 0)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            array[j, i] = number;
                            number++;
                        }
                    }
                    else
                    {
                        for (int j = N - 1; j >= 0; j--)
                        {
                            array[j, i] = number;
                            number++;
                        }
                    }
                }
                break;

            case "c":
                for (int j = N - 1; j >= 0; j--)
                {
                    for (int i = 0; i <= N - 1 - j; i++)
                    {
                        array[j + i, i] = number;
                        number++;
                    }
                }
                for (int j = 1; j < N; j++)
                {
                    for (int i = j; i < N; i++)
                    {
                        array[i - j, i] = number;
                        number++;
                    }
                }
                break;

            case "d":
                
                int switcher = N - 1;
                number = 1;

                int row = 0;
                int col = 0;

                while (switcher > 0)
                {
                    for (int x = row; x < switcher + row; x++)
                    {
                        array[x, row] = number++;
                    }

                    for (int y = row; y < switcher + row; y++)
                    {
                        array[row + switcher, y] = number++;
                    }

                    for (int bottomRow = N - 1 - row; bottomRow > col; bottomRow--)
                    {
                        array[bottomRow, switcher + row] = number++;
                    }

                    for (int l = switcher + row; l > row; l--)
                    {
                        array[col, l] = number++;
                    }

                    row += 1;
                    col += 1;
                    switcher -= 2;
                }
                if (switcher==0)
                {
                    array[row, col] = number++;
                }
                break;

            default:
                Console.WriteLine("There is s-th terribly wrong here!");
                break;
        }

        // Printing the Matrix        
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write(array[i, j]);
                if (j < N - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}