using AdventOfCode.Common;

namespace Year2015;

public class Day03 : IDay
{
    public string SolvePart1(string input)
    {
        HashSet<string> casasVisitadas = ["0x0"];

        Santa santa = new Santa();

        foreach (char direccion in input)
        {
            santa.mover(direccion);

            casasVisitadas.Add(santa.PosicionActual);
        }

        return casasVisitadas.Count.ToString();
    }

    public string SolvePart2(string input)
    {
        HashSet<string> casasVisitadas = ["0x0"];

        Santa santa = new Santa();
        Santa roboSanta = new Santa();

        for (int i = 0; i < input.Length; i++)
        {
            if (i % 2 == 0)
            {
                santa.mover(input[i]);
                casasVisitadas.Add(santa.PosicionActual);
            } else
            {
                roboSanta.mover(input[i]);
                casasVisitadas.Add(roboSanta.PosicionActual);
            }
        }

        return casasVisitadas.Count.ToString();
    }


    private class Santa
    {
        private int posicion_X = 0;
        private int posicion_Y = 0;

        public string PosicionActual
        {
            get => string.Concat(posicion_X, 'x', posicion_Y);
        }

        public void mover(char direccion)
        {
            switch (direccion)
            {
                case '^':
                    posicion_Y++;
                    break;
                case 'v':
                    posicion_Y--;
                    break;
                case '<':
                    posicion_X--;
                    break;
                case '>':
                    posicion_X++;
                    break;
                default:
                    break;
            }
        }
    }
}