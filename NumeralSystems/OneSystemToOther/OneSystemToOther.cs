/*Problem 7. One system to any other

    Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
*/

using System;
using System.Text;

class OneSystemToOther
{
    static void Main()
    {
        Console.WriteLine("Please, enter the number of the base from which you want to convert!");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter the number of the base to which you want to convert!");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Please, enter the integer: ");
        string integer = Console.ReadLine();

        integer = OtherToDecimal(integer, s);
        integer = DecimalToOther(integer, d);

        Console.WriteLine("The result is: " + integer);

        Console.ReadKey();
    }

    static string OtherToDecimal(string other, int system)
    {
        if (system < 2 || system > 16)
        {
            return "Invalid System";
        }

        bool isNegative = false;
        if (other.StartsWith("-"))
        {
            isNegative = true;
            other = other.Replace("-", "");
        }

        other = other.ToUpper();

        long sum = 0;
        for (int i = 0; i < other.Length; i++)
        {
            if ((other[i] <= system + 54 && 'A' <= other[i]) || ('0' <= other[i] && other[i] <= '9'))
            {
                switch (other[i])
                {
                    case '0': sum += 0 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case '1': sum += 1 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case '2': sum += 2 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case '3': sum += 3 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case '4': sum += 4 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case '5': sum += 5 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case '6': sum += 6 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case '7': sum += 7 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case '8': sum += 8 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case '9': sum += 9 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case 'A': sum += 10 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case 'B': sum += 11 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case 'C': sum += 12 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case 'D': sum += 13 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case 'E': sum += 14 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    case 'F': sum += 15 * (long)Math.Pow(system, other.Length - 1 - i); break;
                    default:
                        return "Invalid Number";
                }
            }
            else
            {
                return "Invalid Number";
            }
        }

        if (isNegative)
        {
            sum = -sum;
        }

        return sum.ToString();
    }

    static string DecimalToOther(string dec, int system)
    {
        if (system < 2 || system > 16)
	{
		 return "Invalid System";
	}

        long number;
        if (long.TryParse(dec, out number))
        {
            bool isNegative = false;
            if (number < 0)
            {
                isNegative = true;
                number = -number;
            }

            StringBuilder otherInverted = new StringBuilder();
            do
            {
                switch (number % system)
                {
                    case 0: otherInverted.Append('0'); break;
                    case 1: otherInverted.Append('1'); break;
                    case 2: otherInverted.Append('2'); break;
                    case 3: otherInverted.Append('3'); break;
                    case 4: otherInverted.Append('4'); break;
                    case 5: otherInverted.Append('5'); break;
                    case 6: otherInverted.Append('6'); break;
                    case 7: otherInverted.Append('7'); break;
                    case 8: otherInverted.Append('8'); break;
                    case 9: otherInverted.Append('9'); break;
                    case 10: otherInverted.Append('A'); break;
                    case 11: otherInverted.Append('B'); break;
                    case 12: otherInverted.Append('C'); break;
                    case 13: otherInverted.Append('D'); break;
                    case 14: otherInverted.Append('E'); break;
                    case 15: otherInverted.Append('F'); break;
                    default:
                        return "Invalid System";
                }
                number /= system;
            } while (number != 0);

            if (isNegative)
            {
                otherInverted.Append('-');
            }

            char[] other = new char[otherInverted.Length];
            for (int i = 0; i < other.Length; i++)
            {
                other[i] = otherInverted[other.Length - 1 - i];
            }

            return new string (other);
        }
        else
        {
            return "Invalid Number";
        }
    }

    //static string LowerToDecimal(string lower, int system)
    //{
    //    if (system > 10)
    //    {
    //        return "Invlid System";
    //    }

    //    bool isNegative = false;
    //    if (lower.StartsWith("-"))
    //    {
    //        isNegative = true;
    //        lower = lower.Replace("-", "");
    //    }

    //    long sum = 0;
    //    for (int i = 0; i < lower.Length; i++)
    //    {
    //        if (lower[i] - '0' < system && lower[i] - '0' >= 0)
    //        {
    //            sum += (long)((lower[i] - '0') * Math.Pow(system, lower.Length - 1 - i));
    //        }
    //        else
    //        {
    //            return "Invalid Number";
    //        }
    //    }

    //    if (isNegative)
    //    {
    //        sum = -sum;
    //    }

    //    return sum.ToString();
    //}
}