using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = m => Console.WriteLine(m);

            Console.ReadLine()
                .Split()
                .ToList()
                .ForEach(print);
           
        }
    }
}
