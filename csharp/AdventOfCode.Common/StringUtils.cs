namespace AdventOfCode.Common;

public static class StringUtils
{
    public static string[] SepararLineas(string input)
    {
        return input.Split(['\r', '\n'], StringSplitOptions.RemoveEmptyEntries);
    }
}