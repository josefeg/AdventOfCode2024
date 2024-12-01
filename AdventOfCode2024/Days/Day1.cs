namespace AdventOfCode2024.Days;

public class Day1
{
    public int Part1(List<string> inputLines)
    {
        var distance = 0;
        var (leftList, rightList) = ParseInput(inputLines);
        for (var i = 0; i < inputLines.Count; i++)
        {
            distance += Math.Abs(leftList[i] - rightList[i]);
        }

        return distance;
    }

    public int Part2(List<string> inputLines)
    {
        var (leftList, rightList) = ParseInput(inputLines);
        var occurences = rightList.Aggregate(new Dictionary<int, int>(), (acc, value) =>
        {
            var amount = acc.ContainsKey(value) ? acc[value] + 1 : 1;
            acc[value] = amount;

            return acc;
        });
        
        
        var similarityScore = leftList.Aggregate(0, (acc, value) =>
        {
            acc += value * occurences.GetValueOrDefault(value, 0);
            return acc;
        });

        return similarityScore;
    }

    private (List<int>, List<int>) ParseInput(List<string> inputLines)
    {
        var leftList = new List<int>(inputLines.Count);
        var rightList = new List<int>(inputLines.Count);
        inputLines.Aggregate((leftList, rightList), (accumulator, line) =>
        {
            var values = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            accumulator.leftList.Add(int.Parse(values[0].Trim()));
            accumulator.rightList.Add(int.Parse(values[1].Trim()));

            return accumulator;
        });
        leftList.Sort();
        rightList.Sort();

        return (leftList, rightList);
    }
}