using System.Security.Cryptography;
using System.Text.RegularExpressions;
using AdventOfCode.Common;

namespace Year2015;

public class Day04 : IDay
{
    public string SolvePart1(string input)
    {
        Regex regex = new Regex("^00000");

        string solucion;
        int i = -1;
        do
        {
            solucion = codificar(input, i);

            i++;
        } while (!regex.IsMatch(solucion));
        
        return (i - 1).ToString();
    }

    public string SolvePart2(string input)
    {
        Regex regex = new Regex("^000000");

        string solucion;
        int i = -1;
        do
        {
            solucion = codificar(input, i);

            i++;
        } while (!regex.IsMatch(solucion));
        
        return (i - 1).ToString();
    }

    private string codificar(string input, int numero)
    {
        using (MD5 md5 = MD5.Create())
        {
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(numero < 0 ? input : input + numero);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            return Convert.ToHexString(hashBytes);
        }
    }
}