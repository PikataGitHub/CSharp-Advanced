using System;
using System.Linq;

class SequenceInMatrix
{
    static void Main()
    {
        string dimentionsOfArray = Console.ReadLine();
        var arrayDimentions = dimentionsOfArray
            .Split(' ')
            .Select(z => Convert.ToInt32(z))
            .ToArray();
        int N = arrayDimentions[0];
        int M = arrayDimentions[1];

        var inputMatrix = new int[N][];
        for (int i = 0; i < N; i++)
        {
            inputMatrix[i] = new int[M];
        }

        for (int i = 0; i < N; i++)
        {
            string inputLines = null;
            inputLines = Console.ReadLine();
            inputMatrix[i] = inputLines
                .Split(' ')
                .Select(z => Convert.ToInt32(z))
                .ToArray();
        }

        int maxSequence = 1;

        // Check rows
        for (int i = 0; i < N; i++)
        {
            int tempSequence = 1;
            for (int j = 1; j < M; j++)
            {
                if (inputMatrix[i][j - 1] == inputMatrix[i][j])
                {
                    tempSequence++;
                }
                else
                {
                    if (maxSequence < tempSequence)
                    {
                        maxSequence = tempSequence;
                    }
                    tempSequence = 1;
                }
            }
            if (maxSequence < tempSequence)
            {
                maxSequence = tempSequence;
            }
        }


        //Check columns
        for (int i = 0; i < M; i++)
        {
            int tempSequence = 1;
            for (int j = 1; j < N; j++)
            {
                if (inputMatrix[j - 1][i] == inputMatrix[j][i])
                {
                    tempSequence++;
                }
                else
                {
                    if (maxSequence < tempSequence)
                    {
                        maxSequence = tempSequence;
                    }
                    tempSequence = 1;
                }
            }
            if (maxSequence < tempSequence)
            {
                maxSequence = tempSequence;
            }
        }


        if (N >= M)
        {
            //Check right diagonals
            for (int i = N - 1; i > N - M; i--)
            {
                int tempSequence = 1;
                for (int j = (0 + 1); j < N - i; j++)
                {
                    if (inputMatrix[(i + j - 1)][(j - 1)] == inputMatrix[i + j][j])
                    {
                        tempSequence++;
                    }
                    else
                    {
                        if (maxSequence < tempSequence)
                        {
                            maxSequence = tempSequence;
                        }
                        tempSequence = 1;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }

            for (int i = N - M; i >= 0; i--)
            {
                int tempSequence = 1;
                for (int j = (0 + 1); j < M; j++)
                {
                    if (inputMatrix[(i + j - 1)][(j - 1)] == inputMatrix[i + j][j])
                    {
                        tempSequence++;
                    }
                    else
                    {
                        if (maxSequence < tempSequence)
                        {
                            maxSequence = tempSequence;
                        }
                        tempSequence = 1;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }

            for (int i = 1; i < M; i++)
            {
                int tempSequence = 1;
                for (int j = (i + 1); j < M; j++)
                {
                    if (inputMatrix[(j - i - 1)][(j - 1)] == inputMatrix[j - i][j])
                    {
                        tempSequence++;
                    }
                    else
                    {
                        if (maxSequence < tempSequence)
                        {
                            maxSequence = tempSequence;
                        }
                        tempSequence = 1;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }

            //Check left diagonals

            for (int i = 0; i < M; i++)
            {
                int tempSequence = 1;
                for (int j = (0 + 1); j <= i; j++)
                {
                    if (inputMatrix[(j - 1)][(i - j + 1)] == inputMatrix[j][i - j])
                    {
                        tempSequence++;
                    }
                    else
                    {
                        if (maxSequence < tempSequence)
                        {
                            maxSequence = tempSequence;
                        }
                        tempSequence = 1;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }

            //Check equal lenght of diagonals N-M
            //for (int i = 1; i < N; i++)
            //{
            //    int tempSequence = 1;
            //    for (int j = (M - 1 - 1); j >= 0; j--)
            //    {
            //        if (inputMatrix[(N - 1 + i - j - 1)][(j + 1)] == inputMatrix[N - 1 + i - j][j])
            //        {
            //            tempSequence++;
            //        }
            //        else
            //        {
            //            if (maxSequence < tempSequence)
            //            {
            //                maxSequence = tempSequence;
            //            }
            //            tempSequence = 1;
            //        }
            //    }
            //    if (maxSequence < tempSequence)
            //    {
            //        maxSequence = tempSequence;
            //    }
            //}

            for (int i = 1; i < M; i++)
            {
                int tempSequence = 1;
                for (int j = (M - 1 - 1); j >= i; j--)
                {
                    if (inputMatrix[(N - 1 + i - j - 1)][(j + 1)] == inputMatrix[N - 1 + i - j][j])
                    {
                        tempSequence++;
                    }
                    else
                    {
                        if (maxSequence < tempSequence)
                        {
                            maxSequence = tempSequence;
                        }
                        tempSequence = 1;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }
        }
        else
        {
            //Check right diagonals
            for (int i = N - 1; i >= 0; i--)
            {
                int tempSequence = 1;
                for (int j = (0 + 1); j < N - i; j++)
                {
                    if (inputMatrix[(i + j - 1)][(j - 1)] == inputMatrix[i + j][j])
                    {
                        tempSequence++;
                    }
                    else
                    {
                        if (maxSequence < tempSequence)
                        {
                            maxSequence = tempSequence;
                        }
                        tempSequence = 1;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }

            //for (int i = M - N; i >= 0; i--)
            //{
            //    int tempSequence = 1;
            //    for (int j = (0 + 1); j < M; j++)
            //    {
            //        if (inputMatrix[(i + j - 1)][(j - 1)] == inputMatrix[i + j][j])
            //        {
            //            tempSequence++;
            //        }
            //        else
            //        {
            //            if (maxSequence < tempSequence)
            //            {
            //                maxSequence = tempSequence;
            //            }
            //            tempSequence = 1;
            //        }
            //    }
            //    if (maxSequence < tempSequence)
            //    {
            //        maxSequence = tempSequence;
            //    }
            //}


            /*
            for (int i = M - N; i < M; i++)
            {
                int tempSequence = 1;
                for (int j = (M - N + 1); j < M; j++)
                {
                    if (inputMatrix[(j - i - 1)][(j - 1)] == inputMatrix[j - i][j])
                    {
                        tempSequence++;
                    }
                    else
                    {
                        if (maxSequence < tempSequence)
                        {
                            maxSequence = tempSequence;
                        }
                        tempSequence = 1;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }

            */

            //Check left diagonals

            
            for (int i = 0; i < N; i++)
            {
                int tempSequence = 1;
                for (int j = (0 + 1); j <= i; j++)
                {
                    if (inputMatrix[(j - 1)][(i - j + 1)] == inputMatrix[j][i - j])
                    {
                        tempSequence++;
                    }
                    else
                    {
                        if (maxSequence < tempSequence)
                        {
                            maxSequence = tempSequence;
                        }
                        tempSequence = 1;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }
            

            //Check equal lenght of diagonals N-M
            //for (int i = 1; i < N; i++)
            //{
            //    int tempSequence = 1;
            //    for (int j = (M - 1 - 1); j >= 0; j--)
            //    {
            //        if (inputMatrix[(N - 1 + i - j - 1)][(j + 1)] == inputMatrix[N - 1 + i - j][j])
            //        {
            //            tempSequence++;
            //        }
            //        else
            //        {
            //            if (maxSequence < tempSequence)
            //            {
            //                maxSequence = tempSequence;
            //            }
            //            tempSequence = 1;
            //        }
            //    }
            //    if (maxSequence < tempSequence)
            //    {
            //        maxSequence = tempSequence;
            //    }
            //}

            /*
                for (int i = M-N; i < M; i++)
                {
                    int tempSequence = 1;
                    for (int j = (M - 1 - 1); j >= i; j--)
                    {
                        if (inputMatrix[(M - 1 + i - j - 1-N)][(j + 1)] == inputMatrix[M - 1 + i - j-N][j])
                        {
                            tempSequence++;
                        }
                        else
                        {
                            if (maxSequence < tempSequence)
                            {
                                maxSequence = tempSequence;
                            }
                            tempSequence = 1;
                        }
                    }
                    if (maxSequence < tempSequence)
                    {
                        maxSequence = tempSequence;
                    }
                }
                */
        }

        Console.WriteLine(maxSequence);
    }
}