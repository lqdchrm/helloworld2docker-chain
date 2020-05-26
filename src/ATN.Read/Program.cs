using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATN.Read
{
    public static class Program
    {
        /// <summary>
        /// asks for two numbers from stdin and prints them to stdout
        /// </summary>
        /// <param name="args"></param>
        public static void Main(params string[] args)
        {
            string[] result = new string[2];
            Read.ReadNumberFromConsoleAsString("Input number a:", out result[0]);
            Read.ReadNumberFromConsoleAsString("Input number b:", out result[1]);

            Console.WriteLine($"{result[0]} {result[1]}");
        }
    }
}
