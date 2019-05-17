using System;
using System.Collections.Generic;
using System.Linq;

namespace P08.BalancedParanthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stackOfParanthesis = new Stack<char>();
            char[] input = Console.ReadLine()
                .ToCharArray();
            char[] openParanthesis = new char[] { '(', '[', '{' };

            bool isValid = true;


            foreach (var item in input)
            {
                if (openParanthesis.Contains(item))
                {
                    stackOfParanthesis.Push(item);
                    continue;
                    
                }
                if (stackOfParanthesis.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParanthesis.Peek() == '(' || item == ')')
                {
                    stackOfParanthesis.Pop();
                }
                else if (stackOfParanthesis.Peek() == '[' || item == ']')
                {
                    stackOfParanthesis.Pop();
                }
                else if (stackOfParanthesis.Peek() == '{' || item == '}')
                {
                    stackOfParanthesis.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
