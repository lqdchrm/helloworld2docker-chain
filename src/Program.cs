using System;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Using shell conventions for return typ: 0 = ok, else = error
        /// </summary>
        /// <param name="args">not used</param>
        /// <returns>0 = ok, else = error</returns>
        static int Main(string[] args)
        {
            int a, b;

            // Read
            try
            {
                ReadNumberFromConsole("Input number a:", out a);
                ReadNumberFromConsole("Input number b:", out b);
            } catch (Exception)
            {
                Console.Error.WriteLine("Malformed input");
                return -1;
            }

            // Calc
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

        private static void ReadNumberFromConsole(string prompt, out int x)
        {
            prompt = prompt ?? ":";
            Console.Write($"{prompt} ");
            var str = Console.ReadLine();
            x = int.Parse(str);
        }

        private static int AddNumbers(int a, int b) => a + b;

        private static void WriteResultToConsole(string formatString, int result)
        {
            Console.WriteLine(string.Format(formatString, result));
        }
    }
}
