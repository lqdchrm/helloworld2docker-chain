using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATN.Calc
{
    public static class Program
    {
        /// <summary>
        /// reads two numbers as params from commandline and prints their sum to stdout
        /// </summary>
        /// <param name="args"></param>
        public static void Main(params string[] args)
        {
            if (args.Length == 0)
                args = Console.ReadLine().Split(" ").ToArray();

            // functional conversion aka "map" => is independent of array sizes
            var converted = args.Select(Calc.ConvertNumberFromString).ToArray();

            var sum = Calc.AddNumbers(converted[0], converted[1]);

            Console.WriteLine(sum);
        }
    }
}
