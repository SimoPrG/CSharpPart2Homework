/*Problem 3. Sequence n matrix

    We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements
    located on the same line, column or diagonal.
    Write a program that finds the longest sequence of equal strings in the matrix.

Example:
matrix 	            result
ha 	fifi ho hi      ha, ha, ha
fo 	ha 	 hi xx
xxx ho 	ha 	xx

matrix 	            result
s 	qq 	s           s, s, s
pp 	pp 	s
pp 	qq 	s
*/

using System;
using System.IO;

class SequenceNMatrix
{
    static void Main()
    {
        // Tell console to get its input from a file, not from the keyboard
        StreamReader file = new StreamReader(@"..\..\input.txt"); //uncoment this two lines to read from file
        Console.SetIn(file);                                      //uncoment this two lines to read from file
        //reading the matrix
        Console.Write("Please, enter the number of rows: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the number of columns: ");
        int M = int.Parse(Console.ReadLine());
        string[,] matrix = new string[N, M];
        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < M; column++)
            {
                Console.Write("matrix[{0},{1}] = ", row, column);
                matrix[row, column] = Console.ReadLine();
            }
        }

        //for (int row = 0; row < matrix.GetLength(0); row++)
        //{
        //    for (int col = 0; col < matrix.GetLength(1); col++)
        //    {
        //        Console.Write("{0}  ", matrix[row, col]);
        //    }
        //    Console.WriteLine();
        //}
        // check by rows
        string element = matrix[0, 0];
        string bestElement = null;
        int sequence = 0;
        int bestSequence = 0;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (element == matrix[row, col])
                {
                    sequence++;
                    if (sequence > bestSequence)
                    {
                        bestSequence = sequence;
                        bestElement = element;
                    }
                }
                else
                {
                    element = matrix[row, col];
                    sequence = 1;
                }
            }
            if (row < matrix.GetLength(0) - 1)
            {
                element = matrix[row + 1, 0];
                sequence = 0;
            }
        }
        //check by col
        element = matrix[0, 0];
        sequence = 0;
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (element == matrix[row, col])
                {
                    sequence++;
                    if (sequence > bestSequence)
                    {
                        bestSequence = sequence;
                        bestElement = element;
                    }
                }
                else
                {
                    element = matrix[row, col];
                    sequence = 1;
                }
            }
            if (col < matrix.GetLength(1) - 1)
            {
                element = matrix[0, col + 1];
                sequence = 0;
            }
        }

        //check diagonals from right to left
        element = matrix[0, 0];
        sequence = 0;
        for (int slice = 0; slice < N + M - 1; slice++)
        {
            for (int row = (slice < M ? 0 : slice - M + 1), col = (slice < M ? slice : M - 1);
                (row <= N - 1) && (col >= 0);
                row++, col--)
            {
                if (element == matrix[row, col])
                {
                    sequence++;
                    if (sequence > bestSequence)
                    {
                        bestSequence = sequence;
                        bestElement = element;
                    }
                }
                else
                {
                    element = matrix[row, col];
                    sequence = 1;
                }
            }
            if (slice < N + M - 2)
            {
                sequence = 0;
                element = matrix[slice + 1 < M ? 0 : slice - M + 2, slice + 1 < M ? slice + 1 : M - 1];
            }
        }

        //check diagonals from left to right
        element = matrix[N - 1, 0];
        sequence = 0;
        for (int slice = 0; slice < N + M - 1; slice++)
        {
            for (int row = N - 1 - slice >= 0 ? N - 1 - slice : 0, col = N - 1 - slice >= 0 ? 0 : slice - N + 1;
                row < N && col < M;
                row++, col++)
            {
                if (element == matrix[row, col])
                {
                    sequence++;
                    if (sequence > bestSequence)
                    {
                        bestSequence = sequence;
                        bestElement = element;
                    }
                }
                else
                {
                    element = matrix[row, col];
                    sequence = 1;
                }
            }
            if (slice < N + M - 2)
            {
                sequence = 0;
                element = matrix[N - 2 - slice >= 0 ? N - 2 - slice : 0, N - 2 - slice >= 0 ? 0 : slice - N + 2];
            }
        }

        //print best sequence
        for (int i = 0; i < bestSequence; i++)
        {
            Console.Write("{0} ", bestElement);
        }

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        // Wait for keyboard enter
        Console.ReadKey();
    }
}