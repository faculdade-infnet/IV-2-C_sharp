using System;

namespace TP1
{
    internal class Concatenar
    {
        internal static string Concatena(string nome, string sobrenome)
        {
            string resultado = nome + " " + sobrenome;
            Console.WriteLine($"[Concatenar] => '{resultado}'");
            return resultado;
        }

        internal static string ParaMaiusculas(string nome, string sobrenome)
        {
            string resultado = (nome + " " + sobrenome).ToUpper();
            Console.WriteLine($"[ParaMaiusculas] => '{resultado}'");
            return resultado;
        }

        internal static string RemoverEspacos(string nome, string sobrenome)
        {            
            string resultado = (nome + " " + sobrenome).Replace(" ", "");
            Console.WriteLine($"[RemoverEspacos] => '{resultado}'");
            return resultado;
        }
    }
}
