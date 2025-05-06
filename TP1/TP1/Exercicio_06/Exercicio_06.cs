using System;


namespace TP1
{
    internal class Exercicio_06
    {
        internal void Start()
        {
            Action<string> logDelegate = Logger.LogToConsole;
            logDelegate += Logger.LogToFile;
            logDelegate += Logger.LogToDataBase;

            logDelegate("Registro criado com sucesso!");

            Console.WriteLine("Aplciação Finalziada");
            Console.ReadKey();
        }
    }
}
