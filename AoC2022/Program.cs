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
            Console.WriteLine("DAY 1 -----------------");
            Console.WriteLine(day1.Part1);
            Console.WriteLine(day1.Part2);
            Console.WriteLine("DAY 2 -----------------");
            Console.WriteLine(Day2.part1("../../../input/inputD2.txt"));
        }
    }
}
