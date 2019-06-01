using System;
using System.IO;
using System.Linq;

namespace P01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "text.txt";

            using (var reader = new StreamReader(path))
            {
                int count = 0;
                string line = string.Empty;
                while ((line = reader.ReadLine()) != null)
                {
                    if (count % 2 == 0)
                    {
                        line = line.Replace('-', '@');
                        line = line.Replace(',', '@');
                        line = line.Replace('.', '@');
                        line = line.Replace('!', '@');
                        line = (string)line.Replace('?', '@');
                        string[] lineArr = line.Split();
                        lineArr = lineArr.Reverse().ToArray();
                        
                        Console.WriteLine(string.Join(" ",lineArr));
                        
                    }
                    count++;
                }
            }
        }
    }
}
