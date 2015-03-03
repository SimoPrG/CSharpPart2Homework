/*Problem 5. Maximal area sum

    Write a program that reads a text file containing a square matrix of numbers.
    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
        The first line in the input file contains the size of matrix N.
        Each of the next N lines contain N numbers separated by space.
        The output should be a single number in a separate text file.

Example:
input 	    output
4
2 3 3 4
0 2 3 4
3 7 1 2
4 3 3 2 	17
*/

using System;
using System.IO;
class MaximalAreaSum
{
    static void Main()
    {
        string input;

        using (StreamReader reader = new StreamReader(@"..\..\MatrixFile.txt"))
        {
            input = reader.ReadToEnd();
        }

        string[] lines = input.Split('\n');

        int size = int.Parse(lines[0]);

        int[,] matrix = new int[size, size];

        for (int i = 0; i < size; i++)
        {
            int[] line = Array.ConvertAll(lines[i + 1].Split(' '), int.Parse);

            for (int j = 0; j < size; j++)
            {
                matrix[i, j] = line[j];
            }
        }

        int max = int.MinValue;
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                int currentSum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                if (currentSum > max)
                {
                    max = currentSum;
                }
            }
        }

        using (StreamWriter writer = new StreamWriter(@"..\..\result.txt"))
        {
            writer.Write(max);
        }
    }
}