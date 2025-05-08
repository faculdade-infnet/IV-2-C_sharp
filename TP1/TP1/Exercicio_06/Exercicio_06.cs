using System;


namespace TP1
{
    internal class Exercicio_06
    {
        internal void Start()
        {
            Logger logger = new Logger();

            Action<string> logDelegate = logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDataBase;

            logDelegate("Registro criado com sucesso!");

            Console.WriteLine("Aplciação Finalziada");
            Console.ReadKey();
        }
    }
}
