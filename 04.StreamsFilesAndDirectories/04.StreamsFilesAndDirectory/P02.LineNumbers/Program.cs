using System;
using System.IO;
using System.Linq;

namespace P02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");

            int counter = 1;

            foreach (var line in lines)
            {
                int letterCount = line.Count(char.IsLetter);
                int punctsCount = line.Count(char.IsPunctuation);

                File.AppendAllText("output.txt", $"Line {counter++}: {line} ({letterCount})({punctsCount}){Environment.NewLine}");
            }

            
        }
    }
}
