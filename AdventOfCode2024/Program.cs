// See https://aka.ms/new-console-template for more information

using AdventOfCode2024.Days;

const string inputPathPrefix = "../../../Inputs/";

List<string> testInput =
[
    "3   4",
    "4   3",
    "2   5",
    "1   3",
    "3   9",
    "3   3"
];

var input = File.ReadAllLines($"{inputPathPrefix}/input1.txt").ToList();

var day1 = new Day1();
// Console.WriteLine(day1.Part1(input));
Console.WriteLine(day1.Part2(input));