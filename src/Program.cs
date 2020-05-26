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
            Console.Write("Input number a: ");
            var strA = Console.ReadLine();

            Console.Write("Input number b: ");
            var strB = Console.ReadLine();

            int a, b;
            if (!int.TryParse(strA, out a) || !int.TryParse(strB, out b))
            {
                Console.Error.WriteLine("Malformed input");
                return -1;
            }

            int result = a + b;

            Console.WriteLine($"a + b = {result}");
            return 0;
        }
    }
}
