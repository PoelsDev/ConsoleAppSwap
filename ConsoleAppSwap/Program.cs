using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleAppSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int b = 6;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Swap(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        static void Swap(ref int a, ref int b)
        {
            int aCopy;
            aCopy = a;
            a = b;
            b = aCopy;
        }
    }
}
