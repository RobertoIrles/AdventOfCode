using AdventOfCode.Common;

namespace Year2015.Tests;

public class Day05Tests : DayTestBase<Day05>
{
    [Theory]
    [InlineData("ugknbfddgicrmopn\naaa\njchzalrnumimnmhp\nhaegwjzuvuyypxyu\ndvszwmarrgswjxmb", "2")]
    public void Part1_Examples(string input, string expected)
    {
        AssertPart1(input, expected);
    }
}