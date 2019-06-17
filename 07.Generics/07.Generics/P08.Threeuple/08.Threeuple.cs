using System;

namespace P08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split();
           var tupleOne = new MyThreeuple<string, string, string>();
            string itemOne = $"{input[0]} {input[1]}";
            string itemTwo = input[2];
            string itemThree = input[3];
            tupleOne.ItemOne = itemOne;
            tupleOne.ItemTwo = itemTwo;
            tupleOne.ItemThree = itemThree;

            input = Console.ReadLine()
                .Split();
            var tupleTwo = new MyThreeuple<string, int, bool>();
            string name = input[0];
            int liters = int.Parse(input[1]);
            bool drunkOrNot = false;
            if (input[2] == "drunk")
            {
                drunkOrNot = true;
            }
            tupleTwo.ItemOne = name;
            tupleTwo.ItemTwo = liters;
            tupleTwo.ItemThree = drunkOrNot;

            input = Console.ReadLine()
                .Split();
            var tupleThree = new MyThreeuple<string, double, string>();
            string number = input[0];
            double floater = double.Parse(input[1]);
            string bankName = input[2];
            tupleThree.ItemOne = number;
            tupleThree.ItemTwo = floater;
            tupleThree.ItemThree = bankName;

            Console.WriteLine($"{tupleOne.ItemOne} -> {tupleOne.ItemTwo} -> {tupleOne.ItemThree}");
            Console.WriteLine($"{tupleTwo.ItemOne} -> {tupleTwo.ItemTwo} -> {tupleTwo.ItemThree}");
            Console.WriteLine($"{tupleThree.ItemOne} -> {tupleThree.ItemTwo} -> {tupleThree.ItemThree}");
        }
    }
}
