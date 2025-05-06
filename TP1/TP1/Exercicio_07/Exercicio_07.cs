using System;


namespace TP1
{
    internal class Exercicio_07
    {
        internal void Start()
        {
            Action<string> logDelegate = null;
            logDelegate?.Invoke("Registro criado com sucesso!");

            Console.WriteLine("Aplciação Finalziada");
            Console.ReadKey();
        }
    }
}
