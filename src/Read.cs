using System;

namespace AddTwoNumbers
{
    public static class Read
    {
        public static void ReadNumberFromConsoleAsString(string prompt, out string x)
        {
            prompt = prompt ?? ":";
            Console.Write($"{prompt} ");
            x = Console.ReadLine();
        }
    }
}