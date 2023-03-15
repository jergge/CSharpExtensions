using System;
using System.Collections;

public static partial class Extensions
{
    /// <summary>
    /// Itterates recursivly through a list. Calls ToString() on each non IList element
    /// </summary>
    /// <param name="list"></param>
    /// <param name="indent"></param>
    public static void ConsolePrint(this IList list, int indent = 0)
    {
        string firstLine = "";
        for (int i = 0; i < indent; i++)
        {
            firstLine += " ";
        }
        firstLine += "List: {";
        Console.WriteLine(firstLine);

        foreach (var item in list)
        {
            if (item is IList ilist)
            {
                ilist.ConsolePrint(indent + 4);
            }
            else if (item is not null)
            {
                string outputBuffer = "";
                for (int i = 0; i < indent + 2; i++)
                {
                    outputBuffer += " ";
                }
                outputBuffer += item.GetType() + ": ";
                outputBuffer += item.ToString();
                Console.WriteLine(outputBuffer);
            }
        }

        string lastLine = "";
        for (int i = 0; i < indent; i++)
        {
            lastLine += " ";
        }
        lastLine += "}";
        Console.WriteLine(lastLine);
    }
}