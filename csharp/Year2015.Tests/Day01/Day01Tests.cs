namespace Year2015.Tests.Day01;

using AdventOfCode.Common;
using Year2015.Day01;
using Xunit;

public class Day01Tests : DayTestBase<Day01>
{
    // 1. Ejemplos del enunciado (siempre se ejecutan)
    [Theory]
    [InlineData("(())", "0")]
    [InlineData("(((", "3")]
    [InlineData("())", "-1")]
    public void Part1_Examples(string input, string expected)
    {
        AssertPart1(input, expected);
    }

    [Theory]
    [InlineData(")", "1")]
    [InlineData("()())", "5")]
    public void Part2_Examples(string input, string expected)
    {
        AssertPart2(input, expected);
    }

    // 2. Input real (solo corre si Day01/input.txt está descargado)
    [Fact]
    public void Part1_RealInput()
    {
        AssertRealInputPart1("232"); // Tu solución esperada de la parte 1
    }

    [Fact]
    public void Part2_RealInput()
    {
        AssertRealInputPart2("1783"); // Tu solución esperada de la parte 2
    }
}