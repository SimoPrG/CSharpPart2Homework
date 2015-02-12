/*Problem 1. Fill the matrix

    Write a program that fills and prints a matrix of size (n, n) as shown below:

Example for n=4:
a)
1 	5 	9 	13
2 	6 	10 	14
3 	7 	11 	15
4 	8 	12 	16
b)
1 	8 	9 	16
2 	7 	10 	15
3 	6 	11 	14
4 	5 	12 	13
c)
7 	11 	14 	16
4 	8 	12 	15
2 	5 	9 	13
1 	3 	6 	10
d)*
1 	12 	11 	10
2 	13 	16 	9
3 	14 	15 	8
4 	5 	6 	7
*/

using System;

class FillTheMatrix
{
    static void Main()
    {
        Console.Title = "Fill the matrix";

        Console.Write("Please, enter an integer N: ");
        int N = int.Parse(Console.ReadLine());

        int[,] matrix = new int[N, N];
        for (int count = 1, col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                matrix[row, col] = count++;
            }
        }

        Console.WriteLine("a)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        for (int count = 1, col = 0; col < matrix.GetLength(1); col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    matrix[row, col] = count++;
                }
            }
            else
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    matrix[row, col] = count++;
                }
            }
        }

        Console.WriteLine("\r\nb)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        /*With the next nested loops I create a matrix that looks like this:
         * 1 2 4
         * 3 5 7
         * 6 8 9
         * I did this by mistake but I decided that I could practice rotation of a matrix as well :)
         */

        for (int count = 1, slice = 0; slice < 2 * N - 1; slice++)
        {
            for (int row = (slice < N ? 0 : slice - N + 1), col = (slice < N ? slice : N - 1); (row <= N - 1) && (col >= 0); row++, col--)
            {
                matrix[row, col] = count++;
            }
        }
        //rotating counterclockwise
        for (int i = 0; i < N / 2; i++)
        {
            for (int j = 0; j < N / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[j, N - 1 - i];
                matrix[j, N - 1 - i] = matrix[N - 1 - i, N - 1 - j];
                matrix[N - 1 - i, N - 1 - j] = matrix[N - 1 - j, i];
                matrix[N - 1 - j, i] = temp;
            }
        }
        if (N % 2 != 0)
        {
            for (int i = 0; i < N / 2; i++)
            {
                int temp = matrix[i, N / 2];
                matrix[i, N / 2] = matrix[N / 2, N - 1 - i];
                matrix[N / 2, N - 1 - i] = matrix[N - 1 - i, N / 2];
                matrix[N - 1 - i, N / 2] = matrix[N / 2, i];
                matrix[N / 2, i] = temp;
            }
        }

        Console.WriteLine("\r\nc)");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}