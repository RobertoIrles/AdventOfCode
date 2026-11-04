namespace Year2015.Day01;

using AdventOfCode.Common;

public class Day01 : IDay
{
    const int PISO_INICIAL = 0;

    public string SolvePart1(string input)
    {
        int piso = PISO_INICIAL;

        foreach (char caracter in input)
        {
            piso += (caracter == '(') ? 1 : -1;
        }

        return piso.ToString();
    }

    public string SolvePart2(string input)
    {
        int piso = PISO_INICIAL;

        for (int i = 0; i < input.Count(); i++)
        {
            piso += (input[i] == '(') ? 1 : -1;

            if (piso == -1)
            {
                return (i + 1).ToString();
            }
        }

        return "No se ha encontrado";
    }
}