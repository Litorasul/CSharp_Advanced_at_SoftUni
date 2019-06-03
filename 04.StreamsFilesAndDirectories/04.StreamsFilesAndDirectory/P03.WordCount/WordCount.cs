using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textLines = File.ReadAllLines("text.txt");
            string[] wordLines = File.ReadAllLines("words.txt");

            Dictionary<string, int> wordsInfo = new Dictionary<string, int>();

            foreach (var word in wordLines)
            {
                string wordLower = word.ToLower();
                if (!wordsInfo.ContainsKey(wordLower))
                {
                    wordsInfo.Add(wordLower, 0);
                }
            }

            foreach (var line in textLines)
            {
                string[] curentWords = line
                    .ToLower()
                    .Split(new char[] { '.', ',', '!', '?', '-', '\'', ' ' });

                foreach (var currentWord in curentWords)
                {
                    if (wordsInfo.ContainsKey(currentWord))
                    {
                        wordsInfo[currentWord]++;
                    }
                }
            }

            foreach (var (key, value) in wordsInfo)
            {
                File.AppendAllText("actualResult.txt", $"{key} - {value} {Environment.NewLine}");
            }

            foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
            {
                File.AppendAllText("expectedResult.txt", $"{key} - {value} {Environment.NewLine}");
            }
        }
    }
}
