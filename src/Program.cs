using System;
using System.Linq;

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
            try
            {
                string[] numbersAsStringArray = ReadNumbers();

                string[] resultAsStringArray = CalcSum(numbersAsStringArray);

                WriteSum(resultAsStringArray);

            } catch(Exception exc) {
                Console.Error.Write("Something went wrong: ");
                Console.Error.WriteLine(exc.Message);
                return -1;
            }

            return 0;
        }

        private static string[] ReadNumbers()
        {
            string[] result = new string[2];
            Read.ReadNumberFromConsoleAsString("Input number a:", out result[0]);
            Read.ReadNumberFromConsoleAsString("Input number b:", out result[1]);
            return result;
        }

        private static string[] CalcSum(params string[] args)
        {
            // functional conversion aka "map" => is independent of array sizes
            var converted = args.Select(Calc.ConvertNumberFromString).ToArray();

            var sum = Calc.AddNumbers(converted[0], converted[1]);

            return new string[] { sum.ToString() };
        }

        private static void WriteSum(params string[] args)
        {
            Write.WriteResultToConsole("{0}", args[0]);
        }
    }
}
