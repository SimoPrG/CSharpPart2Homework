/*Problem 7. Encode/decode

    Write a program that encodes and decodes a string using given encryption key (cipher).
    The key consists of a sequence of characters.
    The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter
    of the string with the first of the key, the second – with the second, etc. When the last key
    character is reached, the next is the first.
*/

using System;

class EncodeDecode
{
    static void Main()
    {
        string cipher = "abcd";
        string text = "Hello, Cipher!";

        Console.WriteLine(text);

        text = Code(cipher, text);
        Console.WriteLine(text);

        text = Code(cipher, text);
        Console.WriteLine(text);

        Console.ReadKey();
    }

    static string Code(string cipher, string text)
    {
        char[] codedText = text.ToCharArray();
        for (int i = 0; i < codedText.Length; i++)
        {
            codedText[i] ^= cipher[i % cipher.Length];
        }
        return new string(codedText);
    }
}