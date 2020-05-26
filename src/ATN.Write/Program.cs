using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATN.Write
{
    public static class Program
    {
        /// <summary>
        /// gets a numbers as commandline-arg and writes it to stdout
        /// </summary>
        /// <param name="args"></param>
        public static void Main(params string[] args)
        {
            if (args.Length == 0)
                args = new string[] { Console.ReadLine() };

            Write.WriteResultToConsole("{0}", args[0]);
        }
    }
}
