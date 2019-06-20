using P01.ListyIterator;
using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            ListyIterator<string> listy = null;

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    if (command.Contains("Create"))
                    {
                        List<string> items = command
                            .Split().Skip(1).ToList();

                        listy = new ListyIterator<string>(items);
                    }
                    else if (command == "Move")
                    {
                        Console.WriteLine(listy.Move());
                    }
                    else if (command == "Print")
                    {
                        listy.Print();
                    }
                    else if (command == "HasNext")
                    {
                        Console.WriteLine(listy.HasNext());
                    }
                    else if (command == "PrintAll")
                    {
                        foreach (var item in listy)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
