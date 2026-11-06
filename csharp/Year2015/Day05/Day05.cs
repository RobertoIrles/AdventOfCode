using System.Text.RegularExpressions;
using AdventOfCode.Common;

namespace Year2015;

public class Day05 : IDay
{
    public string SolvePart1(string input)
    {
        Regex[] patronesPermitidos = [
            new Regex("(\\w)\\1"),
            new Regex("[aeiou].*[aeiou].*[aeiou]")
        ];

        Regex[] patronesProhibidos = [
            new Regex("ab|cd|pq|xy")
        ];

        int i = 0;

        foreach (string cadena in StringUtils.SepararLineas(input))
        {
            if (comprobar(cadena, patronesPermitidos, patronesProhibidos))
            {
                i++;
            }
        }

        return i.ToString();
    }

    public string SolvePart2(string input)
    {
        Regex[] patronesPermitidos = [
            new Regex("([a-z]{2}).*\\1"),
            new Regex("([a-z]).\\1")
        ];

        Regex[] patronesProhibidos = [];

        int i = 0;

        foreach (string cadena in StringUtils.SepararLineas(input))
        {
            if (comprobar(cadena, patronesPermitidos, patronesProhibidos))
            {
                i++;
            }
        }

        return i.ToString();
    }

    private bool comprobar(string cadena, Regex[] patronesPermitidos, Regex[] patronesProhibidos)
    {
        foreach (Regex regex in patronesPermitidos)
        {
            if (!regex.IsMatch(cadena))
            {
                return false;
            }
        }

        foreach (Regex regex in patronesProhibidos)
        {
            if (regex.IsMatch(cadena))
            {
                return false;
            }
        }

        return true;
    }
}