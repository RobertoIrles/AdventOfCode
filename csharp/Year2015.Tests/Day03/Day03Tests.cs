using AdventOfCode.Common;

namespace Year2015.Tests;

public class Day03Tests : DayTestBase<Day03>
{
    [Theory]
    [InlineData(">", "2")]
    [InlineData("^>v<", "4")]
    [InlineData("^v^v^v^v^v", "2")]
    public void Part1_Examples(string input, string expected)
    {
        AssertPart1(input, expected);
    }

    [Theory]
    [InlineData("^v", "3")]
    [InlineData("^>v<", "3")]
    [InlineData("^v^v^v^v^v", "11")]
    public void Part2_Examples(string input, string expected)
    {
        AssertPart2(input, expected);
    }
}