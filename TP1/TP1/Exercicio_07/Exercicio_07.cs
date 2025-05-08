using System;


namespace TP1
{
    internal class Exercicio_07
    {
        internal void Start()
        {
            Logger logger = new Logger();

            Action<string> logDelegate = null;

            logDelegate?.Invoke("Teste sem métodos associados.");

            logDelegate += logger.LogToConsole;
            logDelegate += logger.LogToFile;
            logDelegate += logger.LogToDataBase;

            logDelegate?.Invoke("Aplicação iniciada com sucesso.");
            logDelegate?.Invoke("Processo finalizado.");
        }
    }
}
