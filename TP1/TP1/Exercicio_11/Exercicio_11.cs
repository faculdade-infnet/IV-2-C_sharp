using System;


namespace TP1
{
    internal class Exercicio_11
    {
        internal void Start()
        {
            Func<string, string, string> processador = Concatenar.Concatena;

            // Encadeando métodos
            processador += Concatenar.ParaMaiusculas;
            processador += Concatenar.RemoverEspacos;
            
            string resultado = processador(" Samuel ", " Hermany ");

            Console.ReadKey();
        }
    }
}
