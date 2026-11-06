using AdventOfCode.Common;

namespace Year2015;

public class Day02 : IDay
{
    public string SolvePart1(string input)
    {
        int total = input
        .Split(['\r', '\n'], StringSplitOptions.RemoveEmptyEntries)
        .Select(line => line.Split('x').Select(int.Parse).ToArray())
        .Sum(d => 
        {
            int s1 = d[0] * d[1], s2 = d[1] * d[2], s3 = d[2] * d[0];
            return 2 * (s1 + s2 + s3) + Math.Min(s1, Math.Min(s2, s3));
        });

    return total.ToString();
    }

    public string SolvePart2(string input)
    {
        int totalRibbon = 0;

        string[] lineas = input.Split(['\r', '\n'], StringSplitOptions.RemoveEmptyEntries);

        foreach (string linea in lineas)
        {
            int[] dimensiones = linea.Split('x').Select(int.Parse).ToArray();

            Array.Sort(dimensiones);

            int perimetroMenor = 2 * (dimensiones[0] + dimensiones[1]);
            int volumenLazo = dimensiones[0] * dimensiones[1] * dimensiones[2];

            totalRibbon += perimetroMenor + volumenLazo;
        }

        return totalRibbon.ToString();
    }
}