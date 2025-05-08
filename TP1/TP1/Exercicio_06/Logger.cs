using System;

namespace TP1
{
    internal class Logger
    {

        public void LogToConsole(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine($"[Console] {mensagem}");
            Console.ResetColor();
        }
        public void LogToFile(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[Arquivo] {mensagem}");
            Console.ResetColor();
        }
        public void LogToDataBase(string mensagem)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[Data Base] {mensagem}");
            Console.ResetColor();
        }
    }
}
