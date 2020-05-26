using System;

namespace AddTwoNumbers
{
    public class Program
    {
        /// <summary>
        /// Using shell conventions for return typ: 0 = ok, else = error
        /// </summary>
        /// <param name="args">not used</param>
        /// <returns>0 = ok, else = error</returns>
        static int Main(string[] args)
        {
            // Read
            string strA, strB;
            ReadNumberFromConsoleAsString("Input number a:", out strA);
            ReadNumberFromConsoleAsString("Input number b:", out strB);

            // Calc
            int a, b;
            try
            {
                a = ConvertNumberFromString(strA);
                b = ConvertNumberFromString(strB);
            } catch (Exception)
            {
                Console.Error.WriteLine("Malformed input");
                return -1;
            }

            int result = AddNumbers(a, b);

            // Write
            try
            {
                WriteResultToConsole("a + b = {0}", result);
            } catch(Exception)
            {
                Console.Error.WriteLine("Something went wrong internally. Probably a developer messed up string formatting.");
                return -1;
            }

            return 0;
        }

        public static void ReadNumberFromConsoleAsString(string prompt, out string x)
        {
            prompt = prompt ?? ":";
            Console.Write($"{prompt} ");
            x = Console.ReadLine();
        }

        public static int ConvertNumberFromString(string str) => int.Parse(str);

        public static int AddNumbers(int a, int b) => a + b;

        public static void WriteResultToConsole(string formatString, int result)
        {
            Console.WriteLine(string.Format(formatString, result));
        }
    }
}
