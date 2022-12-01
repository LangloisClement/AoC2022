using AoC2022.script;
using System;

namespace AoC2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Advent of Code!");
            Day1 day1 = new Day1("../../../input/inputD1.txt");
            Console.WriteLine(day1.Part1);
            Console.WriteLine(day1.Part2);
        }
    }
}
