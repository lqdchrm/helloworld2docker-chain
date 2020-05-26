using System;

namespace AddTwoNumbers
{
    public static class Write
    {
        public static void WriteResultToConsole(string formatString, string resultAsString)
        {
            Console.WriteLine(string.Format(formatString, resultAsString));
        }
    }
}