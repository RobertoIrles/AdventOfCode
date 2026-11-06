using AdventOfCode.Common;
using Year2015;

Console.WriteLine("--- Advent of Code 2015 ---");

short diaShort = 0;
IDay? day = null;



if (args.Length > 0 && short.TryParse(args[0], out short argDia))
{
    diaShort = argDia;
    day = GetDay(diaShort);
}



while (day == null)
{
    Console.Write("Elige un día para ejecutar (1-25) -> ");
    string inputUser = Console.ReadLine() ?? "";

    if (short.TryParse(inputUser, out diaShort))
    {
        day = GetDay(diaShort);
        if (day == null) 
            Console.WriteLine("Día no implementado todavía.");
    }
    else
    {
        Console.WriteLine("Por favor, introduce un número válido.");
    }
}

string diaFormated = $"{diaShort:D2}";
string inputPath = Path.Combine(AppContext.BaseDirectory, $"Day{diaFormated}", "input.txt");



if (!File.Exists(inputPath))
    inputPath = $"Day{diaFormated}/input.txt";

if (!File.Exists(inputPath))
{
    Console.WriteLine($"[AVISO] No se encontró {inputPath}. Introduce el input manualmente o descarga el archivo.");
    return;
}

string input = File.ReadAllText(inputPath);

Console.WriteLine($"\n--- Resultados Día {diaFormated} ---");
Console.WriteLine($"Parte 1: {day.SolvePart1(input)}");
Console.WriteLine($"Parte 2: {day.SolvePart2(input)}");




static IDay? GetDay(short dia) => dia switch
{
    1 => new Day01(),
    2 => new Day02(),
    3 => new Day03(),
    4 => new Day04(),
    _ => null
};