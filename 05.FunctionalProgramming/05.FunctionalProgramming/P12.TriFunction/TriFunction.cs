using System;
using System.Linq;

namespace P12.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Func<string, int, bool> isLarger = (name, charsLenght)
                => name.Sum(x => x) >= charsLenght;

            Func<string[], Func<string, int, bool>, string> namesFilter =
                (inputNames, isLargerFunc)
                => inputNames.FirstOrDefault(x => isLargerFunc(x, lenght));

            string result = namesFilter(names, isLarger);

            Console.WriteLine(result);


        }
    }
}
