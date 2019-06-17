using System;

namespace P07.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
            MyTuple<string, string> tupleOne = new MyTuple<string, string>();
            string itemOne = $"{input[0]} {input[1]}";
            string itemTwo = input[2];
            tupleOne.ItemOne = itemOne;
            tupleOne.ItemTwo = itemTwo;

            input = Console.ReadLine()
                .Split();
            MyTuple<string, int> tupleTwo = new MyTuple<string, int>();
            string name = input[0];
            int liters = int.Parse(input[1]);
            tupleTwo.ItemOne = name;
            tupleTwo.ItemTwo = liters;

            input = Console.ReadLine()
                .Split();
            MyTuple<int, double> tupleThree = new MyTuple<int, double>();
            int number = int.Parse(input[0]);
            double floater = double.Parse(input[1]);
            tupleThree.ItemOne = number;
            tupleThree.ItemTwo = floater;

            Console.WriteLine($"{tupleOne.ItemOne} -> {tupleOne.ItemTwo}");
            Console.WriteLine($"{tupleTwo.ItemOne} -> {tupleTwo.ItemTwo}");
            Console.WriteLine($"{tupleThree.ItemOne} -> {tupleThree.ItemTwo}");

        }
    }
}
