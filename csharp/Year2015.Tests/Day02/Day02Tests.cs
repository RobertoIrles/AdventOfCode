using AdventOfCode.Common;

namespace Year2015.Tests;

public class Day02Tests : DayTestBase<Day02>
{
    [Theory]
    [InlineData("2x3x4", "58")]
    [InlineData("1x1x10", "43")]
    public void Part1_Examples(string input, string expected)
    {
        AssertPart1(input, expected);
    }

    [Fact]
    public void Part1_RealInput()
    {
        AssertRealInputPart1("1586300");
    }

    [Theory]
    [InlineData("2x3x4", "34")]
    [InlineData("1x1x10", "14")]
    public void Part2_Examples(string input, string expected)
    {
        AssertPart2(input, expected);
    }

    [Fact]
    public void Part2_RealInput()
    {
        AssertRealInputPart2("3737498");
    }
}