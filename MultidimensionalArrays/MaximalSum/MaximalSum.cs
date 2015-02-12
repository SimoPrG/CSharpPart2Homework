/*Problem 2. Maximal sum

    Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
*/

using System;
using System.IO;

class MaximalSum
{
    static void Main()
    {
        Console.Title = "Maximal Sum";

        // Tell console to get its input from a file, not from the keyboard
        //StreamReader file = new StreamReader(@"..\..\input.txt"); //uncoment this two lines to read from file
        //Console.SetIn(file);                                      //uncoment this two lines to read from file
        //reading the matrix
        Console.Write("Please, enter the number of rows N >= 3: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the number of columns M >= 3: ");
        int M = int.Parse(Console.ReadLine());
        int[,] matrix = new int[N, M];
        for (int row = 0; row < N; row++)
        {
            for (int column = 0; column < M; column++)
            {
                Console.Write("matrix[{0},{1}] = ", row, column);
                matrix[row, column] = int.Parse(Console.ReadLine());
            }
        }

        int square = 3;
        long bestSum = long.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row <= matrix.GetLength(0) - square; row++)
        {
            for (int col = 0; col <= matrix.GetLength(1) - square; col++)
            {
                int sum = 0;
                for (int i = row; i < row + square; i++)
                {
                    for (int j = col; j < col + square; j++)
                    {
                        sum += matrix[i, j];
                    }
                };
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        for (int i = bestRow; i < bestRow + square; i++)
        {
            for (int j = bestCol; j < bestCol + square; j++)
            {
                Console.Write("{0} ", matrix[i, j]);
            }
            Console.WriteLine();
        }

        // Reset console input to the standard (keyboard) input so we can wait for keyboard enter
        Console.SetIn(new StreamReader(Console.OpenStandardInput()));
        // Wait for keyboard enter
        Console.ReadKey();
    }
}