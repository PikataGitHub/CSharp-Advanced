using System;

namespace HelpDiagonalsInitializationNxN
{
    class Help
    {
        static void Main(string[] args)
        {

            //Check right diagonals NxN
            for (int i = N - 1; i >= 0; i--)
            {
                int tempSequence = 1;
                for (int j = 0; j < N - i; j++)
                {
                    if (inputMatrix[i + j][j] == inputMatrix[i + j][j])
                    {
                        tempSequence++;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }
            for (int i = 1; i < N; i++)
            {
                int tempSequence = 1;
                for (int j = i; j < N; j++)
                {
                    if (inputMatrix[j - i][j] == inputMatrix[j - i][j])
                    {
                        tempSequence++;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }


            //Check left diagonals NxN

            for (int i = 0; i < N; i++)
            {
                int tempSequence = 1;
                for (int j = 0; j <= i; j++)
                {
                    if (inputMatrix[j][i - j] == inputMatrix[j][i - j])
                    {
                        tempSequence++;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }
            for (int i = 1; i < N; i++)
            {
                int tempSequence = 1;
                for (int j = N - 1; j >= i; j--)
                {
                    if (inputMatrix[N - 1 + i - j][j] == inputMatrix[N - 1 + i - j][j])
                    {
                        tempSequence++;
                    }
                }
                if (maxSequence < tempSequence)
                {
                    maxSequence = tempSequence;
                }
            }




        }
    }
}
