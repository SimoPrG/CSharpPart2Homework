/*Problem 10. Extract text from XML

    Write a program that extracts from given XML file all the text without the tags.

Example:

<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>
*/

using System;
using System.IO;
using System.Text;
class XMLTextExtraction
{
    static void Main()
    {
        string XMLFile = @"..\..\XMLFile.xml";
        string outputFile = @"..\..\OnlyText.txt";

        try
        {
            using (StreamReader reader = new StreamReader(XMLFile))
            {
                StringBuilder builder = new StringBuilder(reader.ReadToEnd());

                RemoveTags(builder);

                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.Write(builder);
                }
            }
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error: {0}.", exc.Message);
        }
    }

    private static void RemoveTags(StringBuilder text)
    {
        bool inTag = false;
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '<')
            {
                inTag = true;
            }

            if (text[i] == '>')
            {
                text.Replace('>', ' ', i, 1);
                inTag = false;
            }

            if (inTag)
            {
                text.Remove(i--, 1);
            }
        }
    }
}