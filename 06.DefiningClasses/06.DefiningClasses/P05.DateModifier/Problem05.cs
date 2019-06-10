using P05.DateModifier;
using System;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string dateOne = Console.ReadLine();
            string dateTwo = Console.ReadLine();

            DateModifier dateModifier = new DateModifier(dateOne, dateTwo);

            int result = dateModifier.TheDifferance();

            Console.WriteLine(result);
        }
    }
}
