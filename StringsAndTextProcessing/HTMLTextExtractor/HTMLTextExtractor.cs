/*Problem 25. Extract text from HTML

    Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.

Example input:

<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>

Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
*/

using System;
using System.Text;

class HTMLTextExtractor
{
    static void Main()
    {
        string html =
@"<html>
    <head><title>News</title></head>
    <body>
        <p><a href=""http://academy.telerik.com"">Telerik
        Academy</a>aims to provide free real-world practical
        training for young people who want to turn into
        skilful .NET software engineers.</p>
    </body>
</html>";

        StringBuilder htmlBuilder = new StringBuilder(html);

        ExtractHTMLTitle(htmlBuilder);

        ExtractHTMLBody(htmlBuilder);

        RemoveHTMLTags(htmlBuilder);

        Console.WriteLine(htmlBuilder);

        Console.ReadKey();
    }

    private static void ExtractHTMLTitle(StringBuilder html)
    {
        string[] titleTags = { "<title>", "</title>" };
        string[] replacement = {"Title: ", ""};
        for (int i = 0; i < titleTags.Length; i++)
        {
            html.Replace(titleTags[i], replacement[i]);
        }
    }

    private static void ExtractHTMLBody(StringBuilder html)
    {
        string[] bodyTags = { "<body>", "</body>" };
        string[] replacement = { "Text: ", "" };
        for (int i = 0; i < bodyTags.Length; i++)
        {
            html.Replace(bodyTags[i], replacement[i]);
        }
    }

    private static void RemoveHTMLTags(StringBuilder html)
    {
        bool inTag = false;
        for (int i = 0; i < html.Length; i++)
        {
            if (html[i] == '<')
            {
                inTag = true;
            }

            if (html[i] == '>')
            {
                html.Replace('>', ' ', i, 1);
                inTag = false;
            }

            if (inTag)
            {
                html.Remove(i--, 1);
            }
        }
    }
}