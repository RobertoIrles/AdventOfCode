namespace AdventOfCode.Common;

using System.IO;
using Xunit;

public abstract class DayTestBase<TDay> where TDay : IDay, new()
{
    protected readonly TDay Day = new();

    /// <summary>
    /// Ruta esperada del input real, por defecto deduce la carpeta a partir del nombre del tipo.
    /// Ejemplo: Para 'Day01Tests' o 'Day01', busca 'Day01/input.txt'.
    /// </summary>
    protected virtual string InputFilePath
    {
        get
        {
            string dayFolder = typeof(TDay).Name; // "Day01"
            return Path.Combine(dayFolder, "input.txt");
        }
    }

    /// <summary>
    /// Valida la Parte 1 contra un texto arbitrario (ejemplos del enunciado).
    /// </summary>
    protected void AssertPart1(string input, string expected)
    {
        string actual = Day.SolvePart1(input);
        Assert.Equal(expected, actual);
    }

    /// <summary>
    /// Valida la Parte 2 contra un texto arbitrario (ejemplos del enunciado).
    /// </summary>
    protected void AssertPart2(string input, string expected)
    {
        string actual = Day.SolvePart2(input);
        Assert.Equal(expected, actual);
    }

    /// <summary>
    /// Ejecuta la prueba con el archivo input.txt únicamente si existe en disco.
    /// Si no existe (p. ej. en GitHub Actions), la prueba termina sin fallar.
    /// </summary>
    protected void AssertRealInputPart1(string expected)
    {
        if (!File.Exists(InputFilePath))
            return;

        string input = File.ReadAllText(InputFilePath);
        Assert.Equal(expected, Day.SolvePart1(input));
    }

    /// <summary>
    /// Ejecuta la prueba de la parte 2 con el archivo input.txt si existe.
    /// </summary>
    protected void AssertRealInputPart2(string expected)
    {
        if (!File.Exists(InputFilePath))
            return;

        string input = File.ReadAllText(InputFilePath);
        Assert.Equal(expected, Day.SolvePart2(input));
    }
}