/*Problem 15. Prime numbers

    Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.
*/

using System;
using System.Text;

class PrimeNumbers
{
    static void Main()
    {
        bool[] prime = new bool[10000001];
        for (int i = 2; i < prime.Length; i++)
        {
            prime[i] = true;
        }

        for (int i = 2; i <= Math.Sqrt(prime.Length - 1); i++)
        {
            if (prime[i])
            {
                for (int j = i*i; j < prime.Length; j += i)
                {
                    prime[j] = false;
                }
            }
        }

        StringBuilder output = new StringBuilder();
        for (int i = 2; i < prime.Length; i++)
        {
            if (prime[i])
            {
                output.Append(i).Append(' ');
            }
        }
        Console.WriteLine(output);

        Console.ReadKey();
    }
}