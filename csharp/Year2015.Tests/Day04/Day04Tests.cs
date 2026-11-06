using AdventOfCode.Common;

namespace Year2015.Tests;

public class Day04Tests : DayTestBase<Day04>
{
    [Theory]
    [InlineData("abcdef", "609043")]
    [InlineData("pqrstuv", "1048970")]
    public void Part1_Examples(string input, string expected)
    {
        AssertPart1(input, expected);
    }
}